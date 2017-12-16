using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_logic;
namespace BiByShop1
{
    public partial class Quanlysanpham : Form
    {
        public Quanlysanpham()
        {
            InitializeComponent();
        }
        SANPHAM SP = new SANPHAM();
        private void Load_CbLoaiSP()
        {
            CBLoaiSP.Items.Clear();
            DataTable dt = new DataTable();
            dt = SP.getLSP();
            foreach (DataRow dr in dt.Rows)
            {
                CBLoaiSP.Items.Add(dr["TenLSP"].ToString());
            }
        }
        public void Hien(string filter = "")
        {
            DataTable dt = new DataTable();
            dt = SP.gettable();
            DataView dv = new DataView(dt);
            if (!string.IsNullOrEmpty(filter))
            {
                dv.RowFilter = filter;
            }
            DGRSanpham.AutoGenerateColumns = false;
            DGRSanpham.DataSource = dv;
        }
        private void Quanlysanpham_Load(object sender, EventArgs e)
        {
            Load_CbLoaiSP();
            Hien();
            this.ControlBox = false;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtTenSP.Text) || string.IsNullOrEmpty(TxtSoluong.Text) || string.IsNullOrEmpty(TxtDongia.Text))
            {
                MessageBox.Show("hãy nhập đủ thông tin các trường");
                return;
            }
            if (SP.isSanphamExist(TxtTenSP.Text))
            {
                MessageBox.Show("Sản phẩm đã tồn tại");
                return;
            }
            else
            {
                SP.ThemSP(TxtTenSP.Text, int.Parse(TxtSoluong.Text), CBLoaiSP.Text, int.Parse(TxtDongia.Text), int.Parse(mtbGianhap.Text));
                Hien();
                BtnHuybo_Click(sender, e);
                MessageBox.Show("Thêm thành công");
            }
            
        }

        private void BtnHuybo_Click(object sender, EventArgs e)
        {
            TxtDongia.Text = TxtSoluong.Text = TxtTenSP.Text = CBLoaiSP.Text = mtbGianhap.Text = String.Empty;
            Hien();
        }

        private void DGRSanpham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataView dv = (DataView)DGRSanpham.DataSource;
            DataTable t = dv.ToTable();
            BtnSua.Tag = t.Rows[DGRSanpham.CurrentRow.Index]["MaSP"].ToString();
            TxtTenSP.Text = t.Rows[DGRSanpham.CurrentRow.Index]["TenSP"].ToString();
            TxtSoluong.Text = t.Rows[DGRSanpham.CurrentRow.Index]["Soluong"].ToString();
            TxtDongia.Text = t.Rows[DGRSanpham.CurrentRow.Index]["Dongia"].ToString();
            mtbGianhap.Text = t.Rows[DGRSanpham.CurrentRow.Index]["Gianhap"].ToString();
            CBLoaiSP.Text = t.Rows[DGRSanpham.CurrentRow.Index]["TenLSP"].ToString();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)DGRSanpham.DataSource;
            DataTable t = dv.ToTable();
            if (string.IsNullOrWhiteSpace(TxtTenSP.Text) || string.IsNullOrEmpty(TxtSoluong.Text) || string.IsNullOrEmpty(TxtDongia.Text))
            {
                MessageBox.Show("hãy nhập đủ thông tin các trường");
                return;
            }
            if (SP.isSanphamExist(TxtTenSP.Text) && TxtTenSP.Text != t.Rows[DGRSanpham.CurrentRow.Index]["TenSP"].ToString())
            {
                MessageBox.Show("Sản phẩm đã tồn tại");
                return;
            }
            else
            {
                SP.CapnhatSP(int.Parse(BtnSua.Tag.ToString()), TxtTenSP.Text, int.Parse(TxtSoluong.Text), CBLoaiSP.Text, int.Parse(TxtDongia.Text), int.Parse(mtbGianhap.Text));
                Hien();
                BtnHuybo_Click(sender, e);
            }
            
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)DGRSanpham.DataSource;
            DataTable t = dv.ToTable();
            DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                foreach (DataGridViewCell item in this.DGRSanpham.SelectedCells)
                {
                    if (SP.isSP_use(int.Parse(t.Rows[item.RowIndex]["MaSP"].ToString())))
                    {
                        MessageBox.Show("Sản phẩm đã có trong hóa đơn.Không được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        SP.XoaSP(int.Parse(t.Rows[item.RowIndex]["MaSP"].ToString()));
                    } 
                }    
            }
            Hien();
        }
        private String filter()
        {
            String filter = "MaSP > 0 ";
            if (!String.IsNullOrEmpty(TxtTenSP.Text))
            {
                filter += string.Format(" AND TenSP = '{0}'", TxtTenSP.Text);
            }
            if (!String.IsNullOrEmpty(TxtSoluong.Text))
            {
                filter += string.Format(" AND Soluong > '{0}'", TxtSoluong.Text);
            }
      
            if (!String.IsNullOrEmpty(TxtDongia.Text))
            {
                filter += string.Format(" AND Dongia > '{0}'", TxtDongia.Text);
            }
            if (!String.IsNullOrEmpty(CBLoaiSP.Text))
            {
                filter += string.Format(" AND TenLSP = '{0}'", CBLoaiSP.Text);
            }
            return filter;
        }

        private void BtnTimkiem_Click(object sender, EventArgs e)
        {
            Hien(filter());
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBaocao_Click(object sender, EventArgs e)
        {
            Baocaosanpham rv = new Baocaosanpham();
            rv.ShowReport("CRPSanpham.rpt", "Danh sách sản phẩm", Dangnhap.TenTK);
            rv.Activate();
            rv.Show();
           
        }
    }
}
