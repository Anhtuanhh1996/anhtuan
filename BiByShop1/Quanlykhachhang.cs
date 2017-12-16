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
    public partial class Quanlykhachhang : Form
    {
        public Quanlykhachhang()
        {
            InitializeComponent();
        }
        KHACHHANG KH = new KHACHHANG();
        public void Hien(string filter = "")
        {
            DataTable dt = new DataTable();
            dt = KH.gettable();
            DataView dv = new DataView(dt);
            if (!string.IsNullOrEmpty(filter))
            {
                dv.RowFilter = filter;
            }
            DGRDanhsachkhachhang.AutoGenerateColumns = false;
            DGRDanhsachkhachhang.DataSource = dv;
        }
        private bool gioitinh()
        {
            bool gioitinh = true;
            if (RBGioitinh1.Checked == true)
            {
                gioitinh = true;
            }
            else
            {
                gioitinh = false;
            }
            return gioitinh;
        }
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnTimkiem_Click(object sender, EventArgs e)
        {
            String filter = "MaKH > 0 ";
            if (!String.IsNullOrEmpty(TxtTenKH.Text))
            {
                filter += string.Format(" AND TenKH LIKE '%{0}%'", TxtTenKH.Text);
            }
            if (!String.IsNullOrEmpty(TxtDiachi.Text))
            {
                filter += string.Format(" AND Diachi LIKE '%{0}%'", TxtDiachi.Text);
            }
            if (RBGioitinh1.Checked)
            {
                filter += string.Format("AND Gioitinh = true");
            }
            if (RBGioitinh2.Checked)
            {
                filter += string.Format(" AND Gioitinh = false");
            }
            
            if (!String.IsNullOrEmpty(MtbSDT.Text))
            {
                filter += string.Format(" AND SDT = '{0}'", MtbSDT.Text);
            }
            Hien(filter);
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)DGRDanhsachkhachhang.DataSource;
            DataTable t = dv.ToTable();
            DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                foreach (DataGridViewCell item in this.DGRDanhsachkhachhang.SelectedCells)
                {
                    KH.XoaKH(int.Parse(t.Rows[item.RowIndex]["MaKH"].ToString()));
                }
            }
            Hien();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtTenKH.Text) || string.IsNullOrEmpty(MtbSDT.Text) || string.IsNullOrEmpty(TxtDiachi.Text))
            {
                MessageBox.Show("hãy nhập đủ thông tin các trường bắt buộc");
                return;
            }
            if (KH.isKh_Exist(TxtTenKH.Text, MtbSDT.Text))
            {
                MessageBox.Show("Khách hàng đã tồn tại");
                return;
            }
            else
            {
                KH.CapnhatKH(int.Parse(BtnSua.Tag.ToString()),gioitinh(), TxtTenKH.Text, TxtDiachi.Text, MtbSDT.Text);
                Hien();
                BtnHuybo_Click(sender, e);
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtTenKH.Text) || string.IsNullOrEmpty(MtbSDT.Text) || string.IsNullOrEmpty(TxtDiachi.Text))
            {
                MessageBox.Show("hãy nhập đủ thông tin các trường bắt buộc");
                return;
            }
            if (KH.isKh_Exist(TxtTenKH.Text,MtbSDT.Text))
            {
                MessageBox.Show("Khách hàng đã tồn tại");
                return;
            }
            else
            {
                KH.ThemKH(gioitinh(), TxtTenKH.Text, TxtDiachi.Text,MtbSDT.Text);
                MessageBox.Show("Thêm thành công");
                Hien();
                BtnHuybo_Click(sender, e);
            }
        }

        private void BtnHuybo_Click(object sender, EventArgs e)
        {
            TxtDiachi.Text = TxtTenKH.Text = MtbSDT.Text = string.Empty;
            RBGioitinh1.Checked = RBGioitinh2.Checked = false;
        }

        private void Quanlykhachhang_Load(object sender, EventArgs e)
        {
            Hien();
            this.ControlBox = false;
        }

        private void DGRDanhsachkhachhang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.DGRDanhsachkhachhang.Columns[e.ColumnIndex].Name == "Gioitinh")
            {
                if (e.Value != null)
                {
                    if ((Boolean)e.Value == true)
                    {
                        e.Value = "Nam";
                    }
                    else
                    {
                        e.Value = "Nữ";
                    }
                }
            }
        }

        private void BtnBaocao_Click(object sender, EventArgs e)
        {
            BaocaoKH bc = new BaocaoKH();
            bc.Show();
        }

        private void DGRDanhsachkhachhang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataView dv = (DataView)DGRDanhsachkhachhang.DataSource;
            DataTable t = dv.ToTable();
            int n = DGRDanhsachkhachhang.CurrentRow.Index;
            BtnSua.Tag = t.Rows[n]["MaKH"].ToString();
            TxtTenKH.Text = t.Rows[n]["TenKH"].ToString();
            TxtDiachi.Text = t.Rows[n]["Diachi"].ToString();
            MtbSDT.Text = t.Rows[n]["SDT"].ToString();
            if ((Boolean)t.Rows[n]["Gioitinh"])
            {
                RBGioitinh1.Checked = true;
            }
            else
            {
                RBGioitinh2.Checked = true;
            }
        }
    }
}
