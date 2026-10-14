using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNoiTru
{
    /// <summary>
    /// Đơn thuốc: chọn bệnh án -> chọn / tạo đơn -> thêm thuốc (tên thuốc, liều dùng, số lượng).
    /// Thêm / sửa / xóa thuốc sẽ tự trừ / cộng lại tồn kho trong 1 transaction.
    /// Giao diện: DonThuocForm.Designer.cs
    /// </summary>
    public partial class DonThuocForm : BaseForm
    {
        bool loading = true;   // true: đang nạp dữ liệu, bỏ qua sự kiện đổi lựa chọn

        public DonThuocForm()
        {
            InitializeComponent();
            LoadThuoc();
            Bind(cmbBA,
                Db.Query(@"SELECT ba.MaBA, ba.MaBA + N' - ' + bn.HoTen + N' - ' + ISNULL(ba.ChanDoan, N'') AS Hien
                           FROM BENHAN ba
                           JOIN NHAPVIEN nv ON nv.MaNhapVien = ba.MaNhapVien
                           JOIN BENHNHAN bn ON bn.MaBN = nv.MaBN
                           ORDER BY ba.NgayLap DESC, ba.MaBA DESC"),
                "Hien", "MaBA");
            LoadDon(null);   // hàm này kết thúc bằng loading = false
            dgv.CurrentCell = null;
        }

        // ---------- nạp dữ liệu ----------

        void LoadThuoc()
        {
            string cur = Val(cmbThuoc);
            Bind(cmbThuoc,
                Db.Query(@"SELECT MaThuoc, TenThuoc + N' (tồn: ' + CAST(SoLuongTon AS NVARCHAR(10)) + N')' AS Hien, DonGia
                           FROM THUOC WHERE TrangThai = 1 ORDER BY TenThuoc"),
                "Hien", "MaThuoc");
            if (cur != null) cmbThuoc.SelectedValue = cur;
            ShowGia();
        }

        void ShowGia()
        {
            var drv = cmbThuoc.SelectedItem as DataRowView;
            lblGia.Text = drv == null ? "0 đ" : Fmt.Money(Convert.ToDecimal(drv["DonGia"]));
        }

        void LoadDon(string chon)
        {
            loading = true;
            Bind(cmbDon,
                Db.Query(@"SELECT MaDon, MaDon + N' (' + CONVERT(NVARCHAR(10), NgayKeDon, 103) + N')' AS Hien
                           FROM DONTHUOC WHERE MaBA = @ba ORDER BY NgayKeDon DESC, MaDon DESC", Db.P("@ba", Val(cmbBA))),
                "Hien", "MaDon");
            if (chon != null) cmbDon.SelectedValue = chon;
            LoadCT();
            loading = false;
        }

        void LoadCT()
        {
            var dt = Db.Query(
                @"SELECT ct.MaThuoc AS [Mã thuốc], t.TenThuoc AS [Tên thuốc], ct.SoLuong AS [Số lượng],
                         ct.LieuDung AS [Liều dùng], ct.CachDung AS [Cách dùng], ct.DonGia AS [Đơn giá], ct.ThanhTien AS [Thành tiền]
                  FROM CT_DONTHUOC ct JOIN THUOC t ON t.MaThuoc = ct.MaThuoc
                  WHERE ct.MaDon = @d ORDER BY t.TenThuoc", Db.P("@d", Val(cmbDon)));
            bool old = loading; loading = true;   // nạp lưới không được điền ngược lên form
            dgv.DataSource = dt;
            loading = old;
            FmtCol(dgv, "Đơn giá", "N0");
            FmtCol(dgv, "Thành tiền", "N0");

            decimal tong = 0;
            foreach (DataRow r in dt.Rows) tong += Convert.ToDecimal(r["Thành tiền"]);
            lblTong.Text = "Tổng tiền đơn: " + Fmt.Money(tong);
        }

        void FillFromGrid()
        {
            var r = dgv.CurrentRow;
            if (r == null) return;
            if (S(r, "Mã thuốc") != "") cmbThuoc.SelectedValue = S(r, "Mã thuốc");
            int sl;
            if (int.TryParse(S(r, "Số lượng"), out sl) && sl >= 1 && sl <= nudSL.Maximum) nudSL.Value = sl;
            txtLieu.Text = S(r, "Liều dùng");
            txtCach.Text = S(r, "Cách dùng");
        }

        // ---------- sự kiện đổi lựa chọn ----------

        void cmbBA_SelectedIndexChanged(object sender, EventArgs e) { if (!loading) LoadDon(null); }

        void cmbDon_SelectedIndexChanged(object sender, EventArgs e) { if (!loading) LoadCT(); }

        void cmbThuoc_SelectedIndexChanged(object sender, EventArgs e) { ShowGia(); }

        void dgv_SelectionChanged(object sender, EventArgs e) { if (!loading) FillFromGrid(); }

        void btnXuat_Click(object sender, EventArgs e) { XuatFile(dgv, "DonThuoc"); }

        // ---------- nghiệp vụ ----------

        void btnTaoDon_Click(object sender, EventArgs e)
        {
            string ba = Val(cmbBA);
            if (ba == null) { Warn("Hãy chọn bệnh án trước."); return; }
            try
            {
                string ma = Db.NextId("DONTHUOC", "MaDon", "DT");
                Db.Exec("INSERT INTO DONTHUOC(MaDon, MaBA, GhiChu) VALUES(@ma, @ba, @gc)",
                    Db.P("@ma", ma), Db.P("@ba", ba), Db.P("@gc", txtGhiChuDon.Text.Trim()));
                txtGhiChuDon.Text = "";
                LoadDon(ma);
            }
            catch (Exception ex) { Err(ex); }
        }

        static int TonKho(string maThuoc)
        {
            return Convert.ToInt32(Db.Scalar("SELECT SoLuongTon FROM THUOC WHERE MaThuoc=@t", Db.P("@t", maThuoc)));
        }

        void btnThemThuoc_Click(object sender, EventArgs e)
        {
            string don = Val(cmbDon), th = Val(cmbThuoc);
            if (don == null) { Warn("Hãy tạo đơn mới hoặc chọn một đơn thuốc trước."); return; }
            if (th == null) { Warn("Hãy chọn thuốc."); return; }
            int sl = (int)nudSL.Value;

            try
            {
                int ton = TonKho(th);
                if (ton < sl) { Warn("Không đủ thuốc trong kho (còn " + ton + ")."); return; }

                int da = Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM CT_DONTHUOC WHERE MaDon=@d AND MaThuoc=@t", Db.P("@d", don), Db.P("@t", th)));
                if (da > 0) { Warn("Thuốc này đã có trong đơn. Hãy chọn dòng đó rồi bấm Cập nhật."); return; }

                Db.ExecTx(
                    new Stmt(@"INSERT INTO CT_DONTHUOC(MaDon, MaThuoc, SoLuong, LieuDung, CachDung, DonGia)
                               SELECT @d, @t, @sl, @lieu, @cach, DonGia FROM THUOC WHERE MaThuoc = @t",
                        Db.P("@d", don), Db.P("@t", th), Db.P("@sl", sl),
                        Db.P("@lieu", txtLieu.Text.Trim()), Db.P("@cach", txtCach.Text.Trim())),
                    new Stmt("UPDATE THUOC SET SoLuongTon = SoLuongTon - @sl WHERE MaThuoc = @t", Db.P("@sl", sl), Db.P("@t", th)));

                LoadCT();
                LoadThuoc();
            }
            catch (Exception ex) { Err(ex); }
        }

        void btnCapNhat_Click(object sender, EventArgs e)
        {
            var r = dgv.CurrentRow;
            string don = Val(cmbDon);
            if (r == null || don == null) { Warn("Hãy chọn một dòng thuốc trong đơn để cập nhật."); return; }

            string th = S(r, "Mã thuốc");
            int cu = int.Parse(S(r, "Số lượng"));
            int moi = (int)nudSL.Value;
            int chenh = moi - cu;

            try
            {
                if (chenh > TonKho(th)) { Warn("Không đủ thuốc trong kho để tăng số lượng."); return; }
                Db.ExecTx(
                    new Stmt("UPDATE CT_DONTHUOC SET SoLuong=@sl, LieuDung=@lieu, CachDung=@cach WHERE MaDon=@d AND MaThuoc=@t",
                        Db.P("@sl", moi), Db.P("@lieu", txtLieu.Text.Trim()), Db.P("@cach", txtCach.Text.Trim()),
                        Db.P("@d", don), Db.P("@t", th)),
                    new Stmt("UPDATE THUOC SET SoLuongTon = SoLuongTon - @c WHERE MaThuoc = @t", Db.P("@c", chenh), Db.P("@t", th)));
                LoadCT();
                LoadThuoc();
            }
            catch (Exception ex) { Err(ex); }
        }

        void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            var r = dgv.CurrentRow;
            string don = Val(cmbDon);
            if (r == null || don == null) { Warn("Hãy chọn một dòng thuốc trong đơn để xóa."); return; }
            if (!Confirm("Xóa thuốc " + S(r, "Tên thuốc") + " khỏi đơn? (số lượng sẽ được hoàn lại kho)")) return;

            string th = S(r, "Mã thuốc");
            int sl = int.Parse(S(r, "Số lượng"));
            try
            {
                Db.ExecTx(
                    new Stmt("DELETE FROM CT_DONTHUOC WHERE MaDon=@d AND MaThuoc=@t", Db.P("@d", don), Db.P("@t", th)),
                    new Stmt("UPDATE THUOC SET SoLuongTon = SoLuongTon + @sl WHERE MaThuoc = @t", Db.P("@sl", sl), Db.P("@t", th)));
                LoadCT();
                LoadThuoc();
            }
            catch (Exception ex) { Err(ex); }
        }
    }
}
