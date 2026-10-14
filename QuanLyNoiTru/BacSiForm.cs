using System;
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
                  WHERE b.MaBS LIKE @k OR b.HoTen LIKE @k OR b.ChuyenKhoa LIKE @k
                  ORDER BY b.MaBS",
                Db.P("@k", "%" + txtTim.Text.Trim() + "%"));
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
            txtTim.Text = "";
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

        void txtTim_TextChanged(object sender, EventArgs e) { if (ready) LoadData(); }

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

        /// <summary>Nhập danh sách bác sĩ từ file Excel/CSV (cột: Họ tên, Ngày sinh, Giới tính, Chuyên khoa, SĐT, Email, Khoa). Mã BS tự sinh.</summary>
        void btnNhap_Click(object sender, EventArgs e)
        {
            var dt = DocFile();
            if (dt == null) return;
            if (!dt.Columns.Contains("Họ tên")) { Warn("File phải có cột \"Họ tên\" ở dòng đầu tiên.\nCách dễ nhất: bấm \"Xuất ra file\" để lấy file mẫu."); return; }

            var khoaTable = Db.Query("SELECT MaKhoa, TenKhoa FROM KHOA");
            int ok = 0, loi = 0, dong = 1;
            var chiTiet = new StringBuilder();

            foreach (DataRow r in dt.Rows)
            {
                dong++;
                try
                {
                    string ten = Export.Get(r, "Họ tên");
                    if (ten == "") throw new Exception("thiếu họ tên");

                    DateTime ns;
                    if (!Export.TryDate(Export.Get(r, "Ngày sinh"), out ns)) throw new Exception("ngày sinh không đúng (dd/MM/yyyy)");

                    // khoa: ưu tiên "Mã khoa", nếu không có thì tìm theo tên khoa
                    string khoa = null;
                    string maK = Export.Get(r, "Mã khoa"), tenK = Export.Get(r, "Khoa");
                    foreach (DataRow k in khoaTable.Rows)
                    {
                        if ((maK != "" && string.Equals(k["MaKhoa"].ToString(), maK, StringComparison.OrdinalIgnoreCase)) ||
                            (tenK != "" && string.Equals(k["TenKhoa"].ToString(), tenK, StringComparison.OrdinalIgnoreCase)))
                        { khoa = k["MaKhoa"].ToString(); break; }
                    }
                    if (khoa == null) throw new Exception("không tìm thấy khoa \"" + (tenK != "" ? tenK : maK) + "\"");

                    string gt = Export.Get(r, "Giới tính").Normalize(NormalizationForm.FormC);
                    gt = gt.Equals("Nữ", StringComparison.OrdinalIgnoreCase) ? "Nữ" : "Nam";

                    string lamStr = Export.Get(r, "Đang làm việc").ToLowerInvariant();
                    bool lam = !(lamStr == "không" || lamStr == "khong" || lamStr == "0" || lamStr == "false");

                    Insert(ten, ns, gt, Export.Get(r, "Chuyên khoa"), Export.Get(r, "SĐT"), Export.Get(r, "Email"), khoa, lam);
                    ok++;
                }
                catch (Exception ex)
                {
                    loi++;
                    if (loi <= 8) chiTiet.AppendLine("Dòng " + dong + ": " + (ex is SqlException ? "dữ liệu bị trùng hoặc sai ràng buộc" : ex.Message));
                }
            }

            Reset();
            string kq = "Đã nhập " + ok + " bác sĩ.";
            if (loi > 0) kq += "\nBỏ qua " + loi + " dòng lỗi:\n" + chiTiet;
            Msg(kq);
        }
    }
}
