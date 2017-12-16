namespace BiByShop1
{
    partial class Timkiem
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
            this.TxtTimkiem = new System.Windows.Forms.TextBox();
            this.BtnTimkiem = new System.Windows.Forms.Button();
            this.DGRTimkiem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGRTimkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtTimkiem
            // 
            this.TxtTimkiem.Location = new System.Drawing.Point(216, 22);
            this.TxtTimkiem.Name = "TxtTimkiem";
            this.TxtTimkiem.Size = new System.Drawing.Size(196, 20);
            this.TxtTimkiem.TabIndex = 0;
            // 
            // BtnTimkiem
            // 
            this.BtnTimkiem.Location = new System.Drawing.Point(450, 20);
            this.BtnTimkiem.Name = "BtnTimkiem";
            this.BtnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.BtnTimkiem.TabIndex = 1;
            this.BtnTimkiem.Text = "Tìm kiếm";
            this.BtnTimkiem.UseVisualStyleBackColor = true;
            this.BtnTimkiem.Click += new System.EventHandler(this.BtnTimkiem_Click);
            // 
            // DGRTimkiem
            // 
            this.DGRTimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGRTimkiem.Location = new System.Drawing.Point(67, 97);
            this.DGRTimkiem.Name = "DGRTimkiem";
            this.DGRTimkiem.Size = new System.Drawing.Size(713, 266);
            this.DGRTimkiem.TabIndex = 2;
            // 
            // Timkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 401);
            this.Controls.Add(this.DGRTimkiem);
            this.Controls.Add(this.BtnTimkiem);
            this.Controls.Add(this.TxtTimkiem);
            this.Name = "Timkiem";
            this.Text = "Timkiem";
            ((System.ComponentModel.ISupportInitialize)(this.DGRTimkiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTimkiem;
        private System.Windows.Forms.Button BtnTimkiem;
        private System.Windows.Forms.DataGridView DGRTimkiem;
    }
}