namespace QuanLyNoiTru
{
    partial class BenhNhanForm
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
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNs = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCccd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNghe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNguoiThan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSdtNT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
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
            this.pnlTop.Controls.Add(this.txtMa);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.txtTen);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.dtpNs);
            this.pnlTop.Controls.Add(this.label4);
            this.pnlTop.Controls.Add(this.cmbGt);
            this.pnlTop.Controls.Add(this.label5);
            this.pnlTop.Controls.Add(this.txtCccd);
            this.pnlTop.Controls.Add(this.label6);
            this.pnlTop.Controls.Add(this.txtSdt);
            this.pnlTop.Controls.Add(this.label7);
            this.pnlTop.Controls.Add(this.txtNghe);
            this.pnlTop.Controls.Add(this.label8);
            this.pnlTop.Controls.Add(this.txtDiaChi);
            this.pnlTop.Controls.Add(this.label9);
            this.pnlTop.Controls.Add(this.txtNguoiThan);
            this.pnlTop.Controls.Add(this.label10);
            this.pnlTop.Controls.Add(this.txtSdtNT);
            this.pnlTop.Controls.Add(this.label11);
            this.pnlTop.Controls.Add(this.txtTinhTrang);
            this.pnlTop.Controls.Add(this.btnThem);
            this.pnlTop.Controls.Add(this.btnSua);
            this.pnlTop.Controls.Add(this.btnXoa);
            this.pnlTop.Controls.Add(this.btnLamMoi);
            this.pnlTop.Controls.Add(this.btnNhap);
            this.pnlTop.Controls.Add(this.btnXuat);
            this.pnlTop.Controls.Add(this.label12);
            this.pnlTop.Controls.Add(this.txtTim);
            this.pnlTop.Controls.Add(this.label13);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1100, 250);
            this.pnlTop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.AutoSize = false;
            this.label1.Text = "Mã BN";
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 2;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(135, 10);
            this.txtMa.ReadOnly = true;
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(170, 27);
            this.txtMa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.AutoSize = false;
            this.label2.Text = "Họ tên";
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 4;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(135, 45);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(170, 27);
            this.txtTen.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 86);
            this.label3.AutoSize = false;
            this.label3.Text = "Ngày sinh";
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 6;
            // 
            // dtpNs
            // 
            this.dtpNs.Location = new System.Drawing.Point(135, 80);
            this.dtpNs.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNs.CustomFormat = "dd/MM/yyyy";
            this.dtpNs.Name = "dtpNs";
            this.dtpNs.Size = new System.Drawing.Size(170, 27);
            this.dtpNs.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 121);
            this.label4.AutoSize = false;
            this.label4.Text = "Giới tính";
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 8;
            // 
            // cmbGt
            // 
            this.cmbGt.Location = new System.Drawing.Point(135, 115);
            this.cmbGt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGt.FormattingEnabled = true;
            this.cmbGt.Items.AddRange(new object[] {"Nam", "Nữ"});
            this.cmbGt.Name = "cmbGt";
            this.cmbGt.Size = new System.Drawing.Size(170, 28);
            this.cmbGt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(330, 16);
            this.label5.AutoSize = false;
            this.label5.Text = "CCCD";
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 10;
            // 
            // txtCccd
            // 
            this.txtCccd.Location = new System.Drawing.Point(455, 10);
            this.txtCccd.Name = "txtCccd";
            this.txtCccd.Size = new System.Drawing.Size(170, 27);
            this.txtCccd.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(330, 51);
            this.label6.AutoSize = false;
            this.label6.Text = "SĐT";
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 24);
            this.label6.TabIndex = 12;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(455, 45);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(170, 27);
            this.txtSdt.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(330, 86);
            this.label7.AutoSize = false;
            this.label7.Text = "Nghề nghiệp";
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 14;
            // 
            // txtNghe
            // 
            this.txtNghe.Location = new System.Drawing.Point(455, 80);
            this.txtNghe.Name = "txtNghe";
            this.txtNghe.Size = new System.Drawing.Size(170, 27);
            this.txtNghe.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(330, 121);
            this.label8.AutoSize = false;
            this.label8.Text = "Địa chỉ";
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 24);
            this.label8.TabIndex = 16;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(455, 115);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(170, 27);
            this.txtDiaChi.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(650, 16);
            this.label9.AutoSize = false;
            this.label9.Text = "Người thân";
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 24);
            this.label9.TabIndex = 18;
            // 
            // txtNguoiThan
            // 
            this.txtNguoiThan.Location = new System.Drawing.Point(775, 10);
            this.txtNguoiThan.Name = "txtNguoiThan";
            this.txtNguoiThan.Size = new System.Drawing.Size(230, 27);
            this.txtNguoiThan.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(650, 51);
            this.label10.AutoSize = false;
            this.label10.Text = "SĐT người thân";
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 24);
            this.label10.TabIndex = 20;
            // 
            // txtSdtNT
            // 
            this.txtSdtNT.Location = new System.Drawing.Point(775, 45);
            this.txtSdtNT.Name = "txtSdtNT";
            this.txtSdtNT.Size = new System.Drawing.Size(230, 27);
            this.txtSdtNT.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(650, 86);
            this.label11.AutoSize = false;
            this.label11.Text = "Tình trạng bệnh";
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 24);
            this.label11.TabIndex = 22;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(775, 80);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(230, 27);
            this.txtTinhTrang.TabIndex = 23;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(10, 165);
            this.btnThem.Text = "Thêm";
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(52, 101, 164);
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 32);
            this.btnThem.TabIndex = 24;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(110, 165);
            this.btnSua.Text = "Sửa";
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(52, 101, 164);
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 32);
            this.btnSua.TabIndex = 25;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(210, 165);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(52, 101, 164);
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 32);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(310, 165);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(52, 101, 164);
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 32);
            this.btnLamMoi.TabIndex = 27;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(430, 165);
            this.btnNhap.Text = "Nhập từ file";
            this.btnNhap.BackColor = System.Drawing.Color.FromArgb(52, 101, 164);
            this.btnNhap.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhap.FlatAppearance.BorderSize = 0;
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(120, 32);
            this.btnNhap.TabIndex = 28;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(560, 165);
            this.btnXuat.Text = "Xuất ra file";
            this.btnXuat.BackColor = System.Drawing.Color.FromArgb(52, 101, 164);
            this.btnXuat.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuat.FlatAppearance.BorderSize = 0;
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(120, 32);
            this.btnXuat.TabIndex = 29;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(10, 211);
            this.label12.AutoSize = false;
            this.label12.Text = "Tìm kiếm";
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 24);
            this.label12.TabIndex = 30;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(135, 205);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(300, 27);
            this.txtTim.TabIndex = 31;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(445, 211);
            this.label13.AutoSize = false;
            this.label13.Text = "(mã, họ tên, CCCD, SĐT)";
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 24);
            this.label13.TabIndex = 32;
            // 
            // BenhNhanForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1100, 640);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BenhNhanForm";
            this.Text = "Quản lý bệnh nhân";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCccd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNghe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNguoiThan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSdtNT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label13;
    }
}
