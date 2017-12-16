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
    public partial class Chitiethoadon : Form
    {
        public Chitiethoadon()
        {
            InitializeComponent();
        }
        
        CTHD cthd = new CTHD();
        public static string  MaHD = Quanlybanhang.Mahd.ToString();
        public void Hien(string filter = "")
        {
            DataTable dt = new DataTable();
            dt = cthd.gettable(lbMaHD.Text);
            DataView dv = new DataView(dt);
            if (!string.IsNullOrEmpty(filter))
            {
                dv.RowFilter = filter;
            }
            DGRDssanpham.AutoGenerateColumns = false;
            DGRDssanpham.DataSource = dv;
        }
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
        private void Chitiethoadon_Load(object sender, EventArgs e)
        {
            lbMaHD.Text = Quanlybanhang.Mahd.ToString();
            this.ControlBox = false;
            Hien();
        }
        
        private void BtnHuybo_Click(object sender, EventArgs e)
        {
            TxtTensanpham.Text = mtbDongia.Text = mtbSoluong.Text = string.Empty;
            mtbDongia.ResetText();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            lbMaHD.Refresh();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (cthd.TenSP(TxtTensanpham.Text) == "")
            {
                MessageBox.Show("Sản phẩm không tồn tại");
            }
            else
            {
                if (int.Parse(mtbSoluong.Text) > cthd.soLuong(TxtTensanpham.Text))
                {
                    MessageBox.Show("Không đủ hàng trong kho");
                }
                else
                {
                    if (cthd.isSanphamExist(TxtTensanpham.Text,Quanlybanhang.Mahd))
                    {
                        MessageBox.Show("Sản phẩm đã có ");
                    }
                    else
                    cthd.ThemCTHD(MaHD, TxtTensanpham.Text, int.Parse(mtbSoluong.Text), int.Parse(mtbDongia.Text),int.Parse(MtbGianhap.Text));
                    Hien();
                    BtnHuybo_Click(sender, e);
                }        
            }
           
        }


        private void DGRDssanpham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataView dv = (DataView)DGRDssanpham.DataSource;
            DataTable t = dv.ToTable();
            BtnSua.Tag = t.Rows[DGRDssanpham.CurrentRow.Index]["MaSP"].ToString();
            TxtTensanpham.Text = t.Rows[DGRDssanpham.CurrentRow.Index]["TenSP"].ToString();
            mtbDongia.Text = t.Rows[DGRDssanpham.CurrentRow.Index]["Dongia"].ToString();
            mtbSoluong.Text = t.Rows[DGRDssanpham.CurrentRow.Index]["Soluong"].ToString();
            
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)DGRDssanpham.DataSource;
            DataTable t = dv.ToTable();
            if (cthd.TenSP(TxtTensanpham.Text) == "")
            {
                MessageBox.Show("Sản phẩm không tồn tại");
            }

            else
            {
                if ((int.Parse(mtbSoluong.Text) - int.Parse(t.Rows[DGRDssanpham.CurrentRow.Index]["Soluong"].ToString())) > cthd.soLuong(TxtTensanpham.Text))
                {
                    MessageBox.Show("Không đủ hàng trong kho");
                }
                else
                {
                    if (cthd.isSanphamExist(TxtTensanpham.Text,Quanlybanhang.Mahd)&&TxtTensanpham.Text != t.Rows[DGRDssanpham.CurrentRow.Index]["TenSP"].ToString())
                    {
                        MessageBox.Show("Sản phẩm đã có ");
                    }
                    else
                    {
                        cthd.suaCTHD(MaHD, TxtTensanpham.Text, int.Parse(mtbSoluong.Text), int.Parse(mtbDongia.Text),int.Parse(MtbGianhap.Text));
                    }
                }
            }
            Hien();
            BtnHuybo_Click(sender, e);
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)DGRDssanpham.DataSource;
            DataTable t = dv.ToTable();
            DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                foreach (DataGridViewCell item in this.DGRDssanpham.SelectedCells)
                {
                    cthd.XoaCTHD(MaHD, int.Parse(t.Rows[item.RowIndex]["MaSP"].ToString()));
                }
            }
            Hien();
        }

        private void TxtTongtien_TextChanged(object sender, EventArgs e)
        {
            TxtTongtien.Text = cthd.Tongtienhd(lbMaHD.Text).ToString();
        }
        private void thanhtoan()
        {
            int tiendua = 0;
            int tientra = 0;
            int hieu = 0;
            tiendua = int.Parse(TxtTienkhach.Text);
            tientra = int.Parse(TxtTongtien.Text);
            hieu = (tiendua - tientra);
            TxtTiendu.Text = hieu.ToString();

        }
        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            if(DGRDssanpham.RowCount > 0)
            {
                TxtTongtien.Text = cthd.Tongtienhd(lbMaHD.Text).ToString();
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm ");
            }
           
        }

       

        private void BtnInhoadon_Click(object sender, EventArgs e)
        {
            Inhoadon rv = new Inhoadon();
            rv.ShowReport("CRPHoadon.rpt", "Hóa đơn bán lẻ",lbMaHD.Text);
            rv.Activate();
            rv.Show();
        }
        private String filter()
        {
            String filter = "TenSP <> '' ";
            if (!String.IsNullOrEmpty(TxtTensanpham.Text))
            {
                filter += string.Format(" AND TenSP = '{0}'", TxtTensanpham.Text);
            }
            if (!String.IsNullOrEmpty(mtbDongia.Text))
            {
                filter += string.Format(" AND Dongia > '{0}'", mtbDongia.Text);
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

        private void mtbSoluong_TextChanged(object sender, EventArgs e)
        {
            if (TxtTensanpham.Text == "")
            {
                mtbDongia.Text = string.Empty;
            }
            else
            {
                if (cthd.TenSP(TxtTensanpham.Text) == "")
                {
                    return;
                }
                else
                {
                    mtbDongia.Text = cthd.donGia(TxtTensanpham.Text).ToString();
                    MtbGianhap.Text = cthd.giaNhap(TxtTensanpham.Text).ToString();
                }

            }
        }

        private void TxtTienkhach_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TxtTongtien.Text) && String.IsNullOrWhiteSpace(TxtTienkhach.Text))
            {
                return;
            }
            if (TxtTongtien.Text != "" && String.IsNullOrWhiteSpace(TxtTienkhach.Text))
            {
                int hieu = -int.Parse(TxtTongtien.Text);
                TxtTiendu.Text = hieu.ToString();
            }
            else if (TxtTongtien.Text != "" && TxtTienkhach.Text != "")
            {
                thanhtoan();
            }
        }
    }
}
