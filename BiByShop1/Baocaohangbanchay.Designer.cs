namespace BiByShop1
{
    partial class Baocaohangbanchay
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
            this.CRVBaocaohangbanchay = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.DTNgaybaocao = new System.Windows.Forms.DateTimePicker();
            this.BtnBaocao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CRVBaocaohangbanchay
            // 
            this.CRVBaocaohangbanchay.ActiveViewIndex = -1;
            this.CRVBaocaohangbanchay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVBaocaohangbanchay.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRVBaocaohangbanchay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRVBaocaohangbanchay.Location = new System.Drawing.Point(0, 0);
            this.CRVBaocaohangbanchay.Name = "CRVBaocaohangbanchay";
            this.CRVBaocaohangbanchay.Padding = new System.Windows.Forms.Padding(0, 70, 0, 0);
            this.CRVBaocaohangbanchay.Size = new System.Drawing.Size(854, 335);
            this.CRVBaocaohangbanchay.TabIndex = 0;
            // 
            // DTNgaybaocao
            // 
            this.DTNgaybaocao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTNgaybaocao.Location = new System.Drawing.Point(218, 25);
            this.DTNgaybaocao.Name = "DTNgaybaocao";
            this.DTNgaybaocao.Size = new System.Drawing.Size(200, 20);
            this.DTNgaybaocao.TabIndex = 1;
            // 
            // BtnBaocao
            // 
            this.BtnBaocao.Location = new System.Drawing.Point(448, 22);
            this.BtnBaocao.Name = "BtnBaocao";
            this.BtnBaocao.Size = new System.Drawing.Size(75, 23);
            this.BtnBaocao.TabIndex = 2;
            this.BtnBaocao.Text = "Báo cáo";
            this.BtnBaocao.UseVisualStyleBackColor = true;
            this.BtnBaocao.Click += new System.EventHandler(this.BtnBaocao_Click);
            // 
            // Baocaohangbanchay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 335);
            this.Controls.Add(this.BtnBaocao);
            this.Controls.Add(this.DTNgaybaocao);
            this.Controls.Add(this.CRVBaocaohangbanchay);
            this.Name = "Baocaohangbanchay";
            this.Text = "Baocaohangbanchay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Baocaohangbanchay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRVBaocaohangbanchay;
        private System.Windows.Forms.DateTimePicker DTNgaybaocao;
        private System.Windows.Forms.Button BtnBaocao;
    }
}