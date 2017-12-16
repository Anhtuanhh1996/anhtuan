namespace BiByShop1
{
    partial class Baocaohangton
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
            this.CRVBaocaohangton = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRVBaocaohangton
            // 
            this.CRVBaocaohangton.ActiveViewIndex = -1;
            this.CRVBaocaohangton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVBaocaohangton.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRVBaocaohangton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRVBaocaohangton.Location = new System.Drawing.Point(0, 0);
            this.CRVBaocaohangton.Name = "CRVBaocaohangton";
            this.CRVBaocaohangton.Size = new System.Drawing.Size(284, 261);
            this.CRVBaocaohangton.TabIndex = 0;
            // 
            // Baocaohangton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CRVBaocaohangton);
            this.Name = "Baocaohangton";
            this.Text = "Baocaohangton";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Baocaohangton_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRVBaocaohangton;
    }
}