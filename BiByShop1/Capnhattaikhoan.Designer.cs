namespace BiByShop1
{
    partial class Capnhattaikhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.components = new System.ComponentModel.Container();
            this.RbGt01 = new System.Windows.Forms.RadioButton();
            this.CBQuyen = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGRTaikhoan = new System.Windows.Forms.DataGridView();
            this.MaTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnHuybo = new System.Windows.Forms.Button();
            this.BtnTimkiem = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.DTNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.TxtDiachi = new System.Windows.Forms.TextBox();
            this.TxtHoten = new System.Windows.Forms.TextBox();
            this.TxtMatkhau = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Kiemtramatkhau = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnSua = new System.Windows.Forms.Button();
            this.BtnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckMaTK = new System.Windows.Forms.ErrorProvider(this.components);
            this.RbGT02 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_TenQ = new System.Windows.Forms.ErrorProvider(this.components);
            this.chk_Hoten = new System.Windows.Forms.ErrorProvider(this.components);
            this.chk_email = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGRTaikhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kiemtramatkhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckMaTK)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_TenQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_Hoten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_email)).BeginInit();
            this.SuspendLayout();
            // 
            // RbGt01
            // 
            this.RbGt01.AutoSize = true;
            this.RbGt01.Location = new System.Drawing.Point(436, 91);
            this.RbGt01.Name = "RbGt01";
            this.RbGt01.Size = new System.Drawing.Size(47, 17);
            this.RbGt01.TabIndex = 18;
            this.RbGt01.TabStop = true;
            this.RbGt01.Text = "Nam";
            this.RbGt01.UseVisualStyleBackColor = true;
            // 
            // CBQuyen
            // 
            this.CBQuyen.FormattingEnabled = true;
            this.CBQuyen.Location = new System.Drawing.Point(108, 30);
            this.CBQuyen.Name = "CBQuyen";
            this.CBQuyen.Size = new System.Drawing.Size(218, 21);
            this.CBQuyen.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGRTaikhoan);
            this.groupBox2.Location = new System.Drawing.Point(2, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(781, 176);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách tài khoản";
            // 
            // DGRTaikhoan
            // 
            this.DGRTaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGRTaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTK,
            this.TenQ,
            this.Email,
            this.Matkhau,
            this.Hoten,
            this.Ngaysinh,
            this.Gioitinh,
            this.Diachi});
            this.DGRTaikhoan.Location = new System.Drawing.Point(25, 13);
            this.DGRTaikhoan.Name = "DGRTaikhoan";
            this.DGRTaikhoan.Size = new System.Drawing.Size(735, 157);
            this.DGRTaikhoan.TabIndex = 0;
            this.DGRTaikhoan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGRTaikhoan_CellDoubleClick);
            this.DGRTaikhoan.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGRTaikhoan_CellFormatting);
            // 
            // MaTK
            // 
            this.MaTK.DataPropertyName = "MaTK";
            this.MaTK.HeaderText = "Mã TK";
            this.MaTK.Name = "MaTK";
            // 
            // TenQ
            // 
            this.TenQ.DataPropertyName = "TenQ";
            this.TenQ.HeaderText = "Quyền";
            this.TenQ.Name = "TenQ";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Matkhau
            // 
            this.Matkhau.DataPropertyName = "Matkhau";
            this.Matkhau.HeaderText = "Mật khẩu";
            this.Matkhau.Name = "Matkhau";
            // 
            // Hoten
            // 
            this.Hoten.DataPropertyName = "Hoten";
            this.Hoten.HeaderText = "Họ tên";
            this.Hoten.Name = "Hoten";
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.DataPropertyName = "Ngaysinh";
            this.Ngaysinh.HeaderText = "Ngày sinh";
            this.Ngaysinh.Name = "Ngaysinh";
            // 
            // Gioitinh
            // 
            this.Gioitinh.DataPropertyName = "Gioitinh";
            this.Gioitinh.HeaderText = "Giới tính";
            this.Gioitinh.Name = "Gioitinh";
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "Diachi";
            this.Diachi.HeaderText = "Địa chỉ";
            this.Diachi.Name = "Diachi";
            // 
            // BtnHuybo
            // 
            this.BtnHuybo.Location = new System.Drawing.Point(546, 182);
            this.BtnHuybo.Name = "BtnHuybo";
            this.BtnHuybo.Size = new System.Drawing.Size(75, 23);
            this.BtnHuybo.TabIndex = 22;
            this.BtnHuybo.Text = "Hủy bỏ";
            this.BtnHuybo.UseVisualStyleBackColor = true;
            this.BtnHuybo.Click += new System.EventHandler(this.BtnHuybo_Click);
            // 
            // BtnTimkiem
            // 
            this.BtnTimkiem.Location = new System.Drawing.Point(410, 183);
            this.BtnTimkiem.Name = "BtnTimkiem";
            this.BtnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.BtnTimkiem.TabIndex = 21;
            this.BtnTimkiem.Text = "Tìm kiếm";
            this.BtnTimkiem.UseVisualStyleBackColor = true;
            this.BtnTimkiem.Click += new System.EventHandler(this.BtnTimkiem_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(281, 182);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(75, 23);
            this.BtnXoa.TabIndex = 20;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // DTNgaysinh
            // 
            this.DTNgaysinh.CustomFormat = "dd/MM/yyyy";
            this.DTNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTNgaysinh.Location = new System.Drawing.Point(435, 62);
            this.DTNgaysinh.Name = "DTNgaysinh";
            this.DTNgaysinh.Size = new System.Drawing.Size(185, 20);
            this.DTNgaysinh.TabIndex = 17;
            // 
            // TxtDiachi
            // 
            this.TxtDiachi.Location = new System.Drawing.Point(108, 125);
            this.TxtDiachi.Name = "TxtDiachi";
            this.TxtDiachi.Size = new System.Drawing.Size(218, 20);
            this.TxtDiachi.TabIndex = 14;
            // 
            // TxtHoten
            // 
            this.TxtHoten.Location = new System.Drawing.Point(435, 29);
            this.TxtHoten.MaxLength = 50;
            this.TxtHoten.Name = "TxtHoten";
            this.TxtHoten.Size = new System.Drawing.Size(185, 20);
            this.TxtHoten.TabIndex = 12;
            // 
            // TxtMatkhau
            // 
            this.TxtMatkhau.Location = new System.Drawing.Point(108, 93);
            this.TxtMatkhau.Name = "TxtMatkhau";
            this.TxtMatkhau.Size = new System.Drawing.Size(218, 20);
            this.TxtMatkhau.TabIndex = 11;
            this.TxtMatkhau.TextChanged += new System.EventHandler(this.TxtMatkhau_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu";
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(674, 181);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(75, 23);
            this.BtnThoat.TabIndex = 24;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(108, 62);
            this.TxtEmail.MaxLength = 100;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(218, 20);
            this.TxtEmail.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // Kiemtramatkhau
            // 
            this.Kiemtramatkhau.ContainerControl = this;
            // 
            // BtnSua
            // 
            this.BtnSua.Location = new System.Drawing.Point(149, 182);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(75, 23);
            this.BtnSua.TabIndex = 19;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.Location = new System.Drawing.Point(27, 182);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(75, 23);
            this.BtnThem.TabIndex = 18;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quyền";
            // 
            // CheckMaTK
            // 
            this.CheckMaTK.ContainerControl = this;
            // 
            // RbGT02
            // 
            this.RbGT02.AutoSize = true;
            this.RbGT02.Location = new System.Drawing.Point(489, 91);
            this.RbGT02.Name = "RbGT02";
            this.RbGT02.Size = new System.Drawing.Size(39, 17);
            this.RbGT02.TabIndex = 19;
            this.RbGT02.TabStop = true;
            this.RbGT02.Text = "Nữ";
            this.RbGT02.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RbGT02);
            this.groupBox1.Controls.Add(this.RbGt01);
            this.groupBox1.Controls.Add(this.DTNgaysinh);
            this.groupBox1.Controls.Add(this.CBQuyen);
            this.groupBox1.Controls.Add(this.TxtDiachi);
            this.groupBox1.Controls.Add(this.TxtHoten);
            this.groupBox1.Controls.Add(this.TxtMatkhau);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 162);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "(*)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "(*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "(*)";
            // 
            // chk_TenQ
            // 
            this.chk_TenQ.ContainerControl = this;
            // 
            // chk_Hoten
            // 
            this.chk_Hoten.ContainerControl = this;
            // 
            // chk_email
            // 
            this.chk_email.ContainerControl = this;
            // 
            // Capnhattaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 410);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnHuybo);
            this.Controls.Add(this.BtnTimkiem);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.groupBox1);
            this.Name = "Capnhattaikhoan";
            this.Text = "Cập nhật tài khoản";
            this.Load += new System.EventHandler(this.Capnhattaikhoan_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGRTaikhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kiemtramatkhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckMaTK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_TenQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_Hoten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_email)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton RbGt01;
        private System.Windows.Forms.ComboBox CBQuyen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGRTaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.Button BtnHuybo;
        private System.Windows.Forms.Button BtnTimkiem;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.DateTimePicker DTNgaysinh;
        private System.Windows.Forms.TextBox TxtDiachi;
        private System.Windows.Forms.TextBox TxtHoten;
        private System.Windows.Forms.TextBox TxtMatkhau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider Kiemtramatkhau;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbGT02;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider CheckMaTK;
        private System.Windows.Forms.ErrorProvider chk_TenQ;
        private System.Windows.Forms.ErrorProvider chk_Hoten;
        private System.Windows.Forms.ErrorProvider chk_email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
    }
}

