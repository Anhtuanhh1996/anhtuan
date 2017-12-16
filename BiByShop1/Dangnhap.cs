using Business_logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiByShop1
{
    public partial class Dangnhap : Form
    {
        
        public Dangnhap()
        {
            InitializeComponent();
         }
        public static string TenQ = "";
        public static string TenTK = "";
        public static string NVKho = "";
        TAIKHOAN TK = new TAIKHOAN();
        String connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {

                System.Windows.Forms.Application.Exit();
            }
            

        }

        private void tbnDangnhap_Click(object sender, EventArgs e)
        {
            DataTable dt = TK.getTenQ(txtTaikhoan.Text,txtMatkhau.Text);
            
                if (dt.Rows.Count == 1)
                {
                    TenTK = TK.getTenTK(txtTaikhoan.Text, txtMatkhau.Text);
                    this.MdiParent.Hide();
                    this.Hide();
                    TenQ = dt.Rows[0][0].ToString();
                Trangchu tt = new Trangchu();
                 tt.Show();
                //if(dt.Rows[0][0].ToString() == "Admin")
                //    {

                //    Trangchu tt = new Trangchu();
                //    tt.Show();
                //    }
                //if (dt.Rows[0][0].ToString() == "Bán hàng")
                //    {
                //        Quanlybanhang bh = new Quanlybanhang();
                //        bh.Show();
                //    }
                //if (dt.Rows[0][0].ToString() == "Kho")
                //    {
                //        Quanlynhaphang nh = new Quanlynhaphang();
                //        nh.Show();
                //    }
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {
            txtMatkhau.PasswordChar = '*';
            this.ControlBox = false;
        }
    }
}
