using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNoiTru
{
    /// <summary>Quản lý bệnh nhân: thêm / sửa / xóa / tìm kiếm + nhập từ file, xuất ra file. Giao diện: BenhNhanForm.Designer.cs</summary>
    public partial class BenhNhanForm : BaseForm
    {
        bool ready;   // false trong lúc dựng form để các sự kiện chưa chạy

        public BenhNhanForm()
        {
            InitializeComponent();
            cmbGt.SelectedIndex = 0;
            LoadData();
            dgv.CurrentCell = null;
            ready = true;
        }

        // ---------- hiển thị ----------

        void LoadData()
        {
            dgv.DataSource = Db.Query(
                @"SELECT MaBN AS [Mã BN], HoTen AS [Họ tên], NgaySinh AS [Ngày sinh], GioiTinh AS [Giới tính],
                         CCCD AS [CCCD], SoDienThoai AS [SĐT], DiaChi AS [Địa chỉ], NgheNghiep AS [Nghề nghiệp],
                         NguoiThan AS [Người thân], SDTNguoiThan AS [SĐT người thân], TinhTrang AS [Tình trạng bệnh]
                  FROM BENHNHAN
                  ORDER BY MaBN");
            FmtCol(dgv, "Ngày sinh", "dd/MM/yyyy");
        }

        void FillInputs()
        {
            var r = dgv.CurrentRow;
            if (r == null) return;
            txtMa.Text = S(r, "Mã BN");
            txtTen.Text = S(r, "Họ tên");
            if (r.Cells["Ngày sinh"].Value is DateTime) dtpNs.Value = (DateTime)r.Cells["Ngày sinh"].Value;
            cmbGt.Text = S(r, "Giới tính");
            txtCccd.Text = S(r, "CCCD");
            txtSdt.Text = S(r, "SĐT");
            txtDiaChi.Text = S(r, "Địa chỉ");
            txtNghe.Text = S(r, "Nghề nghiệp");
            txtNguoiThan.Text = S(r, "Người thân");
            txtSdtNT.Text = S(r, "SĐT người thân");
            txtTinhTrang.Text = S(r, "Tình trạng bệnh");
        }

        void ClearInputs()
        {
            txtMa.Text = txtTen.Text = txtCccd.Text = txtSdt.Text = txtDiaChi.Text = "";
            txtNghe.Text = txtNguoiThan.Text = txtSdtNT.Text = txtTinhTrang.Text = "";
            dtpNs.Value = DateTime.Today;
            cmbGt.SelectedIndex = 0;
        }

        void Reset()
        {
            txtMatim.Clear();
            txtTentim.Clear();
            txtCccdtim.Clear();
            txtSdttim.Clear();
//            cboTimGioiTinh.SelectedIndex = 0;

            LoadData();
            dgv.CurrentCell = null;
            ClearInputs();
        }

        static bool CccdHopLe(string c)
        {
            return c == "" || (c.Length == 12 && c.All(char.IsDigit));
        }

        bool Valid()
        {
            if (txtTen.Text.Trim() == "") { Warn("Vui lòng nhập họ tên."); txtTen.Focus(); return false; }
            if (dtpNs.Value.Date > DateTime.Today) { Warn("Ngày sinh không hợp lệ."); return false; }
            if (!CccdHopLe(txtCccd.Text.Trim())) { Warn("CCCD phải gồm đúng 12 chữ số."); txtCccd.Focus(); return false; }
            return true;
        }

        /// <summary>Thêm 1 bệnh nhân vào CSDL, trả về mã mới. Dùng chung cho nút Thêm và Nhập từ file.</summary>
        static string Insert(string ten, DateTime ns, string gt, string cccd, string sdt,
                             string dc, string nghe, string nt, string sdtnt, string tt)
        {
            string ma = Db.NextId("BENHNHAN", "MaBN", "BN");
            Db.Exec(@"INSERT INTO BENHNHAN(MaBN, HoTen, NgaySinh, GioiTinh, CCCD, SoDienThoai, DiaChi, NgheNghiep, NguoiThan, SDTNguoiThan, TinhTrang)
                      VALUES(@ma, @ten, @ns, @gt, @cccd, @sdt, @dc, @nghe, @nt, @sdtnt, @tt)",
                Db.P("@ma", ma), Db.P("@ten", ten), Db.P("@ns", ns.Date), Db.P("@gt", gt), Db.P("@cccd", cccd),
                Db.P("@sdt", sdt), Db.P("@dc", dc), Db.P("@nghe", nghe), Db.P("@nt", nt),
                Db.P("@sdtnt", sdtnt), Db.P("@tt", tt));
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
                string ma = Insert(txtTen.Text.Trim(), dtpNs.Value, cmbGt.Text, txtCccd.Text.Trim(), txtSdt.Text.Trim(),
                    txtDiaChi.Text.Trim(), txtNghe.Text.Trim(), txtNguoiThan.Text.Trim(), txtSdtNT.Text.Trim(),
                    txtTinhTrang.Text.Trim());
                Reset();
                Msg("Đã thêm bệnh nhân " + ma + ".");
            }
            catch (Exception ex) { Err(ex); }
        }

        void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "") { Warn("Hãy chọn bệnh nhân cần sửa trong danh sách."); return; }
            if (!Valid()) return;
            try
            {
                string ma = txtMa.Text;
                Db.Exec(@"UPDATE BENHNHAN SET HoTen=@ten, NgaySinh=@ns, GioiTinh=@gt, CCCD=@cccd, SoDienThoai=@sdt,
                                 DiaChi=@dc, NgheNghiep=@nghe, NguoiThan=@nt, SDTNguoiThan=@sdtnt, TinhTrang=@tt
                          WHERE MaBN=@ma",
                    Db.P("@ma", ma), Db.P("@ten", txtTen.Text.Trim()), Db.P("@ns", dtpNs.Value.Date),
                    Db.P("@gt", cmbGt.Text), Db.P("@cccd", txtCccd.Text.Trim()), Db.P("@sdt", txtSdt.Text.Trim()),
                    Db.P("@dc", txtDiaChi.Text.Trim()), Db.P("@nghe", txtNghe.Text.Trim()),
                    Db.P("@nt", txtNguoiThan.Text.Trim()), Db.P("@sdtnt", txtSdtNT.Text.Trim()),
                    Db.P("@tt", txtTinhTrang.Text.Trim()));
                LoadData();
                Msg("Đã cập nhật bệnh nhân " + ma + ".");
            }
            catch (Exception ex) { Err(ex); }
        }

        void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "") { Warn("Hãy chọn bệnh nhân cần xóa."); return; }
            if (!Confirm("Xóa bệnh nhân " + txtMa.Text + " - " + txtTen.Text + "?")) return;
            try
            {
                Db.Exec("DELETE FROM BENHNHAN WHERE MaBN=@ma", Db.P("@ma", txtMa.Text));
                Reset();
            }
            catch (Exception ex) { Err(ex, "Bệnh nhân này đã có hồ sơ nhập viện nên không thể xóa."); }
        }

        // ---------- nhập / xuất file ----------

        void btnXuat_Click(object sender, EventArgs e) { XuatFile(dgv, "BenhNhan"); }
       
        //tim
        private void btnTim_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT MaBN AS [Mã BN],
               HoTen AS [Họ tên],
               NgaySinh AS [Ngày sinh],
               GioiTinh AS [Giới tính],
               CCCD AS [CCCD],
               SoDienThoai AS [SĐT],
               DiaChi AS [Địa chỉ],
               NgheNghiep AS [Nghề nghiệp],
               NguoiThan AS [Người thân],
               SDTNguoiThan AS [SĐT người thân],
               TinhTrang AS [Tình trạng bệnh]
        FROM BENHNHAN
        WHERE 1=1";

            List<SqlParameter> paramList = new List<SqlParameter>();

            if (!string.IsNullOrWhiteSpace(txtMatim.Text))
            {
                query += " AND MaBN LIKE @MaBN";
                paramList.Add(Db.P("@MaBN",
                    "%" + txtMatim.Text.Trim() + "%"));
            }

            if (!string.IsNullOrWhiteSpace(txtTentim.Text))
            {
                query += " AND HoTen LIKE @HoTen";
                paramList.Add(Db.P("@HoTen",
                    "%" + txtTentim.Text.Trim() + "%"));
            }

            if (!string.IsNullOrWhiteSpace(txtCccdtim.Text))
            {
                query += " AND CCCD LIKE @CCCD";
                paramList.Add(Db.P("@CCCD",
                    "%" + txtCccdtim.Text.Trim() + "%"));
            }

            if (!string.IsNullOrWhiteSpace(txtSdttim.Text))
            {
                query += " AND SoDienThoai LIKE @SDT";
                paramList.Add(Db.P("@SDT",
                    "%" + txtSdttim.Text.Trim() + "%"));
            }

            /*if (cboTimGioiTinh.SelectedIndex > 0)
            {
                query += " AND GioiTinh = @GioiTinh";
                paramList.Add(Db.P("@GioiTinh",
                    cboTimGioiTinh.Text));
            }*/

            query += " ORDER BY MaBN";

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
