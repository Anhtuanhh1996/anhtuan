namespace BiByShop1
{
    partial class Baocaopn
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
            this.CRVPhieunhap = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRVPhieunhap
            // 
            this.CRVPhieunhap.ActiveViewIndex = -1;
            this.CRVPhieunhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVPhieunhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRVPhieunhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRVPhieunhap.Location = new System.Drawing.Point(0, 0);
            this.CRVPhieunhap.Name = "CRVPhieunhap";
            this.CRVPhieunhap.Size = new System.Drawing.Size(834, 261);
            this.CRVPhieunhap.TabIndex = 0;
            // 
            // Baocaopn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 261);
            this.Controls.Add(this.CRVPhieunhap);
            this.Name = "Baocaopn";
            this.Text = "Baocaopn";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRVPhieunhap;
    }
}