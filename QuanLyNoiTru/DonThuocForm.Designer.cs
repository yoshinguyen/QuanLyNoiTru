namespace QuanLyNoiTru
{
    partial class DonThuocForm
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
            this.cmbBA = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDon = new System.Windows.Forms.ComboBox();
            this.btnTaoDon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGhiChuDon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbThuoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudSL = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCach = new System.Windows.Forms.TextBox();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoaThuoc = new System.Windows.Forms.Button();
            this.lblTong = new System.Windows.Forms.Label();
            this.btnXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).BeginInit();
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
            this.pnlTop.Controls.Add(this.cmbBA);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.cmbDon);
            this.pnlTop.Controls.Add(this.btnTaoDon);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.txtGhiChuDon);
            this.pnlTop.Controls.Add(this.label4);
            this.pnlTop.Controls.Add(this.cmbThuoc);
            this.pnlTop.Controls.Add(this.label5);
            this.pnlTop.Controls.Add(this.nudSL);
            this.pnlTop.Controls.Add(this.label6);
            this.pnlTop.Controls.Add(this.lblGia);
            this.pnlTop.Controls.Add(this.label8);
            this.pnlTop.Controls.Add(this.txtLieu);
            this.pnlTop.Controls.Add(this.label9);
            this.pnlTop.Controls.Add(this.txtCach);
            this.pnlTop.Controls.Add(this.btnThemThuoc);
            this.pnlTop.Controls.Add(this.btnCapNhat);
            this.pnlTop.Controls.Add(this.btnXoaThuoc);
            this.pnlTop.Controls.Add(this.lblTong);
            this.pnlTop.Controls.Add(this.btnXuat);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1100, 240);
            this.pnlTop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.AutoSize = false;
            this.label1.Text = "Bệnh án";
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 2;
            // 
            // cmbBA
            // 
            this.cmbBA.Location = new System.Drawing.Point(135, 10);
            this.cmbBA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBA.FormattingEnabled = true;
            this.cmbBA.Name = "cmbBA";
            this.cmbBA.Size = new System.Drawing.Size(470, 28);
            this.cmbBA.TabIndex = 3;
            this.cmbBA.SelectedIndexChanged += new System.EventHandler(this.cmbBA_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(630, 16);
            this.label2.AutoSize = false;
            this.label2.Text = "Đơn thuốc";
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 4;
            // 
            // cmbDon
            // 
            this.cmbDon.Location = new System.Drawing.Point(725, 10);
            this.cmbDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDon.FormattingEnabled = true;
            this.cmbDon.Name = "cmbDon";
            this.cmbDon.Size = new System.Drawing.Size(140, 28);
            this.cmbDon.TabIndex = 5;
            this.cmbDon.SelectedIndexChanged += new System.EventHandler(this.cmbDon_SelectedIndexChanged);
            // 
            // btnTaoDon
            // 
            this.btnTaoDon.Location = new System.Drawing.Point(880, 8);
            this.btnTaoDon.Text = "Tạo đơn mới";
            this.btnTaoDon.BackColor = System.Drawing.Color.FromArgb(52, 101, 164);
            this.btnTaoDon.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnTaoDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoDon.FlatAppearance.BorderSize = 0;
            this.btnTaoDon.UseVisualStyleBackColor = false;
            this.btnTaoDon.Name = "btnTaoDon";
            this.btnTaoDon.Size = new System.Drawing.Size(125, 32);
            this.btnTaoDon.TabIndex = 6;
            this.btnTaoDon.Click += new System.EventHandler(this.btnTaoDon_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 51);
            this.label3.AutoSize = false;
            this.label3.Text = "Ghi chú đơn";
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 7;
            // 
            // txtGhiChuDon
            // 
            this.txtGhiChuDon.Location = new System.Drawing.Point(135, 45);
            this.txtGhiChuDon.Name = "txtGhiChuDon";
            this.txtGhiChuDon.Size = new System.Drawing.Size(470, 27);
            this.txtGhiChuDon.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 96);
            this.label4.AutoSize = false;
            this.label4.Text = "Thuốc";
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 9;
            // 
            // cmbThuoc
            // 
            this.cmbThuoc.Location = new System.Drawing.Point(135, 90);
            this.cmbThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThuoc.FormattingEnabled = true;
            this.cmbThuoc.Name = "cmbThuoc";
            this.cmbThuoc.Size = new System.Drawing.Size(330, 28);
            this.cmbThuoc.TabIndex = 10;
            this.cmbThuoc.SelectedIndexChanged += new System.EventHandler(this.cmbThuoc_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(490, 96);
            this.label5.AutoSize = false;
            this.label5.Text = "Số lượng";
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 11;
            // 
            // nudSL
            // 
            this.nudSL.Location = new System.Drawing.Point(565, 90);
            this.nudSL.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.nudSL.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            this.nudSL.ThousandsSeparator = true;
            this.nudSL.Value = new decimal(new int[] {1, 0, 0, 0});
            this.nudSL.Name = "nudSL";
            this.nudSL.Size = new System.Drawing.Size(90, 27);
            this.nudSL.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(680, 96);
            this.label6.AutoSize = false;
            this.label6.Text = "Đơn giá";
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 13;
            // 
            // lblGia
            // 
            this.lblGia.Location = new System.Drawing.Point(755, 96);
            this.lblGia.AutoSize = false;
            this.lblGia.Text = "0 đ";
            this.lblGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(150, 24);
            this.lblGia.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(10, 131);
            this.label8.AutoSize = false;
            this.label8.Text = "Liều dùng";
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 24);
            this.label8.TabIndex = 15;
            // 
            // txtLieu
            // 
            this.txtLieu.Location = new System.Drawing.Point(135, 125);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(330, 27);
            this.txtLieu.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(490, 131);
            this.label9.AutoSize = false;
            this.label9.Text = "Cách dùng";
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 24);
            this.label9.TabIndex = 17;
            // 
            // txtCach
            // 
            this.txtCach.Location = new System.Drawing.Point(565, 125);
            this.txtCach.Name = "txtCach";
            this.txtCach.Size = new System.Drawing.Size(440, 27);
            this.txtCach.TabIndex = 18;
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.Location = new System.Drawing.Point(10, 170);
            this.btnThemThuoc.Text = "Thêm thuốc";
            this.btnThemThuoc.BackColor = System.Drawing.Color.FromArgb(52, 101, 164);
            this.btnThemThuoc.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnThemThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemThuoc.FlatAppearance.BorderSize = 0;
            this.btnThemThuoc.UseVisualStyleBackColor = false;
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(110, 32);
            this.btnThemThuoc.TabIndex = 19;
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(130, 170);
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(52, 101, 164);
            this.btnCapNhat.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 32);
            this.btnCapNhat.TabIndex = 20;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoaThuoc
            // 
            this.btnXoaThuoc.Location = new System.Drawing.Point(240, 170);
            this.btnXoaThuoc.Text = "Xóa thuốc";
            this.btnXoaThuoc.BackColor = System.Drawing.Color.FromArgb(52, 101, 164);
            this.btnXoaThuoc.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnXoaThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaThuoc.FlatAppearance.BorderSize = 0;
            this.btnXoaThuoc.UseVisualStyleBackColor = false;
            this.btnXoaThuoc.Name = "btnXoaThuoc";
            this.btnXoaThuoc.Size = new System.Drawing.Size(100, 32);
            this.btnXoaThuoc.TabIndex = 21;
            this.btnXoaThuoc.Click += new System.EventHandler(this.btnXoaThuoc_Click);
            // 
            // lblTong
            // 
            this.lblTong.Location = new System.Drawing.Point(370, 176);
            this.lblTong.AutoSize = false;
            this.lblTong.Text = "Tổng tiền đơn: 0 đ";
            this.lblTong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(400, 24);
            this.lblTong.TabIndex = 22;
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(885, 170);
            this.btnXuat.Text = "Xuất ra file";
            this.btnXuat.BackColor = System.Drawing.Color.FromArgb(52, 101, 164);
            this.btnXuat.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuat.FlatAppearance.BorderSize = 0;
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(120, 32);
            this.btnXuat.TabIndex = 23;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // DonThuocForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1100, 640);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DonThuocForm";
            this.Text = "Đơn thuốc";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDon;
        private System.Windows.Forms.Button btnTaoDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGhiChuDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbThuoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudSL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLieu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCach;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoaThuoc;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Button btnXuat;
    }
}
