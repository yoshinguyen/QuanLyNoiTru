namespace QuanLyNoiTru
{
    partial class MainForm
    {
        /// <summary>Required designer variable.</summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>Clean up any resources being used.</summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnBenhNhan = new System.Windows.Forms.Button();
            this.btnBacSi = new System.Windows.Forms.Button();
            this.btnNhapVien = new System.Windows.Forms.Button();
            this.btnBenhAn = new System.Windows.Forms.Button();
            this.btnDonThuoc = new System.Windows.Forms.Button();
            this.btnVienPhi = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(200, 48);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1100, 712);
            this.pnlContent.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(200, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 48);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(1100, 48);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.pnlMenu.Controls.Add(this.lblLogo);
            this.pnlMenu.Controls.Add(this.btnBenhNhan);
            this.pnlMenu.Controls.Add(this.btnBacSi);
            this.pnlMenu.Controls.Add(this.btnNhapVien);
            this.pnlMenu.Controls.Add(this.btnBenhAn);
            this.pnlMenu.Controls.Add(this.btnDonThuoc);
            this.pnlMenu.Controls.Add(this.btnVienPhi);
            this.pnlMenu.Controls.Add(this.btnBaoCao);
            this.pnlMenu.Controls.Add(this.btnDangXuat);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 760);
            this.pnlMenu.TabIndex = 4;
            // 
            // lblLogo
            // 
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(200, 60);
            this.lblLogo.TabIndex = 5;
            this.lblLogo.Text = "NỘI TRÚ";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBenhNhan
            // 
            this.btnBenhNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.btnBenhNhan.FlatAppearance.BorderSize = 0;
            this.btnBenhNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBenhNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBenhNhan.Location = new System.Drawing.Point(0, 70);
            this.btnBenhNhan.Name = "btnBenhNhan";
            this.btnBenhNhan.Size = new System.Drawing.Size(200, 46);
            this.btnBenhNhan.TabIndex = 6;
            this.btnBenhNhan.Tag = "BenhNhan";
            this.btnBenhNhan.Text = "   Bệnh nhân";
            this.btnBenhNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBenhNhan.UseVisualStyleBackColor = false;
            this.btnBenhNhan.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnBacSi
            // 
            this.btnBacSi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.btnBacSi.FlatAppearance.BorderSize = 0;
            this.btnBacSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBacSi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBacSi.Location = new System.Drawing.Point(0, 118);
            this.btnBacSi.Name = "btnBacSi";
            this.btnBacSi.Size = new System.Drawing.Size(200, 46);
            this.btnBacSi.TabIndex = 7;
            this.btnBacSi.Tag = "BacSi";
            this.btnBacSi.Text = "   Bác sĩ";
            this.btnBacSi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBacSi.UseVisualStyleBackColor = false;
            this.btnBacSi.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnNhapVien
            // 
            this.btnNhapVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.btnNhapVien.FlatAppearance.BorderSize = 0;
            this.btnNhapVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNhapVien.Location = new System.Drawing.Point(0, 166);
            this.btnNhapVien.Name = "btnNhapVien";
            this.btnNhapVien.Size = new System.Drawing.Size(200, 46);
            this.btnNhapVien.TabIndex = 8;
            this.btnNhapVien.Tag = "NhapVien";
            this.btnNhapVien.Text = "   Nhập viện";
            this.btnNhapVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapVien.UseVisualStyleBackColor = false;
            this.btnNhapVien.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnBenhAn
            // 
            this.btnBenhAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.btnBenhAn.FlatAppearance.BorderSize = 0;
            this.btnBenhAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBenhAn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBenhAn.Location = new System.Drawing.Point(0, 214);
            this.btnBenhAn.Name = "btnBenhAn";
            this.btnBenhAn.Size = new System.Drawing.Size(200, 46);
            this.btnBenhAn.TabIndex = 9;
            this.btnBenhAn.Tag = "BenhAn";
            this.btnBenhAn.Text = "   Bệnh án";
            this.btnBenhAn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBenhAn.UseVisualStyleBackColor = false;
            this.btnBenhAn.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnDonThuoc
            // 
            this.btnDonThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.btnDonThuoc.FlatAppearance.BorderSize = 0;
            this.btnDonThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonThuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDonThuoc.Location = new System.Drawing.Point(0, 262);
            this.btnDonThuoc.Name = "btnDonThuoc";
            this.btnDonThuoc.Size = new System.Drawing.Size(200, 46);
            this.btnDonThuoc.TabIndex = 10;
            this.btnDonThuoc.Tag = "DonThuoc";
            this.btnDonThuoc.Text = "   Đơn thuốc";
            this.btnDonThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonThuoc.UseVisualStyleBackColor = false;
            this.btnDonThuoc.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnVienPhi
            // 
            this.btnVienPhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.btnVienPhi.FlatAppearance.BorderSize = 0;
            this.btnVienPhi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVienPhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVienPhi.Location = new System.Drawing.Point(0, 310);
            this.btnVienPhi.Name = "btnVienPhi";
            this.btnVienPhi.Size = new System.Drawing.Size(200, 46);
            this.btnVienPhi.TabIndex = 11;
            this.btnVienPhi.Tag = "VienPhi";
            this.btnVienPhi.Text = "   Viện phí";
            this.btnVienPhi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVienPhi.UseVisualStyleBackColor = false;
            this.btnVienPhi.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBaoCao.Location = new System.Drawing.Point(0, 358);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(200, 46);
            this.btnBaoCao.TabIndex = 12;
            this.btnBaoCao.Tag = "BaoCao";
            this.btnBaoCao.Text = "   Báo cáo - Thống kê";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDangXuat.Location = new System.Drawing.Point(0, 714);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(200, 46);
            this.btnDangXuat.TabIndex = 13;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1300, 760);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1150, 650);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý bệnh nhân nội trú";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.pnlHeader.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnBenhNhan;
        private System.Windows.Forms.Button btnBacSi;
        private System.Windows.Forms.Button btnNhapVien;
        private System.Windows.Forms.Button btnBenhAn;
        private System.Windows.Forms.Button btnDonThuoc;
        private System.Windows.Forms.Button btnVienPhi;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnDangXuat;
    }
}
