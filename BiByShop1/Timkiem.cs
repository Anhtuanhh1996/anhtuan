using Business_logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiByShop1
{
    public partial class Timkiem : Form
    {
        public Timkiem()
        {
            InitializeComponent();
        }
        TIMKIEM tk = new TIMKIEM();
        private void BtnTimkiem_Click(object sender, EventArgs e)
        {
            if (TxtTimkiem.Text == "")
            {
                MessageBox.Show("Mời nhập dữ liệu để Tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtTimkiem.Focus();
            }
            else
            {
                if(tk.dt1(TxtTimkiem.Text).Rows.Count > 0)
                {
                    
                    
                    DGRTimkiem.DataSource = tk.dt1(TxtTimkiem.Text);
                }
                else
                {
                    if (tk.dt2(TxtTimkiem.Text).Rows.Count > 0)
                    {
                        DGRTimkiem.DataSource = tk.dt2(TxtTimkiem.Text);
                    }
                    else
                    {
                        if (tk.dt3(TxtTimkiem.Text).Rows.Count > 0)
                        {
                            DGRTimkiem.DataSource = tk.dt3(TxtTimkiem.Text);
                        }
                        else
                        {
                            MessageBox.Show("không tìm được");
                        }
                    }
                }
               
            }
        }
    }
}
