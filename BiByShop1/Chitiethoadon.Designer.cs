namespace BiByShop1
{
    partial class Chitiethoadon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MtbGianhap = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.mtbDongia = new System.Windows.Forms.MaskedTextBox();
            this.mtbSoluong = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTensanpham = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGRDssanpham = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnThem = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnHuybo = new System.Windows.Forms.Button();
            this.BtnInhoadon = new System.Windows.Forms.Button();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtTiendu = new System.Windows.Forms.TextBox();
            this.TxtTienkhach = new System.Windows.Forms.TextBox();
            this.TxtTongtien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.BtnTimkiem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGRDssanpham)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MtbGianhap);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbMaHD);
            this.groupBox1.Controls.Add(this.mtbDongia);
            this.groupBox1.Controls.Add(this.mtbSoluong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtTensanpham);
            this.groupBox1.Location = new System.Drawing.Point(42, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 163);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản phẩm";
            // 
            // MtbGianhap
            // 
            this.MtbGianhap.Location = new System.Drawing.Point(192, 94);
            this.MtbGianhap.Mask = "00000000000";
            this.MtbGianhap.Name = "MtbGianhap";
            this.MtbGianhap.PromptChar = ' ';
            this.MtbGianhap.Size = new System.Drawing.Size(196, 20);
            this.MtbGianhap.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Giá nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mã HD : ";
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Location = new System.Drawing.Point(465, 16);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(22, 13);
            this.lbMaHD.TabIndex = 14;
            this.lbMaHD.Text = "Mã";
            // 
            // mtbDongia
            // 
            this.mtbDongia.Location = new System.Drawing.Point(191, 126);
            this.mtbDongia.Name = "mtbDongia";
            this.mtbDongia.PromptChar = ' ';
            this.mtbDongia.Size = new System.Drawing.Size(196, 20);
            this.mtbDongia.TabIndex = 4;
            // 
            // mtbSoluong
            // 
            this.mtbSoluong.Location = new System.Drawing.Point(192, 60);
            this.mtbSoluong.Mask = "0000";
            this.mtbSoluong.Name = "mtbSoluong";
            this.mtbSoluong.PromptChar = ' ';
            this.mtbSoluong.Size = new System.Drawing.Size(196, 20);
            this.mtbSoluong.TabIndex = 2;
            this.mtbSoluong.TextChanged += new System.EventHandler(this.mtbSoluong_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên sản phẩm";
            // 
            // TxtTensanpham
            // 
            this.TxtTensanpham.Location = new System.Drawing.Point(192, 26);
            this.TxtTensanpham.Name = "TxtTensanpham";
            this.TxtTensanpham.Size = new System.Drawing.Size(196, 20);
            this.TxtTensanpham.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGRDssanpham);
            this.groupBox2.Location = new System.Drawing.Point(42, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 173);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // DGRDssanpham
            // 
            this.DGRDssanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGRDssanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.Soluong,
            this.Dongia,
            this.Thanhtien});
            this.DGRDssanpham.Location = new System.Drawing.Point(17, 19);
            this.DGRDssanpham.Name = "DGRDssanpham";
            this.DGRDssanpham.Size = new System.Drawing.Size(557, 148);
            this.DGRDssanpham.TabIndex = 0;
            this.DGRDssanpham.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGRDssanpham_CellDoubleClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên Sản phẩm";
            this.TenSP.Name = "TenSP";
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.Name = "Soluong";
            // 
            // Dongia
            // 
            this.Dongia.DataPropertyName = "Dongia";
            this.Dongia.HeaderText = "Đơn giá";
            this.Dongia.Name = "Dongia";
            // 
            // Thanhtien
            // 
            this.Thanhtien.DataPropertyName = "Thanhtien";
            this.Thanhtien.HeaderText = "Thành tiền";
            this.Thanhtien.Name = "Thanhtien";
            // 
            // BtnThem
            // 
            this.BtnThem.Location = new System.Drawing.Point(42, 193);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(75, 23);
            this.BtnThem.TabIndex = 11;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.Location = new System.Drawing.Point(148, 193);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(75, 23);
            this.BtnSua.TabIndex = 12;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(256, 192);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(75, 23);
            this.BtnXoa.TabIndex = 13;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnHuybo
            // 
            this.BtnHuybo.Location = new System.Drawing.Point(362, 192);
            this.BtnHuybo.Name = "BtnHuybo";
            this.BtnHuybo.Size = new System.Drawing.Size(75, 23);
            this.BtnHuybo.TabIndex = 14;
            this.BtnHuybo.Text = "Hủy bỏ";
            this.BtnHuybo.UseVisualStyleBackColor = true;
            this.BtnHuybo.Click += new System.EventHandler(this.BtnHuybo_Click);
            // 
            // BtnInhoadon
            // 
            this.BtnInhoadon.Location = new System.Drawing.Point(636, 193);
            this.BtnInhoadon.Name = "BtnInhoadon";
            this.BtnInhoadon.Size = new System.Drawing.Size(75, 23);
            this.BtnInhoadon.TabIndex = 15;
            this.BtnInhoadon.Text = "In hóa đơn";
            this.BtnInhoadon.UseVisualStyleBackColor = true;
            this.BtnInhoadon.Click += new System.EventHandler(this.BtnInhoadon_Click);
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(734, 192);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(61, 23);
            this.BtnThoat.TabIndex = 16;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtTiendu);
            this.groupBox3.Controls.Add(this.TxtTienkhach);
            this.groupBox3.Controls.Add(this.TxtTongtien);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(555, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 163);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thanh toán";
            // 
            // TxtTiendu
            // 
            this.TxtTiendu.Location = new System.Drawing.Point(113, 109);
            this.TxtTiendu.Name = "TxtTiendu";
            this.TxtTiendu.Size = new System.Drawing.Size(126, 20);
            this.TxtTiendu.TabIndex = 7;
            // 
            // TxtTienkhach
            // 
            this.TxtTienkhach.Location = new System.Drawing.Point(113, 69);
            this.TxtTienkhach.Name = "TxtTienkhach";
            this.TxtTienkhach.Size = new System.Drawing.Size(126, 20);
            this.TxtTienkhach.TabIndex = 6;
            this.TxtTienkhach.TextChanged += new System.EventHandler(this.TxtTienkhach_TextChanged);
            // 
            // TxtTongtien
            // 
            this.TxtTongtien.Location = new System.Drawing.Point(113, 26);
            this.TxtTongtien.Name = "TxtTongtien";
            this.TxtTongtien.Size = new System.Drawing.Size(126, 20);
            this.TxtTongtien.TabIndex = 5;
            this.TxtTongtien.TextChanged += new System.EventHandler(this.TxtTongtien_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tiền còn dư";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số tiền khách trả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng tiền";
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Location = new System.Drawing.Point(543, 192);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(75, 23);
            this.btnThanhtoan.TabIndex = 18;
            this.btnThanhtoan.Text = "Thanh toán";
            this.btnThanhtoan.UseVisualStyleBackColor = true;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // BtnTimkiem
            // 
            this.BtnTimkiem.Location = new System.Drawing.Point(454, 192);
            this.BtnTimkiem.Name = "BtnTimkiem";
            this.BtnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.BtnTimkiem.TabIndex = 19;
            this.BtnTimkiem.Text = "Tìm kiếm";
            this.BtnTimkiem.UseVisualStyleBackColor = true;
            this.BtnTimkiem.Click += new System.EventHandler(this.BtnTimkiem_Click);
            // 
            // Chitiethoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 425);
            this.Controls.Add(this.BtnTimkiem);
            this.Controls.Add(this.btnThanhtoan);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.BtnInhoadon);
            this.Controls.Add(this.BtnHuybo);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Chitiethoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chitiethoadon";
            this.Load += new System.EventHandler(this.Chitiethoadon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGRDssanpham)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtbDongia;
        private System.Windows.Forms.MaskedTextBox mtbSoluong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTensanpham;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGRDssanpham;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnHuybo;
        private System.Windows.Forms.Button BtnInhoadon;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtTiendu;
        private System.Windows.Forms.TextBox TxtTienkhach;
        private System.Windows.Forms.TextBox TxtTongtien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.Button BtnTimkiem;
        private System.Windows.Forms.MaskedTextBox MtbGianhap;
        private System.Windows.Forms.Label label8;
    }
}