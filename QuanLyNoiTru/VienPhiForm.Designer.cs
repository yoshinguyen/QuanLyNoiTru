namespace QuanLyNoiTru
{
    partial class VienPhiForm
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
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaVP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoNgay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtThuoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nudKham = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nudDV = new System.Windows.Forms.NumericUpDown();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDV)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Name = "dgv";
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(242, 247, 252);
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.MultiSelect = false;
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.TabIndex = 0;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.cmbNV);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.txtMaVP);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.txtSoNgay);
            this.pnlTop.Controls.Add(this.label4);
            this.pnlTop.Controls.Add(this.txtDonGia);
            this.pnlTop.Controls.Add(this.label5);
            this.pnlTop.Controls.Add(this.txtTrangThai);
            this.pnlTop.Controls.Add(this.label6);
            this.pnlTop.Controls.Add(this.txtPhong);
            this.pnlTop.Controls.Add(this.label7);
            this.pnlTop.Controls.Add(this.txtThuoc);
            this.pnlTop.Controls.Add(this.label8);
            this.pnlTop.Controls.Add(this.txtTong);
            this.pnlTop.Controls.Add(this.label9);
            this.pnlTop.Controls.Add(this.nudKham);
            this.pnlTop.Controls.Add(this.label10);
            this.pnlTop.Controls.Add(this.nudDV);
            this.pnlTop.Controls.Add(this.btnTinh);
            this.pnlTop.Controls.Add(this.btnLuu);
            this.pnlTop.Controls.Add(this.btnThanhToan);
            this.pnlTop.Controls.Add(this.btnInHoaDon);
            this.pnlTop.Controls.Add(this.btnLamMoi);
            this.pnlTop.Controls.Add(this.btnXuat);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1100, 215);
            this.pnlTop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.AutoSize = false;
            this.label1.Text = "Hồ sơ nhập viện";
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 2;
            // 
            // cmbNV
            // 
            this.cmbNV.Location = new System.Drawing.Point(135, 10);
            this.cmbNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNV.FormattingEnabled = true;
            this.cmbNV.Name = "cmbNV";
            this.cmbNV.Size = new System.Drawing.Size(470, 28);
            this.cmbNV.TabIndex = 3;
            this.cmbNV.SelectedIndexChanged += new System.EventHandler(this.cmbNV_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(650, 16);
            this.label2.AutoSize = false;
            this.label2.Text = "Mã hóa đơn";
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 4;
            // 
            // txtMaVP
            // 
            this.txtMaVP.Location = new System.Drawing.Point(775, 10);
            this.txtMaVP.ReadOnly = true;
            this.txtMaVP.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtMaVP.Name = "txtMaVP";
            this.txtMaVP.Size = new System.Drawing.Size(230, 27);
            this.txtMaVP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 51);
            this.label3.AutoSize = false;
            this.label3.Text = "Số ngày nằm";
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 6;
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.Location = new System.Drawing.Point(135, 45);
            this.txtSoNgay.ReadOnly = true;
            this.txtSoNgay.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.Size = new System.Drawing.Size(170, 27);
            this.txtSoNgay.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(330, 51);
            this.label4.AutoSize = false;
            this.label4.Text = "Đơn giá phòng";
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 8;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(455, 45);
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(170, 27);
            this.txtDonGia.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(650, 51);
            this.label5.AutoSize = false;
            this.label5.Text = "Trạng thái";
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 10;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(775, 45);
            this.txtTrangThai.ReadOnly = true;
            this.txtTrangThai.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(230, 27);
            this.txtTrangThai.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 86);
            this.label6.AutoSize = false;
            this.label6.Text = "Tiền phòng";
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 24);
            this.label6.TabIndex = 12;
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(135, 80);
            this.txtPhong.ReadOnly = true;
            this.txtPhong.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(170, 27);
            this.txtPhong.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(330, 86);
            this.label7.AutoSize = false;
            this.label7.Text = "Tiền thuốc";
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 14;
            // 
            // txtThuoc
            // 
            this.txtThuoc.Location = new System.Drawing.Point(455, 80);
            this.txtThuoc.ReadOnly = true;
            this.txtThuoc.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtThuoc.Name = "txtThuoc";
            this.txtThuoc.Size = new System.Drawing.Size(170, 27);
            this.txtThuoc.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(650, 86);
            this.label8.AutoSize = false;
            this.label8.Text = "TỔNG TIỀN";
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 24);
            this.label8.TabIndex = 16;
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(775, 80);
            this.txtTong.ReadOnly = true;
            this.txtTong.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.txtTong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTong.ForeColor = System.Drawing.Color.Firebrick;
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(230, 27);
            this.txtTong.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(10, 121);
            this.label9.AutoSize = false;
            this.label9.Text = "Tiền khám";
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 24);
            this.label9.TabIndex = 18;
            // 
            // nudKham
            // 
            this.nudKham.Location = new System.Drawing.Point(135, 115);
            this.nudKham.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.nudKham.Maximum = new decimal(new int[] {2000000000, 0, 0, 0});
            this.nudKham.ThousandsSeparator = true;
            this.nudKham.Value = new decimal(new int[] {0, 0, 0, 0});
            this.nudKham.Increment = new decimal(new int[] {10000, 0, 0, 0});
            this.nudKham.Name = "nudKham";
            this.nudKham.Size = new System.Drawing.Size(170, 27);
            this.nudKham.TabIndex = 19;
            this.nudKham.ValueChanged += new System.EventHandler(this.nudTien_ValueChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(330, 121);
            this.label10.AutoSize = false;
            this.label10.Text = "Tiền dịch vụ";
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 24);
            this.label10.TabIndex = 20;
            // 
            // nudDV
            // 
            this.nudDV.Location = new System.Drawing.Point(455, 115);
            this.nudDV.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.nudDV.Maximum = new decimal(new int[] {2000000000, 0, 0, 0});
            this.nudDV.ThousandsSeparator = true;
            this.nudDV.Value = new decimal(new int[] {0, 0, 0, 0});
            this.nudDV.Increment = new decimal(new int[] {10000, 0, 0, 0});
            this.nudDV.Name = "nudDV";
            this.nudDV.Size = new System.Drawing.Size(170, 27);
            this.nudDV.TabIndex = 21;
            this.nudDV.ValueChanged += new System.EventHandler(this.nudTien_ValueChanged);
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(10, 165);
            this.btnTinh.Text = "Tính tiền";
            this.btnTinh.BackColor = System.Drawing.Color.FromArgb(52, 101, 164);
            this.btnTinh.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinh.FlatAppearance.BorderSize = 0;
            this.btnTinh.UseVisualStyleBackColor = false;
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(100, 32);
            this.btnTinh.TabIndex = 22;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(120, 165);
            this.btnLuu.Text = "Lưu hóa đơn";
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(52, 101, 164);
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 32);
            this.btnLuu.TabIndex = 23;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(250, 165);
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(52, 101, 164);
            this.btnThanhToan.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(110, 32);
            this.btnThanhToan.TabIndex = 24;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(370, 165);
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.BackColor = System.Drawing.Color.FromArgb(52, 101, 164);
            this.btnInHoaDon.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHoaDon.FlatAppearance.BorderSize = 0;
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(120, 32);
            this.btnInHoaDon.TabIndex = 25;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(500, 165);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(52, 101, 164);
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 32);
            this.btnLamMoi.TabIndex = 26;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(600, 165);
            this.btnXuat.Text = "Xuất ra file";
            this.btnXuat.BackColor = System.Drawing.Color.FromArgb(52, 101, 164);
            this.btnXuat.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuat.FlatAppearance.BorderSize = 0;
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(120, 32);
            this.btnXuat.TabIndex = 27;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // VienPhiForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1100, 640);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "VienPhiForm";
            this.Text = "Viện phí";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDV)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaVP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtThuoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudKham;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudDV;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXuat;
    }
}
