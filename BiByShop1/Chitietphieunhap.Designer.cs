namespace BiByShop1
{
    partial class Chitietphieunhap
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
            this.BtnTimkiem = new System.Windows.Forms.Button();
            this.TxtGiaban = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CbLoaisp = new System.Windows.Forms.ComboBox();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.BtnInphieunhap = new System.Windows.Forms.Button();
            this.BtnHuybo = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.BtnThem = new System.Windows.Forms.Button();
            this.DGRDsanphamnhap = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluongnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMaPN = new System.Windows.Forms.Label();
            this.mtbGianhap = new System.Windows.Forms.MaskedTextBox();
            this.mtbSoluong = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTensanpham = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGRDsanphamnhap)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnTimkiem
            // 
            this.BtnTimkiem.Location = new System.Drawing.Point(504, 151);
            this.BtnTimkiem.Name = "BtnTimkiem";
            this.BtnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.BtnTimkiem.TabIndex = 30;
            this.BtnTimkiem.Text = "Tìm kiếm";
            this.BtnTimkiem.UseVisualStyleBackColor = true;
            this.BtnTimkiem.Click += new System.EventHandler(this.BtnTimkiem_Click);
            // 
            // TxtGiaban
            // 
            this.TxtGiaban.Location = new System.Drawing.Point(114, 73);
            this.TxtGiaban.Name = "TxtGiaban";
            this.TxtGiaban.Size = new System.Drawing.Size(153, 20);
            this.TxtGiaban.TabIndex = 5;
            this.TxtGiaban.TextChanged += new System.EventHandler(this.TxtGiaban_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Giá bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Loại sản phẩm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtGiaban);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.mtbGianhap);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(488, -12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 147);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thanh toán";
            // 
            // CbLoaisp
            // 
            this.CbLoaisp.FormattingEnabled = true;
            this.CbLoaisp.Location = new System.Drawing.Point(143, 104);
            this.CbLoaisp.Name = "CbLoaisp";
            this.CbLoaisp.Size = new System.Drawing.Size(196, 21);
            this.CbLoaisp.TabIndex = 3;
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(728, 150);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(61, 23);
            this.BtnThoat.TabIndex = 27;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // BtnInphieunhap
            // 
            this.BtnInphieunhap.Location = new System.Drawing.Point(624, 151);
            this.BtnInphieunhap.Name = "BtnInphieunhap";
            this.BtnInphieunhap.Size = new System.Drawing.Size(81, 23);
            this.BtnInphieunhap.TabIndex = 26;
            this.BtnInphieunhap.Text = "In phiếu nhập";
            this.BtnInphieunhap.UseVisualStyleBackColor = true;
            this.BtnInphieunhap.Click += new System.EventHandler(this.BtnInphieunhap_Click);
            // 
            // BtnHuybo
            // 
            this.BtnHuybo.Location = new System.Drawing.Point(369, 150);
            this.BtnHuybo.Name = "BtnHuybo";
            this.BtnHuybo.Size = new System.Drawing.Size(75, 23);
            this.BtnHuybo.TabIndex = 25;
            this.BtnHuybo.Text = "Hủy bỏ";
            this.BtnHuybo.UseVisualStyleBackColor = true;
            this.BtnHuybo.Click += new System.EventHandler(this.BtnHuybo_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(250, 150);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(75, 23);
            this.BtnXoa.TabIndex = 24;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.Location = new System.Drawing.Point(142, 151);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(75, 23);
            this.BtnSua.TabIndex = 23;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.Location = new System.Drawing.Point(36, 151);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(75, 23);
            this.BtnThem.TabIndex = 22;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // DGRDsanphamnhap
            // 
            this.DGRDsanphamnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGRDsanphamnhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.Soluongnhap,
            this.Gianhap,
            this.Thanhtien});
            this.DGRDsanphamnhap.Location = new System.Drawing.Point(17, 19);
            this.DGRDsanphamnhap.Name = "DGRDsanphamnhap";
            this.DGRDsanphamnhap.Size = new System.Drawing.Size(557, 147);
            this.DGRDsanphamnhap.TabIndex = 0;
            this.DGRDsanphamnhap.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGRDsanphamnhap_CellDoubleClick);
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
            // Soluongnhap
            // 
            this.Soluongnhap.DataPropertyName = "Soluong";
            this.Soluongnhap.HeaderText = "Số lượng nhập";
            this.Soluongnhap.Name = "Soluongnhap";
            // 
            // Gianhap
            // 
            this.Gianhap.DataPropertyName = "Gianhap";
            this.Gianhap.HeaderText = "Giá nhập";
            this.Gianhap.Name = "Gianhap";
            // 
            // Thanhtien
            // 
            this.Thanhtien.DataPropertyName = "Thanhtien";
            this.Thanhtien.HeaderText = "Thành tiền";
            this.Thanhtien.Name = "Thanhtien";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGRDsanphamnhap);
            this.groupBox2.Location = new System.Drawing.Point(36, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 172);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mã PN : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbMaPN
            // 
            this.lbMaPN.AutoSize = true;
            this.lbMaPN.Location = new System.Drawing.Point(412, 16);
            this.lbMaPN.Name = "lbMaPN";
            this.lbMaPN.Size = new System.Drawing.Size(22, 13);
            this.lbMaPN.TabIndex = 14;
            this.lbMaPN.Text = "Mã";
            // 
            // mtbGianhap
            // 
            this.mtbGianhap.Location = new System.Drawing.Point(113, 32);
            this.mtbGianhap.Name = "mtbGianhap";
            this.mtbGianhap.PromptChar = ' ';
            this.mtbGianhap.Size = new System.Drawing.Size(154, 20);
            this.mtbGianhap.TabIndex = 4;
            this.mtbGianhap.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbGianhap_MaskInputRejected);
            // 
            // mtbSoluong
            // 
            this.mtbSoluong.Location = new System.Drawing.Point(143, 69);
            this.mtbSoluong.Mask = "0000";
            this.mtbSoluong.Name = "mtbSoluong";
            this.mtbSoluong.PromptChar = ' ';
            this.mtbSoluong.Size = new System.Drawing.Size(196, 20);
            this.mtbSoluong.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Giá nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số lượng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên sản phẩm";
            // 
            // TxtTensanpham
            // 
            this.TxtTensanpham.Location = new System.Drawing.Point(143, 26);
            this.TxtTensanpham.Name = "TxtTensanpham";
            this.TxtTensanpham.Size = new System.Drawing.Size(196, 20);
            this.TxtTensanpham.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbLoaisp);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbMaPN);
            this.groupBox1.Controls.Add(this.mtbSoluong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtTensanpham);
            this.groupBox1.Location = new System.Drawing.Point(36, -12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 147);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản phẩm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(345, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "(*)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(345, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "(*)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "(*)";
            // 
            // Chitietphieunhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 400);
            this.Controls.Add(this.BtnTimkiem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.BtnInphieunhap);
            this.Controls.Add(this.BtnHuybo);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Chitietphieunhap";
            this.Text = "Chitietphieunhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Chitietphieunhap_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGRDsanphamnhap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTimkiem;
        private System.Windows.Forms.TextBox TxtGiaban;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.Button BtnInphieunhap;
        private System.Windows.Forms.Button BtnHuybo;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.DataGridView DGRDsanphamnhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMaPN;
        private System.Windows.Forms.MaskedTextBox mtbGianhap;
        private System.Windows.Forms.MaskedTextBox mtbSoluong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTensanpham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbLoaisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluongnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}