using Business_logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiByShop1
{
    public partial class Quanlybanhang : Form
    {
        public Quanlybanhang()
        {
            InitializeComponent();
        }
        public static string Mahd = "";
        HOADON HD = new HOADON();

        public  void Hien(string filter = "")
        {
            DataTable dt = new DataTable();
            dt = HD.gettable();
            DataView dv = new DataView(dt);
            if (!string.IsNullOrEmpty(filter))
            {
                dv.RowFilter = filter;
            }
            DGRDanhsachhoadon.AutoGenerateColumns = false;
            DGRDanhsachhoadon.DataSource = dv;
        }
        private void Quanlybanhang_Load(object sender, EventArgs e)
        {
            if (Dangnhap.TenQ == "Admin")
            {
                load_cbNguoilap();
            }
            else
            {
                CbNguoilap.Text = Dangnhap.TenTK;
                CbNguoilap.Enabled = false;
            }    
            
            Hien();
            
            this.ControlBox = false;
        }
        public void load_cbNguoilap()
        {
            CbNguoilap.Items.Clear();
            DataTable dt = new DataTable();
            dt = HD.getNguoilap();
            foreach (DataRow dr in dt.Rows)
            {
                CbNguoilap.Items.Add(dr["Hoten"].ToString());
            }
            Hien();
        }
        
        private void btnLaphoadon_Click(object sender, EventArgs e)
        {
            if(TxtMaHD.Text == "" || TxtTenKH.Text ==  "" || MtbSDT.Text == "")
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtMaHD.Focus();
            }
            else
            {
                if (HD.isExistMaHD(TxtMaHD.Text))
                {
                    MessageBox.Show("Mã hóa đơn đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtMaHD.Focus();
                }
                else
                {
                    HD.Laphoadon(TxtMaHD.Text, CbNguoilap.Text, DTNgaytao.Value.Date, TxtTenKH.Text, MtbSDT.Text);
                    Mahd = TxtMaHD.Text;
                    Chitiethoadon cthd = new Chitiethoadon();
                    cthd.MdiParent = this.MdiParent;
                    cthd.Show();
                    
                }
            }
            Hien();
            BtnHuybo_Click(sender, e);
        }

        private void BtnHuybo_Click(object sender, EventArgs e)
        {
            TxtTenKH.Text  = DTNgaytao.Text = MtbSDT.Text = TxtMaHD.Text = String.Empty;
            Hien();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChitiethd_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)DGRDanhsachhoadon.DataSource;
            DataTable t = dv.ToTable();
            Mahd = t.Rows[DGRDanhsachhoadon.CurrentRow.Index]["MaHD"].ToString();
            Chitiethoadon cthd = new Chitiethoadon();
            cthd.disable_BtnSua();
            cthd.disable_BtnThem();
            cthd.disable_BtnXoa();
            cthd.MdiParent = this.MdiParent;
            cthd.Show();
        }

        private void DGRDanhsachhoadon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataView dv = (DataView)DGRDanhsachhoadon.DataSource;
            DataTable t = dv.ToTable();
            TxtMaHD.Text = t.Rows[DGRDanhsachhoadon.CurrentRow.Index]["MaHD"].ToString();
            BtnSua.Tag = t.Rows[DGRDanhsachhoadon.CurrentRow.Index]["MaHD"].ToString();
            CbNguoilap.Text = t.Rows[DGRDanhsachhoadon.CurrentRow.Index]["Hoten"].ToString();
            DTNgaytao.Value = DateTime.Parse(t.Rows[DGRDanhsachhoadon.CurrentRow.Index]["Ngaytao"].ToString());
            TxtTenKH.Text = t.Rows[DGRDanhsachhoadon.CurrentRow.Index]["TenKH"].ToString();
            MtbSDT.Text = t.Rows[DGRDanhsachhoadon.CurrentRow.Index]["SDT"].ToString();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)DGRDanhsachhoadon.DataSource;
            DataTable t = dv.ToTable();
            if (TxtMaHD.Text == "" || TxtTenKH.Text == "" || MtbSDT.Text == "")
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtMaHD.Focus();
            }
            else
            {
                if (HD.isExistMaHD(TxtMaHD.Text)&& TxtMaHD.Text!= t.Rows[DGRDanhsachhoadon.CurrentRow.Index]["MaHD"].ToString())
                {
                    MessageBox.Show("Mã hóa đơn đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtMaHD.Focus();
                }
                else
                {
                    int MaKH = int.Parse(t.Rows[DGRDanhsachhoadon.CurrentRow.Index]["MaKH"].ToString());
                    HD.Suahoadon(BtnSua.Tag.ToString(), MaKH, CbNguoilap.Text, DTNgaytao.Value.Date, TxtTenKH.Text, MtbSDT.Text);
                    Hien();
                }
            }
            

        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)DGRDanhsachhoadon.DataSource;
            DataTable t = dv.ToTable();
            DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                foreach (DataGridViewCell item in this.DGRDanhsachhoadon.SelectedCells)
                {
                    if (HD.isHasMaHD(t.Rows[item.RowIndex]["MaHD"].ToString()))
                    {
                        MessageBox.Show("Hóa đơn đã có sản phẩm.không được xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        HD.xoaHoadon(t.Rows[item.RowIndex]["MaHD"].ToString());
                    }
                    
                }
            }
            Hien();
        }
        private String filter()
        {
            String filter = "MaHD <> '' ";
            if (!String.IsNullOrEmpty(TxtMaHD.Text))
            {
                filter += string.Format(" AND MaHD = '{0}'", TxtMaHD.Text);
            }
            if (!String.IsNullOrEmpty(TxtTenKH.Text))
            {
                filter += string.Format(" AND TenKH = '{0}'", TxtTenKH.Text);
            }
            if (!String.IsNullOrEmpty(MtbSDT.Text))
            {
                filter += string.Format(" AND SDT = '{0}'", MtbSDT.Text);
            }

            if (!String.IsNullOrEmpty(CbNguoilap.Text))
            {
                filter += string.Format(" AND Hoten = '{0}'", CbNguoilap.Text);
            }
            if (!String.IsNullOrEmpty(DTNgaytao.Text))
            {
                filter += string.Format(" AND Ngaytao >= '{0}'", DTNgaytao.Value.Date.ToString());
            }
           
            return filter;
        }
        private void BtnTimkiem_Click(object sender, EventArgs e)
        {
            Hien(filter());
        }

        private void BtnBaocao_Click(object sender, EventArgs e)
        {
            Baocaohd1 rv = new Baocaohd1();
            rv.ShowReport("CRPBaocaohd.rpt", "Báo cáo danh sách hóa đơn ngày '"+DTNgaytao.Value.ToString("dd/MM/yyyy")+ "'",DTNgaytao.Value, CbNguoilap.Text);
            rv.Activate();
            rv.Show();
        }
    }
}
