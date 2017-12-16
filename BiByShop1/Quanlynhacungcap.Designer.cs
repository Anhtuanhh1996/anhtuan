namespace BiByShop1
{
    partial class Quanlynhacungcap
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
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGRDanhsachnhacungcap = new System.Windows.Forms.DataGridView();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.BtnHuybo = new System.Windows.Forms.Button();
            this.BtnBaocao = new System.Windows.Forms.Button();
            this.BtnTimkiem = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnThem = new System.Windows.Forms.Button();
            this.MtbEmail = new System.Windows.Forms.MaskedTextBox();
            this.MtbSDT = new System.Windows.Forms.MaskedTextBox();
            this.TxtDiachi = new System.Windows.Forms.TextBox();
            this.TxtTenNCC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGRDanhsachnhacungcap)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "Diachi";
            this.Diachi.HeaderText = "Địa chỉ";
            this.Diachi.Name = "Diachi";
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên NCC";
            this.TenNCC.Name = "TenNCC";
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.Name = "MaNCC";
            // 
            // DGRDanhsachnhacungcap
            // 
            this.DGRDanhsachnhacungcap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGRDanhsachnhacungcap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.Diachi,
            this.SDT,
            this.Email});
            this.DGRDanhsachnhacungcap.Location = new System.Drawing.Point(6, 19);
            this.DGRDanhsachnhacungcap.Name = "DGRDanhsachnhacungcap";
            this.DGRDanhsachnhacungcap.Size = new System.Drawing.Size(788, 150);
            this.DGRDanhsachnhacungcap.TabIndex = 0;
            this.DGRDanhsachnhacungcap.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGRDanhsachnhacungcap_CellDoubleClick);
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGRDanhsachnhacungcap);
            this.groupBox2.Location = new System.Drawing.Point(13, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(817, 160);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhà cung cấp";
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(732, 143);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(75, 23);
            this.BtnThoat.TabIndex = 16;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            // 
            // BtnHuybo
            // 
            this.BtnHuybo.Location = new System.Drawing.Point(611, 142);
            this.BtnHuybo.Name = "BtnHuybo";
            this.BtnHuybo.Size = new System.Drawing.Size(75, 23);
            this.BtnHuybo.TabIndex = 15;
            this.BtnHuybo.Text = "Hủy bỏ";
            this.BtnHuybo.UseVisualStyleBackColor = true;
            this.BtnHuybo.Click += new System.EventHandler(this.BtnHuybo_Click);
            // 
            // BtnBaocao
            // 
            this.BtnBaocao.Location = new System.Drawing.Point(499, 144);
            this.BtnBaocao.Name = "BtnBaocao";
            this.BtnBaocao.Size = new System.Drawing.Size(75, 23);
            this.BtnBaocao.TabIndex = 14;
            this.BtnBaocao.Text = "Báo cáo";
            this.BtnBaocao.UseVisualStyleBackColor = true;
            // 
            // BtnTimkiem
            // 
            this.BtnTimkiem.Location = new System.Drawing.Point(369, 143);
            this.BtnTimkiem.Name = "BtnTimkiem";
            this.BtnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.BtnTimkiem.TabIndex = 13;
            this.BtnTimkiem.Text = "Tìm kiếm";
            this.BtnTimkiem.UseVisualStyleBackColor = true;
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(252, 142);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(75, 23);
            this.BtnXoa.TabIndex = 12;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            // 
            // BtnThem
            // 
            this.BtnThem.Location = new System.Drawing.Point(29, 144);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(75, 23);
            this.BtnThem.TabIndex = 10;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // MtbEmail
            // 
            this.MtbEmail.Location = new System.Drawing.Point(543, 61);
            this.MtbEmail.Name = "MtbEmail";
            this.MtbEmail.Size = new System.Drawing.Size(174, 20);
            this.MtbEmail.TabIndex = 9;
            // 
            // MtbSDT
            // 
            this.MtbSDT.Location = new System.Drawing.Point(543, 18);
            this.MtbSDT.Mask = "00000000000";
            this.MtbSDT.Name = "MtbSDT";
            this.MtbSDT.Size = new System.Drawing.Size(174, 20);
            this.MtbSDT.TabIndex = 8;
            // 
            // TxtDiachi
            // 
            this.TxtDiachi.Location = new System.Drawing.Point(146, 65);
            this.TxtDiachi.Name = "TxtDiachi";
            this.TxtDiachi.Size = new System.Drawing.Size(228, 20);
            this.TxtDiachi.TabIndex = 7;
            // 
            // TxtTenNCC
            // 
            this.TxtTenNCC.Location = new System.Drawing.Point(146, 19);
            this.TxtTenNCC.Name = "TxtTenNCC";
            this.TxtTenNCC.Size = new System.Drawing.Size(228, 20);
            this.TxtTenNCC.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // BtnSua
            // 
            this.BtnSua.Location = new System.Drawing.Point(149, 143);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(75, 23);
            this.BtnSua.TabIndex = 11;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MtbEmail);
            this.groupBox1.Controls.Add(this.MtbSDT);
            this.groupBox1.Controls.Add(this.TxtDiachi);
            this.groupBox1.Controls.Add(this.TxtTenNCC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 114);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(723, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "(*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(723, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "(*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "(*)";
            // 
            // Quanlynhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 375);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.BtnHuybo);
            this.Controls.Add(this.BtnBaocao);
            this.Controls.Add(this.BtnTimkiem);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.groupBox1);
            this.Name = "Quanlynhacungcap";
            this.Text = "Quanlynhacungcap";
            this.Load += new System.EventHandler(this.Quanlynhacungcap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGRDanhsachnhacungcap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridView DGRDanhsachnhacungcap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.Button BtnHuybo;
        private System.Windows.Forms.Button BtnBaocao;
        private System.Windows.Forms.Button BtnTimkiem;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.MaskedTextBox MtbEmail;
        private System.Windows.Forms.MaskedTextBox MtbSDT;
        private System.Windows.Forms.TextBox TxtDiachi;
        private System.Windows.Forms.TextBox TxtTenNCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}