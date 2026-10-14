using System;
using System.Windows.Forms;

namespace QuanLyNoiTru
{
    /// <summary>
    /// Hồ sơ bệnh án: mỗi lần khám / theo dõi là 1 dòng mới (có ngày lập) => lưu được diễn biến theo thời gian.
    /// Khi thêm lần khám mới, "Tình trạng bệnh" của bệnh nhân được cập nhật theo chẩn đoán mới nhất.
    /// Giao diện: BenhAnForm.Designer.cs
    /// </summary>
    public partial class BenhAnForm : BaseForm
    {
        bool ready;

        public BenhAnForm()
        {
            InitializeComponent();
            Bind(cmbNV,
                Db.Query(@"SELECT nv.MaNhapVien,
                                  nv.MaNhapVien + N' - ' + bn.HoTen + N' (' + nv.TrangThai + N')' AS Hien
                           FROM NHAPVIEN nv JOIN BENHNHAN bn ON bn.MaBN = nv.MaBN
                           WHERE nv.TrangThai <> N'Hủy'
                           ORDER BY nv.NgayNhapVien DESC"),
                "Hien", "MaNhapVien");
            LoadData();
            dgv.CurrentCell = null;
            ready = true;
        }

        void LoadData()
        {
            dgv.DataSource = Db.Query(
                @"SELECT MaBA AS [Mã BA], NgayLap AS [Ngày lập], TrieuChung AS [Triệu chứng], ChanDoan AS [Chẩn đoán],
                         KetQuaKham AS [Kết quả khám], HuongDieuTri AS [Hướng điều trị]
                  FROM BENHAN WHERE MaNhapVien = @nv
                  ORDER BY NgayLap DESC, MaBA DESC", Db.P("@nv", Val(cmbNV)));
            FmtCol(dgv, "Ngày lập", "dd/MM/yyyy HH:mm");
        }

        void FillInputs()
        {
            var r = dgv.CurrentRow;
            if (r == null) return;
            txtMa.Text = S(r, "Mã BA");
            txtTrieuChung.Text = S(r, "Triệu chứng");
            txtChanDoan.Text = S(r, "Chẩn đoán");
            txtKetQua.Text = S(r, "Kết quả khám");
            txtHuong.Text = S(r, "Hướng điều trị");
        }

        void ClearInputs()
        {
            txtMa.Text = txtTrieuChung.Text = txtChanDoan.Text = txtKetQua.Text = txtHuong.Text = "";
            dgv.CurrentCell = null;
        }

        // ---------- sự kiện ----------

        void cmbNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ready) return;
            LoadData();
            ClearInputs();
        }

        void dgv_SelectionChanged(object sender, EventArgs e) { if (ready) FillInputs(); }

        void btnLamMoi_Click(object sender, EventArgs e) { ClearInputs(); }

        void btnXuat_Click(object sender, EventArgs e) { XuatFile(dgv, "BenhAn"); }

        void btnThem_Click(object sender, EventArgs e)
        {
            string nv = Val(cmbNV);
            if (nv == null) { Warn("Hãy chọn hồ sơ nhập viện."); return; }
            if (txtChanDoan.Text.Trim() == "") { Warn("Vui lòng nhập chẩn đoán."); txtChanDoan.Focus(); return; }

            try
            {
                string ma = Db.NextId("BENHAN", "MaBA", "BA");
                Db.ExecTx(
                    new Stmt(@"INSERT INTO BENHAN(MaBA, MaNhapVien, TrieuChung, ChanDoan, KetQuaKham, HuongDieuTri)
                               VALUES(@ma, @nv, @tc, @cd, @kq, @hdt)",
                        Db.P("@ma", ma), Db.P("@nv", nv), Db.P("@tc", txtTrieuChung.Text.Trim()),
                        Db.P("@cd", txtChanDoan.Text.Trim()), Db.P("@kq", txtKetQua.Text.Trim()), Db.P("@hdt", txtHuong.Text.Trim())),
                    new Stmt("UPDATE BENHNHAN SET TinhTrang = @cd2 WHERE MaBN = (SELECT MaBN FROM NHAPVIEN WHERE MaNhapVien = @nv2)",
                        Db.P("@cd2", txtChanDoan.Text.Trim()), Db.P("@nv2", nv)));
                LoadData();
                ClearInputs();
                Msg("Đã lưu lần khám " + ma + ".");
            }
            catch (Exception ex) { Err(ex); }
        }

        void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "") { Warn("Hãy chọn một dòng bệnh án để cập nhật."); return; }
            if (txtChanDoan.Text.Trim() == "") { Warn("Vui lòng nhập chẩn đoán."); return; }
            try
            {
                Db.Exec(@"UPDATE BENHAN SET TrieuChung=@tc, ChanDoan=@cd, KetQuaKham=@kq, HuongDieuTri=@hdt WHERE MaBA=@ma",
                    Db.P("@tc", txtTrieuChung.Text.Trim()), Db.P("@cd", txtChanDoan.Text.Trim()),
                    Db.P("@kq", txtKetQua.Text.Trim()), Db.P("@hdt", txtHuong.Text.Trim()), Db.P("@ma", txtMa.Text));
                LoadData();
                Msg("Đã cập nhật bệnh án.");
            }
            catch (Exception ex) { Err(ex); }
        }

        void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "") { Warn("Hãy chọn một dòng bệnh án để xóa."); return; }
            if (!Confirm("Xóa bệnh án " + txtMa.Text + "?")) return;
            try
            {
                Db.Exec("DELETE FROM BENHAN WHERE MaBA=@ma", Db.P("@ma", txtMa.Text));
                LoadData();
                ClearInputs();
            }
            catch (Exception ex) { Err(ex, "Bệnh án này đã có đơn thuốc nên không thể xóa."); }
        }
    }
}
