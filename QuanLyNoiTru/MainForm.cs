using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNoiTru
{
    /// <summary>
    /// Form chính: menu bên trái, form con được nhúng vào Panel bên phải (TopLevel = false).
    /// Không phân quyền: admin thấy tất cả chức năng. Giao diện: MainForm.Designer.cs
    /// </summary>
    public partial class MainForm : Form
    {
        public bool LoggedOut;

        static readonly Color MenuColor = Color.FromArgb(30, 58, 95);
        static readonly Color MenuActive = Color.FromArgb(52, 101, 164);

        public MainForm()
        {
            InitializeComponent();
        }

        void MainForm_Shown(object sender, EventArgs e)
        {
            Open(btnBenhNhan);
        }

        void btnMenu_Click(object sender, EventArgs e)
        {
            Open((Button)sender);
        }

        /// <summary>Tạo form con theo Tag của nút menu (đặt trong Designer).</summary>
        static Form Create(string tag)
        {
            switch (tag)
            {
                case "BenhNhan": return new BenhNhanForm();
                case "BacSi": return new BacSiForm();
                case "NhapVien": return new NhapVienForm();
                case "BenhAn": return new BenhAnForm();
                case "DonThuoc": return new DonThuocForm();
                case "VienPhi": return new VienPhiForm();
                case "BaoCao": return new BaoCaoForm();
                default: throw new ArgumentException("Chức năng không tồn tại: " + tag);
            }
        }

        void Open(Button b)
        {
            try
            {
                var f = Create((string)b.Tag);   // tạo trước: nếu lỗi kết nối thì giữ nguyên màn hình cũ

                foreach (Control c in pnlMenu.Controls)
                {
                    var mb = c as Button;
                    if (mb != null && mb.Tag != null) mb.BackColor = MenuColor;
                }
                b.BackColor = MenuActive;

                var old = new List<Control>();
                foreach (Control c in pnlContent.Controls) old.Add(c);
                pnlContent.Controls.Clear();
                foreach (var c in old) c.Dispose();

                lblTitle.Text = b.Text.Trim();
                pnlContent.Controls.Add(f);
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không mở được chức năng này:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Đăng xuất khỏi hệ thống?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoggedOut = true;
                Close();
            }
        }
    }
}
