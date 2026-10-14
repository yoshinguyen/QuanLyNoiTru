using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyNoiTru
{
    /// <summary>
    /// Tạo hồ sơ nhập viện, gán Khoa -> Phòng -> Giường + Bác sĩ phụ trách, ngày vào / ra viện.
    /// Giường chỉ chọn được khi còn "Trống"; ra viện / hủy sẽ tự giải phóng giường.
    /// Giao diện: NhapVienForm.Designer.cs
    /// </summary>
    public partial class NhapVienForm : BaseForm
    {
        bool loading = true;         // true: đang nạp dữ liệu, bỏ qua sự kiện đổi lựa chọn
        string editingBed = "";      // giường hiện tại của hồ sơ đang chọn
        string editingStatus = "";   // trạng thái của hồ sơ đang chọn

        public NhapVienForm()
        {
            InitializeComponent();
            cmbLoc.SelectedIndex = 0;
            Bind(cmbBN, Db.Query("SELECT MaBN, MaBN + N' - ' + HoTen AS Hien FROM BENHNHAN ORDER BY MaBN"), "Hien", "MaBN");
            Bind(cmbKhoa, Db.Query("SELECT MaKhoa, TenKhoa FROM KHOA ORDER BY MaKhoa"), "TenKhoa", "MaKhoa");
            loading = false;
            LoadPhongBS();
            LoadData();
            dgv.CurrentCell = null;
        }

        // ---------- nạp dữ liệu ----------

        void LoadPhongBS()
        {
            string k = Val(cmbKhoa);
            bool old = loading; loading = true;
            Bind(cmbPhong,
                Db.Query(@"SELECT MaPhong, TenPhong + N' - ' + CAST(CAST(DonGia AS INT) AS NVARCHAR(20)) + N'đ/ngày' AS Hien
                           FROM PHONG WHERE MaKhoa = @k AND TrangThai = 1 ORDER BY MaPhong", Db.P("@k", k)),
                "Hien", "MaPhong");
            Bind(cmbBS,
                Db.Query(@"SELECT MaBS, MaBS + N' - ' + HoTen AS Hien
                           FROM BACSI WHERE MaKhoa = @k AND TrangThai = 1 ORDER BY MaBS", Db.P("@k", k)),
                "Hien", "MaBS");
            loading = old;
            LoadGiuong();
        }

        void LoadGiuong()
        {
            string ph = Val(cmbPhong);
            bool old = loading; loading = true;
            Bind(cmbGiuong,
                Db.Query(@"SELECT MaGiuong, N'Giường ' + CAST(SoGiuong AS NVARCHAR(5)) + N' (' + MaGiuong + N')' AS Hien
                           FROM GIUONG
                           WHERE MaPhong = @p AND (TrangThai = N'Trống' OR MaGiuong = @cur)
                           ORDER BY SoGiuong", Db.P("@p", ph), Db.P("@cur", editingBed)),
                "Hien", "MaGiuong");
            loading = old;
        }

        void LoadData()
        {
            bool old = loading; loading = true;   // không để SelectionChanged điền form khi chỉ nạp lại lưới
            dgv.DataSource = Db.Query(
                @"SELECT nv.MaNhapVien AS [Mã NV], nv.MaBN AS [Mã BN], bn.HoTen AS [Bệnh nhân],
                         nv.MaBS AS [Mã BS], bs.HoTen AS [Bác sĩ],
                         p.MaKhoa AS [Mã khoa], p.MaPhong AS [Mã phòng], p.TenPhong AS [Phòng], nv.MaGiuong AS [Mã giường],
                         nv.NgayNhapVien AS [Ngày vào viện], nv.NgayRaVien AS [Ngày ra viện],
                         nv.LyDoNhapVien AS [Lý do], nv.TrangThai AS [Trạng thái], nv.GhiChu AS [Ghi chú]
                  FROM NHAPVIEN nv
                  JOIN BENHNHAN bn ON bn.MaBN = nv.MaBN
                  LEFT JOIN BACSI bs ON bs.MaBS = nv.MaBS
                  LEFT JOIN GIUONG g ON g.MaGiuong = nv.MaGiuong
                  LEFT JOIN PHONG p ON p.MaPhong = g.MaPhong
                  WHERE (@tt = N'Tất cả' OR nv.TrangThai = @tt)
                    AND (nv.MaNhapVien LIKE @k OR nv.MaBN LIKE @k OR bn.HoTen LIKE @k)
                  ORDER BY nv.NgayNhapVien DESC",
                Db.P("@tt", cmbLoc.Text), Db.P("@k", "%" + txtTim.Text.Trim() + "%"));
            loading = old;
            FmtCol(dgv, "Ngày vào viện", "dd/MM/yyyy HH:mm");
            FmtCol(dgv, "Ngày ra viện", "dd/MM/yyyy HH:mm");
            // ẩn bớt cột mã dùng nội bộ cho gọn (vẫn có trong file xuất ra)
            foreach (var c in new[] { "Mã khoa", "Mã phòng" })
                if (dgv.Columns.Contains(c)) dgv.Columns[c].Visible = false;
        }

        // ---------- chọn dòng / làm mới ----------

        void SelectRow()
        {
            var r = dgv.CurrentRow;
            if (r == null) return;

            loading = true;
            editingBed = S(r, "Mã giường");
            editingStatus = S(r, "Trạng thái");
            txtMa.Text = S(r, "Mã NV");
            cmbBN.SelectedValue = S(r, "Mã BN");
            if (S(r, "Mã khoa") != "") cmbKhoa.SelectedValue = S(r, "Mã khoa");
            LoadPhongBS();
            if (S(r, "Mã phòng") != "") cmbPhong.SelectedValue = S(r, "Mã phòng");
            LoadGiuong();
            if (editingBed != "") cmbGiuong.SelectedValue = editingBed;
            if (S(r, "Mã BS") != "") cmbBS.SelectedValue = S(r, "Mã BS");

            if (r.Cells["Ngày vào viện"].Value is DateTime) dtpVao.Value = (DateTime)r.Cells["Ngày vào viện"].Value;
            if (r.Cells["Ngày ra viện"].Value is DateTime) dtpRa.Value = (DateTime)r.Cells["Ngày ra viện"].Value;
            else dtpRa.Value = DateTime.Now;
            txtLyDo.Text = S(r, "Lý do");
            txtGhiChu.Text = S(r, "Ghi chú");
            lblTT.Text = editingStatus;
            loading = false;
        }

        void ResetForm()
        {
            LoadData();
            dgv.CurrentCell = null;
            editingBed = "";
            editingStatus = "";
            txtMa.Text = "";
            txtLyDo.Text = "";
            txtGhiChu.Text = "";
            dtpVao.Value = DateTime.Now;
            dtpRa.Value = DateTime.Now;
            lblTT.Text = "Mới";
            LoadPhongBS();
        }

        // ---------- sự kiện đổi lựa chọn ----------

        void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e) { if (!loading) LoadPhongBS(); }

        void cmbPhong_SelectedIndexChanged(object sender, EventArgs e) { if (!loading) LoadGiuong(); }

        void cmbLoc_SelectedIndexChanged(object sender, EventArgs e) { if (!loading) LoadData(); }

        void txtTim_TextChanged(object sender, EventArgs e) { if (!loading) LoadData(); }

        void dgv_SelectionChanged(object sender, EventArgs e) { if (!loading) SelectRow(); }

        // ---------- nghiệp vụ ----------

        void btnLamMoi_Click(object sender, EventArgs e) { ResetForm(); }

        void btnXuat_Click(object sender, EventArgs e) { XuatFile(dgv, "NhapVien"); }

        void btnTao_Click(object sender, EventArgs e)
        {
            string bn = Val(cmbBN), g = Val(cmbGiuong), bs = Val(cmbBS);
            if (bn == null) { Warn("Hãy chọn bệnh nhân."); return; }
            if (g == null) { Warn("Hãy chọn giường (phòng này có thể đã hết giường trống)."); return; }
            if (bs == null) { Warn("Hãy chọn bác sĩ phụ trách."); return; }

            try
            {
                if (Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM NHAPVIEN WHERE MaBN=@bn AND TrangThai=N'Đang điều trị'", Db.P("@bn", bn))) > 0)
                { Warn("Bệnh nhân này đang điều trị nội trú, không thể tạo thêm hồ sơ nhập viện."); return; }

                string st = Convert.ToString(Db.Scalar("SELECT TrangThai FROM GIUONG WHERE MaGiuong=@g", Db.P("@g", g)));
                if (st != "Trống") { Warn("Giường này không còn trống."); return; }

                string ma = Db.NextId("NHAPVIEN", "MaNhapVien", "NV");
                Db.ExecTx(
                    new Stmt(@"INSERT INTO NHAPVIEN(MaNhapVien, MaBN, MaBS, MaGiuong, NgayNhapVien, LyDoNhapVien, TrangThai, GhiChu)
                               VALUES(@ma, @bn, @bs, @g, @vao, @ly, N'Đang điều trị', @gc)",
                        Db.P("@ma", ma), Db.P("@bn", bn), Db.P("@bs", bs), Db.P("@g", g),
                        Db.P("@vao", dtpVao.Value), Db.P("@ly", txtLyDo.Text.Trim()), Db.P("@gc", txtGhiChu.Text.Trim())),
                    new Stmt("UPDATE GIUONG SET TrangThai = N'Đang sử dụng' WHERE MaGiuong = @g", Db.P("@g", g)));

                ResetForm();
                Msg("Đã tạo hồ sơ nhập viện " + ma + ".");
            }
            catch (Exception ex) { Err(ex); }
        }

        void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "") { Warn("Hãy chọn hồ sơ cần cập nhật trong danh sách."); return; }
            if (editingStatus != "Đang điều trị") { Warn("Chỉ cập nhật được hồ sơ đang điều trị."); return; }
            string g = Val(cmbGiuong), bs = Val(cmbBS);
            if (g == null || bs == null) { Warn("Hãy chọn đủ giường và bác sĩ phụ trách."); return; }

            try
            {
                var list = new List<Stmt>();
                list.Add(new Stmt(
                    @"UPDATE NHAPVIEN SET MaBS=@bs, MaGiuong=@g, NgayNhapVien=@vao, LyDoNhapVien=@ly, GhiChu=@gc
                      WHERE MaNhapVien=@ma",
                    Db.P("@bs", bs), Db.P("@g", g), Db.P("@vao", dtpVao.Value),
                    Db.P("@ly", txtLyDo.Text.Trim()), Db.P("@gc", txtGhiChu.Text.Trim()), Db.P("@ma", txtMa.Text)));

                if (g != editingBed)   // chuyển giường: trả giường cũ, chiếm giường mới
                {
                    if (editingBed != "")
                        list.Add(new Stmt("UPDATE GIUONG SET TrangThai = N'Trống' WHERE MaGiuong = @o", Db.P("@o", editingBed)));
                    list.Add(new Stmt("UPDATE GIUONG SET TrangThai = N'Đang sử dụng' WHERE MaGiuong = @n", Db.P("@n", g)));
                }
                Db.ExecTx(list.ToArray());
                string ma = txtMa.Text;
                ResetForm();
                Msg("Đã cập nhật hồ sơ " + ma + " (bệnh nhân không đổi được; muốn đổi hãy hủy hồ sơ và tạo mới).");
            }
            catch (Exception ex) { Err(ex); }
        }

        void btnRaVien_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "") { Warn("Hãy chọn hồ sơ cần cho ra viện."); return; }
            if (editingStatus != "Đang điều trị") { Warn("Hồ sơ này không ở trạng thái đang điều trị."); return; }
            if (dtpRa.Value < dtpVao.Value) { Warn("Ngày ra viện phải sau ngày vào viện."); return; }
            if (!Confirm("Cho bệnh nhân ra viện và trả giường " + editingBed + "?")) return;

            try
            {
                Db.ExecTx(
                    new Stmt("UPDATE NHAPVIEN SET NgayRaVien=@ra, TrangThai=N'Đã ra viện' WHERE MaNhapVien=@ma",
                        Db.P("@ra", dtpRa.Value), Db.P("@ma", txtMa.Text)),
                    new Stmt("UPDATE GIUONG SET TrangThai=N'Trống' WHERE MaGiuong=@g", Db.P("@g", editingBed)));
                ResetForm();
                Msg("Đã cho ra viện. Vào mục Viện phí để lập hóa đơn.");
            }
            catch (Exception ex) { Err(ex); }
        }

        void btnHuy_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "") { Warn("Hãy chọn hồ sơ cần hủy."); return; }
            if (editingStatus != "Đang điều trị") { Warn("Chỉ hủy được hồ sơ đang điều trị."); return; }
            if (!Confirm("Hủy hồ sơ nhập viện " + txtMa.Text + "?")) return;

            try
            {
                Db.ExecTx(
                    new Stmt("UPDATE NHAPVIEN SET TrangThai=N'Hủy' WHERE MaNhapVien=@ma", Db.P("@ma", txtMa.Text)),
                    new Stmt("UPDATE GIUONG SET TrangThai=N'Trống' WHERE MaGiuong=@g", Db.P("@g", editingBed)));
                ResetForm();
            }
            catch (Exception ex) { Err(ex); }
        }
    }
}
