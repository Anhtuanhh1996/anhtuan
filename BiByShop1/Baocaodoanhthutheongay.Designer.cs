namespace BiByShop1
{
    partial class Baocaodoanhthutheongay
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
            this.CRPBaocaodanhthungay = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.DTNgaybaocao = new System.Windows.Forms.DateTimePicker();
            this.BtnBaocao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CRPBaocaodanhthungay
            // 
            this.CRPBaocaodanhthungay.ActiveViewIndex = -1;
            this.CRPBaocaodanhthungay.AutoSize = true;
            this.CRPBaocaodanhthungay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRPBaocaodanhthungay.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRPBaocaodanhthungay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRPBaocaodanhthungay.Location = new System.Drawing.Point(0, 0);
            this.CRPBaocaodanhthungay.Name = "CRPBaocaodanhthungay";
            this.CRPBaocaodanhthungay.Padding = new System.Windows.Forms.Padding(0, 70, 0, 0);
            this.CRPBaocaodanhthungay.Size = new System.Drawing.Size(1057, 496);
            this.CRPBaocaodanhthungay.TabIndex = 0;
            // 
            // DTNgaybaocao
            // 
            this.DTNgaybaocao.CustomFormat = "";
            this.DTNgaybaocao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTNgaybaocao.Location = new System.Drawing.Point(213, 24);
            this.DTNgaybaocao.Name = "DTNgaybaocao";
            this.DTNgaybaocao.Size = new System.Drawing.Size(161, 20);
            this.DTNgaybaocao.TabIndex = 1;
            // 
            // BtnBaocao
            // 
            this.BtnBaocao.Location = new System.Drawing.Point(408, 22);
            this.BtnBaocao.Name = "BtnBaocao";
            this.BtnBaocao.Size = new System.Drawing.Size(88, 23);
            this.BtnBaocao.TabIndex = 2;
            this.BtnBaocao.Text = "Báo cáo";
            this.BtnBaocao.UseVisualStyleBackColor = true;
            this.BtnBaocao.Click += new System.EventHandler(this.BtnBaocao_Click);
            // 
            // Baocaodoanhthutheongay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1057, 496);
            this.Controls.Add(this.BtnBaocao);
            this.Controls.Add(this.DTNgaybaocao);
            this.Controls.Add(this.CRPBaocaodanhthungay);
            this.Name = "Baocaodoanhthutheongay";
            this.Text = "Baocaodoanhthutheongay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Baocaodoanhthutheongay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRPBaocaodanhthungay;
        private System.Windows.Forms.DateTimePicker DTNgaybaocao;
        private System.Windows.Forms.Button BtnBaocao;
    }
}