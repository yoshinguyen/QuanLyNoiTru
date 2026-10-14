using System;
using System.Windows.Forms;

namespace QuanLyNoiTru
{
    /// <summary>Đăng nhập (chỉ có 1 tài khoản admin, không phân quyền). Giao diện: LoginForm.Designer.cs</summary>
    public partial class LoginForm : Form
    {
        const string AdminUser = "1";   // hệ thống chỉ có 1 tài khoản duy nhất

        public LoginForm()
        {
            InitializeComponent();
        }

        void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = Db.Query(
                    "SELECT HoTen FROM TAIKHOAN " +
                    "WHERE TenDangNhap = @u AND TenDangNhap = N'" + AdminUser + "' AND MatKhau COLLATE Latin1_General_CS_AS = @p AND TrangThai = 1",
                    Db.P("@u", txtUser.Text.Trim()), Db.P("@p", txtPass.Text));

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu.", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Session.FullName = dt.Rows[0]["HoTen"].ToString();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to db server.\nPlease check the connection string in Db.cs.\n\n" + ex.Message,
                    "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
