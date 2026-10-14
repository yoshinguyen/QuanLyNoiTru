using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace QuanLyNoiTru
{
    /// <summary>
    /// Form cơ sở cho các màn hình con (được nhúng vào Panel của MainForm).
    /// Giao diện của từng form nằm trong file *.Designer.cs nên có thể mở bằng Visual Studio Designer để sửa.
    /// Lớp này chỉ chứa các hàm tiện ích: đọc dữ liệu từ lưới/combobox, hiện thông báo, nhập/xuất file.
    /// </summary>
    public class BaseForm : Form
    {
        public BaseForm()
        {
            // Khi mở trong Designer thì giữ nguyên là form bình thường để còn kéo thả được
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;
        }

        // ---------- tiện ích dữ liệu ----------

        protected static string S(DataGridViewRow r, string col)
        {
            if (r == null || !r.DataGridView.Columns.Contains(col)) return "";
            object v = r.Cells[col].Value;
            return (v == null || v == DBNull.Value) ? "" : v.ToString();
        }

        protected static void FmtCol(DataGridView g, string col, string fmt)
        {
            if (g.Columns.Contains(col)) g.Columns[col].DefaultCellStyle.Format = fmt;
        }

        protected static void Bind(ComboBox c, DataTable dt, string display, string value)
        {
            c.DataSource = null;
            c.DisplayMember = display;
            c.ValueMember = value;
            c.DataSource = dt;
        }

        protected static string Val(ComboBox c)
        {
            return c.SelectedValue == null ? null : c.SelectedValue.ToString();
        }

        // thogn bao

        protected void Msg(string m)
        {
            MessageBox.Show(m, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected void Warn(string m)
        {
            MessageBox.Show(m, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        protected bool Confirm(string m)
        {
            return MessageBox.Show(m, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        protected void Err(Exception ex, string fkMessage = null)
        {
            var se = ex as SqlException;
            if (se != null && se.Number == 547)
                Warn(fkMessage ?? "Dữ liệu đang được dùng ở nơi khác hoặc vi phạm ràng buộc, không thể thực hiện.");
            else if (se != null && (se.Number == 2627 || se.Number == 2601))
                Warn("Dữ liệu bị trùng.");
            else
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // xuatnhap file

        //xuat file excel
        protected void XuatFile(DataGridView g, string tenFile)
        {
            var dt = g.DataSource as DataTable;
            if (dt == null || dt.Rows.Count == 0) { Warn("Không có dữ liệu để xuất."); return; }

            using (var dlg = new SaveFileDialog())
            {
                dlg.Filter = "Excel Files (*.xlsx)|*.xlsx";
                dlg.Title = "Xuất file Excel";
                dlg.FileName = "filexuat.xlsx";
                if (dlg.ShowDialog() != DialogResult.OK) return;
                try
                {
                    if (dlg.FileName.EndsWith(".csv", StringComparison.OrdinalIgnoreCase))
                        Export.WriteCsv(dlg.FileName, dt);
                    else
                        Export.WriteXlsx(dlg.FileName, dt);
                    Msg("Đã xuất file thành công!");
                }
                catch (Exception ex) { Err(ex); }
            }
        }

        /// <summary>Hỏi người dùng chọn file Excel/CSV rồi đọc thành DataTable (dòng đầu là tiêu đề cột). Trả về null nếu hủy.</summary>
        protected DataTable DocFile()
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "Excel / CSV (*.xlsx;*.csv)|*.xlsx;*.csv";
                if (dlg.ShowDialog() != DialogResult.OK) return null;
                try { return Export.ReadTable(dlg.FileName); }
                catch (Exception ex)
                {
                    Warn("Không đọc được file:\n" + ex.Message);
                    return null;
                }
            }
        }
    }
}
