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
        {            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnTimkiem = new System.Windows.Forms.Panel();
            this.txtSdttim = new System.Windows.Forms.TextBox();
            this.txtCccdtim = new System.Windows.Forms.TextBox();
            this.txtTentim = new System.Windows.Forms.TextBox();
            this.txtMatim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
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
            this.btnXuat = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.btnTimkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeight = 34;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 309);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1100, 331);
            this.dgv.TabIndex = 0;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.btnTimkiem.Controls.Add(this.txtSdttim);
            this.btnTimkiem.Controls.Add(this.txtCccdtim);
            this.btnTimkiem.Controls.Add(this.txtTentim);
            this.btnTimkiem.Controls.Add(this.txtMatim);
            this.btnTimkiem.Controls.Add(this.btnTim);
            this.btnTimkiem.Controls.Add(this.label16);
            this.btnTimkiem.Controls.Add(this.label15);
            this.btnTimkiem.Controls.Add(this.label14);
            this.btnTimkiem.Controls.Add(this.label13);
            this.btnTimkiem.Controls.Add(this.label1);
            this.btnTimkiem.Controls.Add(this.txtMa);
            this.btnTimkiem.Controls.Add(this.label2);
            this.btnTimkiem.Controls.Add(this.txtTen);
            this.btnTimkiem.Controls.Add(this.label3);
            this.btnTimkiem.Controls.Add(this.dtpNs);
            this.btnTimkiem.Controls.Add(this.label4);
            this.btnTimkiem.Controls.Add(this.cmbGt);
            this.btnTimkiem.Controls.Add(this.label5);
            this.btnTimkiem.Controls.Add(this.txtCccd);
            this.btnTimkiem.Controls.Add(this.label6);
            this.btnTimkiem.Controls.Add(this.txtSdt);
            this.btnTimkiem.Controls.Add(this.label7);
            this.btnTimkiem.Controls.Add(this.txtNghe);
            this.btnTimkiem.Controls.Add(this.label8);
            this.btnTimkiem.Controls.Add(this.txtDiaChi);
            this.btnTimkiem.Controls.Add(this.label9);
            this.btnTimkiem.Controls.Add(this.txtNguoiThan);
            this.btnTimkiem.Controls.Add(this.label10);
            this.btnTimkiem.Controls.Add(this.txtSdtNT);
            this.btnTimkiem.Controls.Add(this.label11);
            this.btnTimkiem.Controls.Add(this.txtTinhTrang);
            this.btnTimkiem.Controls.Add(this.btnThem);
            this.btnTimkiem.Controls.Add(this.btnSua);
            this.btnTimkiem.Controls.Add(this.btnXoa);
            this.btnTimkiem.Controls.Add(this.btnLamMoi);
            this.btnTimkiem.Controls.Add(this.btnXuat);
            this.btnTimkiem.Controls.Add(this.label12);
            this.btnTimkiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimkiem.Location = new System.Drawing.Point(0, 0);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(1100, 309);
            this.btnTimkiem.TabIndex = 1;
            // 
            // txtSdttim
            // 
            this.txtSdttim.Location = new System.Drawing.Point(752, 271);
            this.txtSdttim.Name = "txtSdttim";
            this.txtSdttim.Size = new System.Drawing.Size(170, 34);
            this.txtSdttim.TabIndex = 39;
            // 
            // txtCccdtim
            // 
            this.txtCccdtim.Location = new System.Drawing.Point(517, 271);
            this.txtCccdtim.Name = "txtCccdtim";
            this.txtCccdtim.Size = new System.Drawing.Size(170, 34);
            this.txtCccdtim.TabIndex = 38;
            // 
            // txtTentim
            // 
            this.txtTentim.Location = new System.Drawing.Point(260, 271);
            this.txtTentim.Name = "txtTentim";
            this.txtTentim.Size = new System.Drawing.Size(190, 34);
            this.txtTentim.TabIndex = 37;
            // 
            // txtMatim
            // 
            this.txtMatim.Location = new System.Drawing.Point(10, 271);
            this.txtMatim.Name = "txtMatim";
            this.txtMatim.Size = new System.Drawing.Size(190, 34);
            this.txtMatim.TabIndex = 36;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Goldenrod;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTim.Location = new System.Drawing.Point(957, 271);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(120, 32);
            this.btnTim.TabIndex = 35;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(747, 244);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 24);
            this.label16.TabIndex = 34;
            this.label16.Text = "SĐT";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(512, 244);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 24);
            this.label15.TabIndex = 33;
            this.label15.Text = "CCCD";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(255, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 24);
            this.label14.TabIndex = 32;
            this.label14.Text = "Họ tên";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(12, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 24);
            this.label13.TabIndex = 31;
            this.label13.Text = "Mã BN";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã BN";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(135, 10);
            this.txtMa.Name = "txtMa";
            this.txtMa.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(170, 34);
            this.txtMa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ tên";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(135, 45);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(170, 34);
            this.txtTen.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày sinh";
            // 
            // dtpNs
            // 
            this.dtpNs.CustomFormat = "dd/MM/yyyy";
            this.dtpNs.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNs.Location = new System.Drawing.Point(135, 80);
            this.dtpNs.Name = "dtpNs";
            this.dtpNs.Size = new System.Drawing.Size(170, 34);
            this.dtpNs.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giới tính";
            // 
            // cmbGt
            // 
            this.cmbGt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGt.FormattingEnabled = true;
            this.cmbGt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGt.Location = new System.Drawing.Point(135, 115);
            this.cmbGt.Name = "cmbGt";
            this.cmbGt.Size = new System.Drawing.Size(170, 36);
            this.cmbGt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(330, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "CCCD";
            // 
            // txtCccd
            // 
            this.txtCccd.Location = new System.Drawing.Point(455, 10);
            this.txtCccd.Name = "txtCccd";
            this.txtCccd.Size = new System.Drawing.Size(170, 34);
            this.txtCccd.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(330, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "SĐT";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(455, 45);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(170, 34);
            this.txtSdt.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(330, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nghề nghiệp";
            // 
            // txtNghe
            // 
            this.txtNghe.Location = new System.Drawing.Point(455, 80);
            this.txtNghe.Name = "txtNghe";
            this.txtNghe.Size = new System.Drawing.Size(170, 34);
            this.txtNghe.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(330, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(455, 115);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(170, 34);
            this.txtDiaChi.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(650, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Người thân";
            // 
            // txtNguoiThan
            // 
            this.txtNguoiThan.Location = new System.Drawing.Point(775, 10);
            this.txtNguoiThan.Name = "txtNguoiThan";
            this.txtNguoiThan.Size = new System.Drawing.Size(230, 34);
            this.txtNguoiThan.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(650, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "SĐT người thân";
            // 
            // txtSdtNT
            // 
            this.txtSdtNT.Location = new System.Drawing.Point(775, 45);
            this.txtSdtNT.Name = "txtSdtNT";
            this.txtSdtNT.Size = new System.Drawing.Size(230, 34);
            this.txtSdtNT.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(650, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 24);
            this.label11.TabIndex = 22;
            this.label11.Text = "Tình trạng bệnh";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(775, 80);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(230, 34);
            this.txtTinhTrang.TabIndex = 23;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(101)))), ((int)(((byte)(164)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThem.Location = new System.Drawing.Point(10, 165);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 32);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(101)))), ((int)(((byte)(164)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSua.Location = new System.Drawing.Point(110, 165);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 32);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoa.Location = new System.Drawing.Point(210, 165);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 32);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(101)))), ((int)(((byte)(164)))));
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLamMoi.Location = new System.Drawing.Point(310, 165);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 32);
            this.btnLamMoi.TabIndex = 27;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.Color.Green;
            this.btnXuat.FlatAppearance.BorderSize = 0;
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXuat.Location = new System.Drawing.Point(415, 165);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(120, 32);
            this.btnXuat.TabIndex = 29;
            this.btnXuat.Text = "Xuất ra file";
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.label12.Location = new System.Drawing.Point(10, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 24);
            this.label12.TabIndex = 30;
            this.label12.Text = "Tìm kiếm";
            // 
            // BenhNhanForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1100, 640);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnTimkiem);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BenhNhanForm";
            this.Text = "Quản lý bệnh nhân";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.btnTimkiem.ResumeLayout(false);
            this.btnTimkiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel btnTimkiem;
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
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSdttim;
        private System.Windows.Forms.TextBox txtCccdtim;
        private System.Windows.Forms.TextBox txtTentim;
        private System.Windows.Forms.TextBox txtMatim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}
