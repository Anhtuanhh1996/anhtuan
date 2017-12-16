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
    public partial class Chitietphieunhap : Form
    {
        public Chitietphieunhap()
        {
            InitializeComponent();
        }
        CTPN ctpn = new CTPN();
        public static string MaPN = Quanlynhaphang.Mapn.ToString();
        public void disable_BtnSua()
        {
            BtnSua.Enabled = false;
        }
        public void disable_BtnXoa()
        {
            BtnXoa.Enabled = false;
        }
        public void disable_BtnThem()
        {
            BtnThem.Enabled = false;
        }
        
        public void Hien(string filter = "")
        {
            DataTable dt = new DataTable();
            dt = ctpn.gettable(lbMaPN.Text);
            DataView dv = new DataView(dt);
            if (!string.IsNullOrEmpty(filter))
            {
                dv.RowFilter = filter;
            }
            DGRDsanphamnhap.AutoGenerateColumns = false;
            DGRDsanphamnhap.DataSource = dv;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Chitietphieunhap_Load(object sender, EventArgs e)
        {
            lbMaPN.Text = Quanlynhaphang.Mapn;
            Hien();
        }
        public void Load_CbLoaiSP()
        {
            CbLoaisp.Items.Clear();
            DataTable dt = new DataTable();
            dt = ctpn.getLSP();
            foreach (DataRow dr in dt.Rows)
            {
                CbLoaisp.Items.Add(dr["TenLSP"].ToString());
            }
        }
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnHuybo_Click(object sender, EventArgs e)
        {
            TxtTensanpham.Text  = TxtGiaban.Text = mtbGianhap.Text = mtbSoluong.Text = CbLoaisp.Text = string.Empty;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (TxtTensanpham.Text == "" || mtbGianhap.Text == "" || mtbSoluong.Text == "" || TxtGiaban.Text == ""|| CbLoaisp.Text == "" )
            {
                MessageBox.Show("Nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {  
                if(int.Parse(TxtGiaban.Text) < int.Parse(mtbGianhap.Text))
                {
                    MessageBox.Show("Giá bán nhỏ hơn giá nhập", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    ctpn.ThemCTPN(MaPN, TxtTensanpham.Text, int.Parse(mtbSoluong.Text), int.Parse(mtbGianhap.Text), int.Parse(TxtGiaban.Text), CbLoaisp.Text);
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK);
                }
                
            }
            Hien();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)DGRDsanphamnhap.DataSource;
            DataTable t = dv.ToTable();
            if (TxtTensanpham.Text == "" || mtbGianhap.Text == "" || mtbSoluong.Text == "" || TxtGiaban.Text == "" || CbLoaisp.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                if (ctpn.isSanphamExisit(TxtTensanpham.Text)&& TxtTensanpham.Text != t.Rows[DGRDsanphamnhap.CurrentRow.Index]["TenSP"].ToString())
                {
                    MessageBox.Show("Sản phẩm đã có");
                    return;
                }
                else
                {
                    if (int.Parse(TxtGiaban.Text) < int.Parse(mtbGianhap.Text))
                    {
                        MessageBox.Show("Giá bán nhỏ hơn giá nhập", "Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        ctpn.CapnhatCTPN(lbMaPN.Text, TxtTensanpham.Text, int.Parse(mtbSoluong.Text), int.Parse(mtbGianhap.Text), CbLoaisp.Text, int.Parse(TxtGiaban.Text));
                    }
                }
            }
            Hien();
        }

        private void DGRDsanphamnhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataView dv = (DataView)DGRDsanphamnhap.DataSource;
            DataTable t = dv.ToTable();
            TxtTensanpham.Text = t.Rows[DGRDsanphamnhap.CurrentRow.Index]["TenSP"].ToString();
            BtnSua.Tag = lbMaPN.Text;
            mtbSoluong.Text = t.Rows[DGRDsanphamnhap.CurrentRow.Index]["Soluong"].ToString();
            mtbGianhap.Text = t.Rows[DGRDsanphamnhap.CurrentRow.Index]["Gianhap"].ToString();
            TxtTensanpham.Text = t.Rows[DGRDsanphamnhap.CurrentRow.Index]["TenSP"].ToString();
            TxtGiaban.Text = t.Rows[DGRDsanphamnhap.CurrentRow.Index]["Dongia"].ToString();
            CbLoaisp.Text = t.Rows[DGRDsanphamnhap.CurrentRow.Index]["TenLSP"].ToString();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)DGRDsanphamnhap.DataSource;
            DataTable t = dv.ToTable();
            DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                foreach (DataGridViewCell item in this.DGRDsanphamnhap.SelectedCells)
                {
                    ctpn.Xoa_CTPN(MaPN, int.Parse(t.Rows[item.RowIndex]["MaSP"].ToString()));
                }
            }
            Hien();
        }
        private String filter()
        {
            String filter = "TenSP <> '' ";
            if (!String.IsNullOrEmpty(TxtTensanpham.Text))
            {
                filter += string.Format(" AND TenSP = '{0}'", TxtTensanpham.Text);
            }
            if (!String.IsNullOrEmpty(mtbGianhap.Text))
            {
                filter += string.Format(" AND Gianhap > '{0}'", int.Parse(mtbGianhap.Text));
            }
            if (!String.IsNullOrEmpty(mtbSoluong.Text))
            {
                filter += string.Format(" AND Soluong > '{0}'", mtbSoluong.Text);
            }
            return filter;
        }
        private void BtnTimkiem_Click(object sender, EventArgs e)
        {
            Hien(filter());
        }

        private void BtnInphieunhap_Click(object sender, EventArgs e)
        {
            InPhieunhap rv = new InPhieunhap();
            rv.ShowReport("CRPPhieunhap.rpt", "PHIẾU NHẬP HÀNG", lbMaPN.Text);
            rv.Activate();
            rv.Show();
        }

        private void TxtGiaban_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbGianhap_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
