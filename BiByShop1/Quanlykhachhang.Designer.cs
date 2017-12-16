namespace BiByShop1
{
    partial class Quanlykhachhang
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
            this.BtnThoat = new System.Windows.Forms.Button();
            this.BtnBaocao = new System.Windows.Forms.Button();
            this.BtnTimkiem = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.BtnThem = new System.Windows.Forms.Button();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGRDanhsachkhachhang = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RBGioitinh2 = new System.Windows.Forms.RadioButton();
            this.RBGioitinh1 = new System.Windows.Forms.RadioButton();
            this.MtbSDT = new System.Windows.Forms.MaskedTextBox();
            this.TxtDiachi = new System.Windows.Forms.TextBox();
            this.TxtTenKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnHuybo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGRDanhsachkhachhang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(741, 155);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(75, 23);
            this.BtnThoat.TabIndex = 17;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // BtnBaocao
            // 
            this.BtnBaocao.Location = new System.Drawing.Point(536, 155);
            this.BtnBaocao.Name = "BtnBaocao";
            this.BtnBaocao.Size = new System.Drawing.Size(75, 23);
            this.BtnBaocao.TabIndex = 15;
            this.BtnBaocao.Text = "Báo cáo";
            this.BtnBaocao.UseVisualStyleBackColor = true;
            this.BtnBaocao.Click += new System.EventHandler(this.BtnBaocao_Click);
            // 
            // BtnTimkiem
            // 
            this.BtnTimkiem.Location = new System.Drawing.Point(415, 156);
            this.BtnTimkiem.Name = "BtnTimkiem";
            this.BtnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.BtnTimkiem.TabIndex = 14;
            this.BtnTimkiem.Text = "Tìm kiếm";
            this.BtnTimkiem.UseVisualStyleBackColor = true;
            this.BtnTimkiem.Click += new System.EventHandler(this.BtnTimkiem_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(294, 155);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(75, 23);
            this.BtnXoa.TabIndex = 13;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.Location = new System.Drawing.Point(182, 155);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(75, 23);
            this.BtnSua.TabIndex = 12;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.Location = new System.Drawing.Point(56, 156);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(75, 23);
            this.BtnThem.TabIndex = 11;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "Diachi";
            this.Diachi.HeaderText = "Địa chỉ";
            this.Diachi.Name = "Diachi";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            // 
            // Gioitinh
            // 
            this.Gioitinh.DataPropertyName = "Gioitinh";
            this.Gioitinh.HeaderText = "Giới tính";
            this.Gioitinh.Name = "Gioitinh";
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.Name = "TenKH";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.Name = "MaKH";
            // 
            // DGRDanhsachkhachhang
            // 
            this.DGRDanhsachkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGRDanhsachkhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.Gioitinh,
            this.SDT,
            this.Diachi});
            this.DGRDanhsachkhachhang.Location = new System.Drawing.Point(102, 28);
            this.DGRDanhsachkhachhang.Name = "DGRDanhsachkhachhang";
            this.DGRDanhsachkhachhang.Size = new System.Drawing.Size(602, 150);
            this.DGRDanhsachkhachhang.TabIndex = 0;
            this.DGRDanhsachkhachhang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGRDanhsachkhachhang_CellDoubleClick);
            this.DGRDanhsachkhachhang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGRDanhsachkhachhang_CellFormatting);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGRDanhsachkhachhang);
            this.groupBox2.Location = new System.Drawing.Point(43, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(799, 178);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // RBGioitinh2
            // 
            this.RBGioitinh2.AutoSize = true;
            this.RBGioitinh2.Location = new System.Drawing.Point(590, 60);
            this.RBGioitinh2.Name = "RBGioitinh2";
            this.RBGioitinh2.Size = new System.Drawing.Size(39, 17);
            this.RBGioitinh2.TabIndex = 10;
            this.RBGioitinh2.TabStop = true;
            this.RBGioitinh2.Text = "Nữ";
            this.RBGioitinh2.UseVisualStyleBackColor = true;
            // 
            // RBGioitinh1
            // 
            this.RBGioitinh1.AutoSize = true;
            this.RBGioitinh1.Location = new System.Drawing.Point(521, 60);
            this.RBGioitinh1.Name = "RBGioitinh1";
            this.RBGioitinh1.Size = new System.Drawing.Size(47, 17);
            this.RBGioitinh1.TabIndex = 9;
            this.RBGioitinh1.TabStop = true;
            this.RBGioitinh1.Text = "Nam";
            this.RBGioitinh1.UseVisualStyleBackColor = true;
            // 
            // MtbSDT
            // 
            this.MtbSDT.Location = new System.Drawing.Point(521, 19);
            this.MtbSDT.Mask = "00000000000";
            this.MtbSDT.Name = "MtbSDT";
            this.MtbSDT.Size = new System.Drawing.Size(252, 20);
            this.MtbSDT.TabIndex = 8;
            // 
            // TxtDiachi
            // 
            this.TxtDiachi.Location = new System.Drawing.Point(139, 62);
            this.TxtDiachi.Name = "TxtDiachi";
            this.TxtDiachi.Size = new System.Drawing.Size(243, 20);
            this.TxtDiachi.TabIndex = 7;
            // 
            // TxtTenKH
            // 
            this.TxtTenKH.Location = new System.Drawing.Point(139, 17);
            this.TxtTenKH.Name = "TxtTenKH";
            this.TxtTenKH.Size = new System.Drawing.Size(243, 20);
            this.TxtTenKH.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
            // 
            // BtnHuybo
            // 
            this.BtnHuybo.Location = new System.Drawing.Point(648, 155);
            this.BtnHuybo.Name = "BtnHuybo";
            this.BtnHuybo.Size = new System.Drawing.Size(75, 23);
            this.BtnHuybo.TabIndex = 16;
            this.BtnHuybo.Text = "Hủy bỏ";
            this.BtnHuybo.UseVisualStyleBackColor = true;
            this.BtnHuybo.Click += new System.EventHandler(this.BtnHuybo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBGioitinh2);
            this.groupBox1.Controls.Add(this.RBGioitinh1);
            this.groupBox1.Controls.Add(this.MtbSDT);
            this.groupBox1.Controls.Add(this.TxtDiachi);
            this.groupBox1.Controls.Add(this.TxtTenKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(43, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 128);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // Quanlykhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 401);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.BtnBaocao);
            this.Controls.Add(this.BtnTimkiem);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnHuybo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Quanlykhachhang";
            this.Text = "Quanlykhachhang";
            this.Load += new System.EventHandler(this.Quanlykhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGRDanhsachkhachhang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.Button BtnBaocao;
        private System.Windows.Forms.Button BtnTimkiem;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridView DGRDanhsachkhachhang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RBGioitinh2;
        private System.Windows.Forms.RadioButton RBGioitinh1;
        private System.Windows.Forms.MaskedTextBox MtbSDT;
        private System.Windows.Forms.TextBox TxtDiachi;
        private System.Windows.Forms.TextBox TxtTenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnHuybo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}