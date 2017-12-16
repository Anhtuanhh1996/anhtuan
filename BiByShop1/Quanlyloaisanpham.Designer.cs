namespace BiByShop1
{
    partial class Quanlyloaisanpham
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
            this.TxtTenLSP = new System.Windows.Forms.TextBox();
            this.TxtMaLSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGRLoaiSP = new System.Windows.Forms.DataGridView();
            this.MaLSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.BtnHuybo = new System.Windows.Forms.Button();
            this.BtnBaocao = new System.Windows.Forms.Button();
            this.BtnTimkiem = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.BtnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGRLoaiSP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtTenLSP);
            this.groupBox1.Controls.Add(this.TxtMaLSP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 92);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // TxtTenLSP
            // 
            this.TxtTenLSP.Location = new System.Drawing.Point(505, 37);
            this.TxtTenLSP.Name = "TxtTenLSP";
            this.TxtTenLSP.Size = new System.Drawing.Size(220, 20);
            this.TxtTenLSP.TabIndex = 3;
            // 
            // TxtMaLSP
            // 
            this.TxtMaLSP.Location = new System.Drawing.Point(163, 37);
            this.TxtMaLSP.Name = "TxtMaLSP";
            this.TxtMaLSP.Size = new System.Drawing.Size(201, 20);
            this.TxtMaLSP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGRLoaiSP);
            this.groupBox2.Location = new System.Drawing.Point(39, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(746, 141);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách loại sản phẩm";
            // 
            // DGRLoaiSP
            // 
            this.DGRLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGRLoaiSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLSP,
            this.TenLSP});
            this.DGRLoaiSP.Location = new System.Drawing.Point(102, 19);
            this.DGRLoaiSP.Name = "DGRLoaiSP";
            this.DGRLoaiSP.Size = new System.Drawing.Size(540, 102);
            this.DGRLoaiSP.TabIndex = 0;
            this.DGRLoaiSP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGRLoaiSP_CellDoubleClick);
            // 
            // MaLSP
            // 
            this.MaLSP.DataPropertyName = "MaLSP";
            this.MaLSP.HeaderText = "Mã loại sản phẩm";
            this.MaLSP.Name = "MaLSP";
            // 
            // TenLSP
            // 
            this.TenLSP.DataPropertyName = "TenLSP";
            this.TenLSP.HeaderText = "Tên loại sản phẩm";
            this.TenLSP.Name = "TenLSP";
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(700, 127);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(75, 23);
            this.BtnThoat.TabIndex = 16;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            // 
            // BtnHuybo
            // 
            this.BtnHuybo.Location = new System.Drawing.Point(606, 127);
            this.BtnHuybo.Name = "BtnHuybo";
            this.BtnHuybo.Size = new System.Drawing.Size(75, 23);
            this.BtnHuybo.TabIndex = 15;
            this.BtnHuybo.Text = "Hủy bỏ";
            this.BtnHuybo.UseVisualStyleBackColor = true;
            this.BtnHuybo.Click += new System.EventHandler(this.BtnHuybo_Click);
            // 
            // BtnBaocao
            // 
            this.BtnBaocao.Location = new System.Drawing.Point(498, 127);
            this.BtnBaocao.Name = "BtnBaocao";
            this.BtnBaocao.Size = new System.Drawing.Size(75, 23);
            this.BtnBaocao.TabIndex = 14;
            this.BtnBaocao.Text = "Báo cáo";
            this.BtnBaocao.UseVisualStyleBackColor = true;
            // 
            // BtnTimkiem
            // 
            this.BtnTimkiem.Location = new System.Drawing.Point(388, 127);
            this.BtnTimkiem.Name = "BtnTimkiem";
            this.BtnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.BtnTimkiem.TabIndex = 13;
            this.BtnTimkiem.Text = "Tìm kiếm";
            this.BtnTimkiem.UseVisualStyleBackColor = true;
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(267, 127);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(75, 23);
            this.BtnXoa.TabIndex = 12;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            // 
            // BtnSua
            // 
            this.BtnSua.Location = new System.Drawing.Point(151, 127);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(75, 23);
            this.BtnSua.TabIndex = 11;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            // 
            // BtnThem
            // 
            this.BtnThem.Location = new System.Drawing.Point(52, 127);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(75, 23);
            this.BtnThem.TabIndex = 10;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // Quanlyloaisanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 339);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.BtnHuybo);
            this.Controls.Add(this.BtnBaocao);
            this.Controls.Add(this.BtnTimkiem);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.BtnThem);
            this.Name = "Quanlyloaisanpham";
            this.Text = "Quanlyloaisanpham";
            this.Load += new System.EventHandler(this.Quanlyloaisanpham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGRLoaiSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtTenLSP;
        private System.Windows.Forms.TextBox TxtMaLSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGRLoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLSP;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.Button BtnHuybo;
        private System.Windows.Forms.Button BtnBaocao;
        private System.Windows.Forms.Button BtnTimkiem;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnThem;
    }
}