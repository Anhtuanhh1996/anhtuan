namespace BiByShop1
{
    partial class BaocaoKH
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
            this.CRVBaocaoKH = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.DTThoigian = new System.Windows.Forms.DateTimePicker();
            this.BtnBaocao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CRVBaocaoKH
            // 
            this.CRVBaocaoKH.ActiveViewIndex = -1;
            this.CRVBaocaoKH.AutoSize = true;
            this.CRVBaocaoKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVBaocaoKH.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRVBaocaoKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRVBaocaoKH.Location = new System.Drawing.Point(0, 0);
            this.CRVBaocaoKH.Name = "CRVBaocaoKH";
            this.CRVBaocaoKH.Padding = new System.Windows.Forms.Padding(0, 70, 0, 0);
            this.CRVBaocaoKH.Size = new System.Drawing.Size(1057, 496);
            this.CRVBaocaoKH.TabIndex = 1;
            // 
            // DTThoigian
            // 
            this.DTThoigian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTThoigian.Location = new System.Drawing.Point(233, 22);
            this.DTThoigian.Name = "DTThoigian";
            this.DTThoigian.Size = new System.Drawing.Size(200, 20);
            this.DTThoigian.TabIndex = 2;
            // 
            // BtnBaocao
            // 
            this.BtnBaocao.Location = new System.Drawing.Point(461, 18);
            this.BtnBaocao.Name = "BtnBaocao";
            this.BtnBaocao.Size = new System.Drawing.Size(75, 23);
            this.BtnBaocao.TabIndex = 3;
            this.BtnBaocao.Text = "button1";
            this.BtnBaocao.UseVisualStyleBackColor = true;
            this.BtnBaocao.Click += new System.EventHandler(this.BtnBaocao_Click);
            // 
            // BaocaoKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 496);
            this.Controls.Add(this.BtnBaocao);
            this.Controls.Add(this.DTThoigian);
            this.Controls.Add(this.CRVBaocaoKH);
            this.Name = "BaocaoKH";
            this.Text = "BaocaoKH";
            this.Load += new System.EventHandler(this.BaocaoKH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRVBaocaoKH;
        private System.Windows.Forms.DateTimePicker DTThoigian;
        private System.Windows.Forms.Button BtnBaocao;
    }
}