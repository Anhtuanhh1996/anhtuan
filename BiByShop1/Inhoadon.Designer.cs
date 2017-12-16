namespace BiByShop1
{
    partial class Inhoadon
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
            this.CRVInhoadon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRVInhoadon
            // 
            this.CRVInhoadon.ActiveViewIndex = -1;
            this.CRVInhoadon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRVInhoadon.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRVInhoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRVInhoadon.Location = new System.Drawing.Point(0, 0);
            this.CRVInhoadon.Name = "CRVInhoadon";
            this.CRVInhoadon.Size = new System.Drawing.Size(759, 261);
            this.CRVInhoadon.TabIndex = 0;
            // 
            // Inhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 261);
            this.Controls.Add(this.CRVInhoadon);
            this.Name = "Inhoadon";
            this.Text = "Inhoadon";
            this.Load += new System.EventHandler(this.Inhoadon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRVInhoadon;
    }
}