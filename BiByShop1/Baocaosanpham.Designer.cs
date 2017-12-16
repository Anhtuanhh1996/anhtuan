namespace BiByShop1
{
    partial class Baocaosanpham
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
            this.CRVSanpham = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRVSanpham
            // 
            this.CRVSanpham.ActiveViewIndex = -1;
            this.CRVSanpham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVSanpham.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRVSanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRVSanpham.Location = new System.Drawing.Point(0, 0);
            this.CRVSanpham.Name = "CRVSanpham";
            this.CRVSanpham.Size = new System.Drawing.Size(768, 319);
            this.CRVSanpham.TabIndex = 0;
            // 
            // Baocaosanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 319);
            this.Controls.Add(this.CRVSanpham);
            this.Name = "Baocaosanpham";
            this.Text = "Baocaosanpham";
            this.Load += new System.EventHandler(this.Baocaosanpham_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRVSanpham;
    }
}