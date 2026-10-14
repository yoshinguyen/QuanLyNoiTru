using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNoiTru
{
    /// <summary>Quản lý bác sĩ + nhập từ file, xuất ra file. Giao diện: BacSiForm.Designer.cs</summary>
    public partial class BacSiForm : BaseForm
    {
        bool ready;

        public BacSiForm()
        {
            InitializeComponent();
            cmbGt.SelectedIndex = 0;
            Bind(cmbKhoa, Db.Query("SELECT MaKhoa, TenKhoa FROM KHOA ORDER BY MaKhoa"), "TenKhoa", "MaKhoa");
            Bind(cbxKhoatim,
            Db.Query("SELECT MaKhoa, TenKhoa FROM KHOA ORDER BY MaKhoa"),
            "TenKhoa",
            "MaKhoa");
            cbxKhoatim.SelectedIndex = 0;
            LoadData();
            dgv.CurrentCell = null;
            ready = true;
        }

        // ---------- hiển thị ----------

        void LoadData()
        {
            dgv.DataSource = Db.Query(
                @"SELECT b.MaBS AS [Mã BS], b.HoTen AS [Họ tên], b.NgaySinh AS [Ngày sinh], b.GioiTinh AS [Giới tính],
                         b.ChuyenKhoa AS [Chuyên khoa], b.SoDienThoai AS [SĐT], b.Email AS [Email],
                         b.MaKhoa AS [Mã khoa], k.TenKhoa AS [Khoa], b.TrangThai AS [Đang làm việc]
                  FROM BACSI b LEFT JOIN KHOA k ON k.MaKhoa = b.MaKhoa
                  ORDER BY b.MaBS");
            FmtCol(dgv, "Ngày sinh", "dd/MM/yyyy");
        }

        void FillInputs()
        {
            var r = dgv.CurrentRow;
            if (r == null) return;
            txtMa.Text = S(r, "Mã BS");
            txtTen.Text = S(r, "Họ tên");
            if (r.Cells["Ngày sinh"].Value is DateTime) dtpNs.Value = (DateTime)r.Cells["Ngày sinh"].Value;
            cmbGt.Text = S(r, "Giới tính");
            txtChuyenKhoa.Text = S(r, "Chuyên khoa");
            txtSdt.Text = S(r, "SĐT");
            txtEmail.Text = S(r, "Email");
            if (S(r, "Mã khoa") != "") cmbKhoa.SelectedValue = S(r, "Mã khoa");
            chkLam.Checked = r.Cells["Đang làm việc"].Value is bool && (bool)r.Cells["Đang làm việc"].Value;
        }

        void ClearInputs()
        {
            txtMa.Text = txtTen.Text = txtChuyenKhoa.Text = txtSdt.Text = txtEmail.Text = "";
            dtpNs.Value = DateTime.Today;
            cmbGt.SelectedIndex = 0;
            chkLam.Checked = true;
        }

        void Reset()
        {
            txtMatim.Clear();
            txtTentim.Clear();
            txtSdttim.Clear();
            cbxKhoatim.SelectedIndex = 0;
            LoadData();
            dgv.CurrentCell = null;
            ClearInputs();
        }

        bool Valid()
        {
            if (txtTen.Text.Trim() == "") { Warn("Vui lòng nhập họ tên bác sĩ."); txtTen.Focus(); return false; }
            if (Val(cmbKhoa) == null) { Warn("Vui lòng chọn khoa."); return false; }
            return true;
        }

        /// <summary>Thêm 1 bác sĩ vào CSDL, trả về mã mới. Dùng chung cho nút Thêm và Nhập từ file.</summary>
        static string Insert(string ten, DateTime ns, string gt, string ck, string sdt, string email, string khoa, bool lam)
        {
            string ma = Db.NextId("BACSI", "MaBS", "BS");
            Db.Exec(@"INSERT INTO BACSI(MaBS, HoTen, NgaySinh, GioiTinh, ChuyenKhoa, SoDienThoai, Email, MaKhoa, TrangThai)
                      VALUES(@ma, @ten, @ns, @gt, @ck, @sdt, @email, @khoa, @tt)",
                Db.P("@ma", ma), Db.P("@ten", ten), Db.P("@ns", ns.Date), Db.P("@gt", gt), Db.P("@ck", ck),
                Db.P("@sdt", sdt), Db.P("@email", email), Db.P("@khoa", khoa), Db.P("@tt", lam));
            return ma;
        }

        // ---------- sự kiện ----------

        void dgv_SelectionChanged(object sender, EventArgs e) { if (ready) FillInputs(); }

        void btnLamMoi_Click(object sender, EventArgs e) { Reset(); }

        void btnThem_Click(object sender, EventArgs e)
        {
            if (!Valid()) return;
            try
            {
                string ma = Insert(txtTen.Text.Trim(), dtpNs.Value, cmbGt.Text, txtChuyenKhoa.Text.Trim(),
                    txtSdt.Text.Trim(), txtEmail.Text.Trim(), Val(cmbKhoa), chkLam.Checked);
                Reset();
                Msg("Đã thêm bác sĩ " + ma + ".");
            }
            catch (Exception ex) { Err(ex); }
        }

        void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "") { Warn("Hãy chọn bác sĩ cần sửa trong danh sách."); return; }
            if (!Valid()) return;
            try
            {
                Db.Exec(@"UPDATE BACSI SET HoTen=@ten, NgaySinh=@ns, GioiTinh=@gt, ChuyenKhoa=@ck, SoDienThoai=@sdt,
                                 Email=@email, MaKhoa=@khoa, TrangThai=@tt
                          WHERE MaBS=@ma",
                    Db.P("@ma", txtMa.Text), Db.P("@ten", txtTen.Text.Trim()), Db.P("@ns", dtpNs.Value.Date),
                    Db.P("@gt", cmbGt.Text), Db.P("@ck", txtChuyenKhoa.Text.Trim()), Db.P("@sdt", txtSdt.Text.Trim()),
                    Db.P("@email", txtEmail.Text.Trim()), Db.P("@khoa", Val(cmbKhoa)), Db.P("@tt", chkLam.Checked));
                LoadData();
                Msg("Đã cập nhật bác sĩ " + txtMa.Text + ".");
            }
            catch (Exception ex) { Err(ex); }
        }

        void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "") { Warn("Hãy chọn bác sĩ cần xóa."); return; }
            if (!Confirm("Xóa bác sĩ " + txtMa.Text + " - " + txtTen.Text + "?")) return;
            try
            {
                Db.Exec("DELETE FROM BACSI WHERE MaBS=@ma", Db.P("@ma", txtMa.Text));
                Reset();
            }
            catch (Exception ex)
            {
                Err(ex, "Bác sĩ này đã phụ trách hồ sơ nhập viện nên không thể xóa.\nHãy bỏ chọn \"Đang làm việc\" rồi bấm Sửa.");
            }
        }

        // ---------- nhập / xuất file ----------

        void btnXuat_Click(object sender, EventArgs e) { XuatFile(dgv, "BacSi"); }



        private void btnTim_Click(object sender, EventArgs e)
        {
            string query = @"SELECT b.MaBS AS [Mã BS], b.HoTen AS [Họ tên], b.NgaySinh AS [Ngày sinh], b.GioiTinh AS [Giới tính],
                         b.ChuyenKhoa AS [Chuyên khoa], b.SoDienThoai AS [SĐT], b.Email AS [Email],
                         b.MaKhoa AS [Mã khoa], k.TenKhoa AS [Khoa], b.TrangThai AS [Đang làm việc]
                  FROM BACSI b LEFT JOIN KHOA k ON k.MaKhoa = b.MaKhoa
            WHERE 1=1";

            List<SqlParameter> paramList = new List<SqlParameter>();

            if (!string.IsNullOrWhiteSpace(txtMatim.Text))
            {
                query += " AND MaBS LIKE @MaBS";
                paramList.Add(Db.P("@MaBS",
                    "%" + txtMatim.Text.Trim() + "%"));
            }

            if (!string.IsNullOrWhiteSpace(txtTentim.Text))
            {
                query += " AND HoTen LIKE @HoTen";
                paramList.Add(Db.P("@HoTen",
                    "%" + txtTentim.Text.Trim() + "%"));
            }

            if (!string.IsNullOrWhiteSpace(txtSdttim.Text))
            {
                query += " AND SoDienThoai LIKE @SDT";
                paramList.Add(Db.P("@SDT",
                    "%" + txtSdttim.Text.Trim() + "%"));
            }

            if (cbxKhoatim.SelectedIndex >= 0)
            {
                query += " AND TenKhoa = @TenKhoa";
                paramList.Add(Db.P("@TenKhoa",
                    cbxKhoatim.Text));
            }

            query += " ORDER BY MaBS";

            try
            {
                dgv.DataSource = Db.Query(query, paramList.ToArray());
                FmtCol(dgv, "Ngày sinh", "dd/MM/yyyy");
                dgv.CurrentCell = null;
            }
            catch (Exception ex)
            {
                Err(ex);
            }
        }
    }
}
