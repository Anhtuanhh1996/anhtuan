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
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
                          
        }
        public static Form findOpenedForm(string formID)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals(formID))
                {
                    return f;
                }
            }
            return null;
        }
        private void Trangchu_Load(object sender, EventArgs e)
        {
            quảnLýDanhMụcToolStripMenuItem.Visible = false;
            báoCáoThốngKêToolStripMenuItem.Visible = false;
            quảnLýBánHàngToolStripMenuItem.Visible = false;
            quảnLýNhậpHàngToolStripMenuItem.Visible = false;
            cậpNhậtTàiKhoảnToolStripMenuItem.Visible = false;
            đăngXuấtToolStripMenuItem.Visible = false;
            if(Dangnhap.TenQ == "Admin")
            {
                quảnLýDanhMụcToolStripMenuItem.Visible = true;
                báoCáoThốngKêToolStripMenuItem.Visible = true;
                quảnLýBánHàngToolStripMenuItem.Visible = true;
                quảnLýNhậpHàngToolStripMenuItem.Visible = true;
                cậpNhậtTàiKhoảnToolStripMenuItem.Visible = true;
                đăngXuấtToolStripMenuItem.Visible = true;
                đăngNhậpToolStripMenuItem.Visible = false;
            }

            if (Dangnhap.TenQ == "Bán hàng")
            {
                đăngNhậpToolStripMenuItem.Visible = false;
                quảnLýBánHàngToolStripMenuItem.Visible = true;
                đăngXuấtToolStripMenuItem.Visible = true;
                quảnLýDanhMụcToolStripMenuItem.Visible = true;
                quảnLýSảnPhẩmToolStripMenuItem.Visible = false;
                quảnLýNhàCungCấpToolStripMenuItem.Visible = false;
                quảnLýLoạiSảnPhẩmToolStripMenuItem.Visible = false;
                quảnLýKháchHàngToolStripMenuItem.Visible = true;
                báoCáoThốngKêToolStripMenuItem.Visible = true;
                báoCáoHàngTồnKhoToolStripMenuItem.Visible = false;
            }
            if(Dangnhap.TenQ == "Kho")
            {
                quảnLýNhậpHàngToolStripMenuItem.Visible = false;
                báoCáoThốngKêToolStripMenuItem.Visible = true;
                báoCáoHàngTồnKhoToolStripMenuItem.Visible = true;
                đăngNhậpToolStripMenuItem.Visible = false;
                quảnLýDanhMụcToolStripMenuItem.Visible = true;
                báoCáoHàngBánChạyToolStripMenuItem.Visible = false;
                báoCáoDoanhThuTheoNgàyToolStripMenuItem.Visible = false;
                quảnLýBánHàngToolStripMenuItem.Visible = false;
                quảnLýKháchHàngToolStripMenuItem.Visible = false;
            }
        }

        private void cậpNhậtTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findOpenedForm("Capnhattaikhoan");
            if (f == null)
            {
                f = new Capnhattaikhoan();
                f.MdiParent = this;
            }
            quảnTrịHệThốngToolStripMenuItem.BackColor = Color.Gray;
            f.Show();
            f.Activate();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findOpenedForm("Quanlysanpham");
            if (f == null)
            {
                f = new Quanlysanpham();
                f.MdiParent = this;
            }
            quảnTrịHệThốngToolStripMenuItem.BackColor = Color.Gray;
            f.Show();
            f.Activate();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findOpenedForm("Dangnhap");
            if (f == null)
            {
                f = new Dangnhap();
                f.MdiParent = this;
            }
            quảnTrịHệThốngToolStripMenuItem.BackColor = Color.Gray;
            f.Show();
            f.Activate();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Dangnhap dn = new Dangnhap();
                dn.Show();
                this.Close();
            }
        }

        private void quảnLýBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findOpenedForm("Quanlybanhang");
            if (f == null)
            {
                f = new Quanlybanhang();
                f.MdiParent = this;
            }
            
            f.Show();
            f.Activate();
        }

        private void quảnLýNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findOpenedForm("Quanlynhaphang");
            if (f == null)
            {
                f = new Quanlynhaphang();
                f.MdiParent = this;
            }

            f.Show();
            f.Activate();
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findOpenedForm("Quanlynhacungcap");
            if (f == null)
            {
                f = new Quanlynhacungcap();
                f.MdiParent = this;
            }

            f.Show();
            f.Activate();
        }

        private void báoCáoDoanhThuTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findOpenedForm("Baocaodoanhthutheongay");
            if (f == null)
            {
                f = new Baocaodoanhthutheongay();
                f.MdiParent = this;
            }

            f.Show();
            f.Activate();
        }

        private void báoCáoHàngTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findOpenedForm("Baocaohangton");
            if (f == null)
            {
                f = new Baocaohangton();
                f.MdiParent = this;
            }

            f.Show();
            f.Activate();
        }

        private void Trangchu_FormClosed(object sender, FormClosedEventArgs e)
        {
             Application.Exit();
        }

        private void báoCáoHàngBánChạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findOpenedForm("Baocaohangbanchay");
            if (f == null)
            {
                f = new Baocaohangbanchay();
                f.MdiParent = this;
            }

            f.Show();
            f.Activate();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = findOpenedForm("Quanlykhachhang");
            if (f == null)
            {
                f = new Quanlykhachhang();
                f.MdiParent = this;
            }

            f.Show();
            f.Activate();
        }

        private void quảnLýLoạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form f = findOpenedForm("Quanlyloaisanpham");
            //if (f == null)
            //{
            //    f = new Quanlyloaisanpham();
            //    f.MdiParent = this;
            //}

            //f.Show();
            //f.Activate();
        }
    }
}
