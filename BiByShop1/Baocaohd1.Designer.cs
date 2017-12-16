namespace BiByShop1
{
    partial class Baocaohd1
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
            this.CRVBaocaohd = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRVBaocaohd
            // 
            this.CRVBaocaohd.ActiveViewIndex = -1;
            this.CRVBaocaohd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVBaocaohd.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRVBaocaohd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRVBaocaohd.Location = new System.Drawing.Point(0, 0);
            this.CRVBaocaohd.Name = "CRVBaocaohd";
            this.CRVBaocaohd.Size = new System.Drawing.Size(779, 284);
            this.CRVBaocaohd.TabIndex = 0;
            // 
            // Baocaohd1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 284);
            this.Controls.Add(this.CRVBaocaohd);
            this.Name = "Baocaohd1";
            this.Text = "Baocaohd1";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRVBaocaohd;
    }
}