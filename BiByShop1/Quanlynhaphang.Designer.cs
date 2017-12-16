namespace BiByShop1
{
    partial class Quanlynhaphang
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
            this.DGRDanhsachphieunhap = new System.Windows.Forms.DataGridView();
            this.MaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtMaPN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbNguoilap = new System.Windows.Forms.ComboBox();
            this.DTNgaylap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnTimkiem = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnBaocao = new System.Windows.Forms.Button();
            this.TxtNCC = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.btnChitietpn = new System.Windows.Forms.Button();
            this.BtnHuybo = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.btnLapphieunhap = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.MtbSDT = new System.Windows.Forms.MaskedTextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGRDanhsachphieunhap)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGRDanhsachphieunhap
            // 
            this.DGRDanhsachphieunhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGRDanhsachphieunhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPN,
            this.TenNV,
            this.Ngaylap,
            this.TenNCC,
            this.MaNCC});
            this.DGRDanhsachphieunhap.Location = new System.Drawing.Point(109, 19);
            this.DGRDanhsachphieunhap.Name = "DGRDanhsachphieunhap";
            this.DGRDanhsachphieunhap.Size = new System.Drawing.Size(559, 176);
            this.DGRDanhsachphieunhap.TabIndex = 0;
            this.DGRDanhsachphieunhap.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGRDanhsachphieunhap_CellDoubleClick);
            // 
            // MaPN
            // 
            this.MaPN.DataPropertyName = "MaPN";
            this.MaPN.HeaderText = "Mã phiếu nhập";
            this.MaPN.Name = "MaPN";
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "Hoten";
            this.TenNV.HeaderText = "Người lập";
            this.TenNV.Name = "TenNV";
            // 
            // Ngaylap
            // 
            this.Ngaylap.DataPropertyName = "Ngaylap";
            this.Ngaylap.HeaderText = "Ngày lập";
            this.Ngaylap.Name = "Ngaylap";
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên nhà cung cấp";
            this.TenNCC.Name = "TenNCC";
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Visible = false;
            // 
            // TxtMaPN
            // 
            this.TxtMaPN.Location = new System.Drawing.Point(136, 30);
            this.TxtMaPN.Name = "TxtMaPN";
            this.TxtMaPN.Size = new System.Drawing.Size(241, 20);
            this.TxtMaPN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // CbNguoilap
            // 
            this.CbNguoilap.FormattingEnabled = true;
            this.CbNguoilap.Location = new System.Drawing.Point(136, 61);
            this.CbNguoilap.Name = "CbNguoilap";
            this.CbNguoilap.Size = new System.Drawing.Size(241, 21);
            this.CbNguoilap.TabIndex = 2;
            // 
            // DTNgaylap
            // 
            this.DTNgaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTNgaylap.Location = new System.Drawing.Point(136, 104);
            this.DTNgaylap.Name = "DTNgaylap";
            this.DTNgaylap.Size = new System.Drawing.Size(239, 20);
            this.DTNgaylap.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Người lập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên nhà cung cấp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Địa chỉ";
            // 
            // BtnTimkiem
            // 
            this.BtnTimkiem.Location = new System.Drawing.Point(347, 163);
            this.BtnTimkiem.Name = "BtnTimkiem";
            this.BtnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.BtnTimkiem.TabIndex = 27;
            this.BtnTimkiem.Text = "Tìm kiếm";
            this.BtnTimkiem.UseVisualStyleBackColor = true;
            this.BtnTimkiem.Click += new System.EventHandler(this.BtnTimkiem_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(249, 163);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(75, 23);
            this.BtnXoa.TabIndex = 26;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnBaocao
            // 
            this.BtnBaocao.Location = new System.Drawing.Point(453, 163);
            this.BtnBaocao.Name = "BtnBaocao";
            this.BtnBaocao.Size = new System.Drawing.Size(75, 23);
            this.BtnBaocao.TabIndex = 28;
            this.BtnBaocao.Text = "Báo cáo";
            this.BtnBaocao.UseVisualStyleBackColor = true;
            this.BtnBaocao.Click += new System.EventHandler(this.BtnBaocao_Click);
            // 
            // TxtNCC
            // 
            this.TxtNCC.Location = new System.Drawing.Point(116, 24);
            this.TxtNCC.Name = "TxtNCC";
            this.TxtNCC.Size = new System.Drawing.Size(225, 20);
            this.TxtNCC.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DGRDanhsachphieunhap);
            this.groupBox3.Location = new System.Drawing.Point(12, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(806, 217);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách hóa đơn";
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(762, 163);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(56, 23);
            this.BtnThoat.TabIndex = 31;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // btnChitietpn
            // 
            this.btnChitietpn.Location = new System.Drawing.Point(648, 163);
            this.btnChitietpn.Name = "btnChitietpn";
            this.btnChitietpn.Size = new System.Drawing.Size(105, 23);
            this.btnChitietpn.TabIndex = 30;
            this.btnChitietpn.Text = "Chi tiết phiếu nhập";
            this.btnChitietpn.UseVisualStyleBackColor = true;
            this.btnChitietpn.Click += new System.EventHandler(this.btnChitietpn_Click);
            // 
            // BtnHuybo
            // 
            this.BtnHuybo.Location = new System.Drawing.Point(567, 163);
            this.BtnHuybo.Name = "BtnHuybo";
            this.BtnHuybo.Size = new System.Drawing.Size(75, 23);
            this.BtnHuybo.TabIndex = 29;
            this.BtnHuybo.Text = "Hủy bỏ";
            this.BtnHuybo.UseVisualStyleBackColor = true;
            this.BtnHuybo.Click += new System.EventHandler(this.BtnHuybo_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.Location = new System.Drawing.Point(146, 163);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(75, 23);
            this.BtnSua.TabIndex = 25;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnLapphieunhap
            // 
            this.btnLapphieunhap.Location = new System.Drawing.Point(30, 163);
            this.btnLapphieunhap.Name = "btnLapphieunhap";
            this.btnLapphieunhap.Size = new System.Drawing.Size(99, 23);
            this.btnLapphieunhap.TabIndex = 24;
            this.btnLapphieunhap.Text = "Thêm phiếu nhập";
            this.btnLapphieunhap.UseVisualStyleBackColor = true;
            this.btnLapphieunhap.Click += new System.EventHandler(this.btnLapphieunhap_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtEmail);
            this.groupBox2.Controls.Add(this.MtbSDT);
            this.groupBox2.Controls.Add(this.txtDiachi);
            this.groupBox2.Controls.Add(this.TxtNCC);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(451, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 144);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhà cung cấp";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(116, 101);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(225, 20);
            this.TxtEmail.TabIndex = 7;
            // 
            // MtbSDT
            // 
            this.MtbSDT.Location = new System.Drawing.Point(116, 74);
            this.MtbSDT.Mask = "00000000000";
            this.MtbSDT.Name = "MtbSDT";
            this.MtbSDT.Size = new System.Drawing.Size(225, 20);
            this.MtbSDT.TabIndex = 6;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(116, 50);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(225, 20);
            this.txtDiachi.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Số điện thoại";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtMaPN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CbNguoilap);
            this.groupBox1.Controls.Add(this.DTNgaylap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 144);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // Quanlynhaphang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 418);
            this.Controls.Add(this.BtnTimkiem);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnBaocao);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.btnChitietpn);
            this.Controls.Add(this.BtnHuybo);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.btnLapphieunhap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Quanlynhaphang";
            this.Text = "Quanlynhaphang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Quanlynhaphang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGRDanhsachphieunhap)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGRDanhsachphieunhap;
        private System.Windows.Forms.TextBox TxtMaPN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbNguoilap;
        private System.Windows.Forms.DateTimePicker DTNgaylap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnTimkiem;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnBaocao;
        private System.Windows.Forms.TextBox TxtNCC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.Button btnChitietpn;
        private System.Windows.Forms.Button BtnHuybo;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button btnLapphieunhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox MtbSDT;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
    }
}