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
    public partial class Quanlynhaphang : Form
    {
        public Quanlynhaphang()
        {
            InitializeComponent();
        }
        public static string Mapn = "";
        PHIEUNHAP PN = new PHIEUNHAP();
        string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
        public void Hien(string filter = "")
        {
            DataTable dt = new DataTable();
            dt = PN.gettable();
            DataView dv = new DataView(dt);
            if (!string.IsNullOrEmpty(filter))
            {
                dv.RowFilter = filter;
            }
            DGRDanhsachphieunhap.AutoGenerateColumns = false;
            DGRDanhsachphieunhap.DataSource = dv;
        }
        public void load_cbNguoilap()
        {
            CbNguoilap.Items.Clear();
            DataTable dt = new DataTable();
            dt = PN.getNguoilap();
            foreach (DataRow dr in dt.Rows)
            {
                CbNguoilap.Items.Add(dr["Hoten"].ToString());
            }
            Hien();
        }
        private void Quanlynhaphang_Load(object sender, EventArgs e)
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
            TxtMaPN.Focus();
            Hien();
            
            this.ControlBox = false;
        }

        private void btnLapphieunhap_Click(object sender, EventArgs e)
        {
            if (TxtMaPN.Text == "" || TxtNCC.Text == "" )
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtMaPN.Focus();
            }
            else
            {
                if (PN.isExistMaPN(TxtMaPN.Text))
                {
                    MessageBox.Show("Mã phiếu nhập đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtMaPN.Focus();
                }
                else
                {
                    Regex reg = new Regex(match);
                    if (reg.IsMatch(this.TxtEmail.Text))
                    {
                        PN.Themphieunhap(TxtMaPN.Text, CbNguoilap.Text, DTNgaylap.Value.Date, TxtNCC.Text, txtDiachi.Text, MtbSDT.Text, TxtEmail.Text);
                        Mapn = TxtMaPN.Text;
                        MessageBox.Show("Đã thêm thành công", "Thông Báo", MessageBoxButtons.OK);
                        Hien();
                        Chitietphieunhap ctpn = new Chitietphieunhap();
                        ctpn.MdiParent = this.MdiParent;
                        ctpn.Show();
                        BtnHuybo_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Email nhập vào không hợp lệ", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void BtnHuybo_Click(object sender, EventArgs e)
        {
            txtDiachi.Text = TxtEmail.Text = TxtMaPN.Text = TxtNCC.Text = MtbSDT.Text = string.Empty;
        }

        private void btnChitietpn_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)DGRDanhsachphieunhap.DataSource;
            DataTable t = dv.ToTable();
            Mapn = t.Rows[DGRDanhsachphieunhap.CurrentRow.Index]["MaPN"].ToString();
            Chitietphieunhap ctpn = new Chitietphieunhap();
            ctpn.disable_BtnSua();
            ctpn.disable_BtnThem();
            ctpn.disable_BtnXoa();
            ctpn.MdiParent = this.MdiParent;
            ctpn.Show();
        }

        private void DGRDanhsachphieunhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataView dv = (DataView)DGRDanhsachphieunhap.DataSource;
            DataTable t = dv.ToTable();
            TxtMaPN.Text = t.Rows[DGRDanhsachphieunhap.CurrentRow.Index]["MaPN"].ToString();
            BtnSua.Tag = t.Rows[DGRDanhsachphieunhap.CurrentRow.Index]["MaPN"].ToString();
            CbNguoilap.Text = t.Rows[DGRDanhsachphieunhap .CurrentRow.Index]["Hoten"].ToString();
            DTNgaylap.Value = DateTime.Parse(t.Rows[DGRDanhsachphieunhap.CurrentRow.Index]["Ngaylap"].ToString());
            TxtNCC.Text = t.Rows[DGRDanhsachphieunhap.CurrentRow.Index]["TenNCC"].ToString();
            txtDiachi.Text = t.Rows[DGRDanhsachphieunhap.CurrentRow.Index]["Diachi"].ToString();
            TxtEmail.Text = t.Rows[DGRDanhsachphieunhap.CurrentRow.Index]["Email"].ToString();
            MtbSDT.Text = t.Rows[DGRDanhsachphieunhap.CurrentRow.Index]["SDT"].ToString();
            TxtMaPN.Enabled = false;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)DGRDanhsachphieunhap.DataSource;
            DataTable t = dv.ToTable();
            if (TxtMaPN.Text == "" || TxtNCC.Text == "")
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtMaPN.Focus();
            }
            else
            {
                if (PN.isExistMaPN(TxtMaPN.Text)&&TxtMaPN.Text != t.Rows[DGRDanhsachphieunhap.CurrentRow.Index]["MaPN"].ToString())
                {
                    MessageBox.Show("Mã phiếu nhập đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtMaPN.Focus();
                }
                else
                {
                    Regex reg = new Regex(match);
                    if (reg.IsMatch(this.TxtEmail.Text))
                    {
                        int MaNCC = int.Parse(t.Rows[DGRDanhsachphieunhap.CurrentRow.Index]["MaNCC"].ToString());
                        PN.Capnhatphieunhap(TxtMaPN.Text,MaNCC, CbNguoilap.Text, DTNgaylap.Value.Date, TxtNCC.Text, txtDiachi.Text, MtbSDT.Text, TxtEmail.Text);
                        Mapn = TxtMaPN.Text;
                        Hien();
                        BtnHuybo_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Email nhập vào không hợp lệ", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private String filter()
        {
            String filter = "MaPN <> '' ";
            if (!String.IsNullOrEmpty(TxtMaPN.Text))
            {
                filter += string.Format(" AND MaPN = '{0}'", TxtMaPN.Text);
            }
            if (!String.IsNullOrEmpty(MtbSDT.Text))
            {
                filter += string.Format(" AND SDT = '{0}'", MtbSDT.Text);
            }
            if (!String.IsNullOrEmpty(TxtNCC.Text))
            {
                filter += string.Format(" AND TenNCC = '{0}'", TxtNCC.Text);
            }
            if (!String.IsNullOrEmpty(txtDiachi.Text))
            {
                filter += string.Format(" AND Diachi = '{0}'", txtDiachi.Text);
            }
            if (!String.IsNullOrEmpty(TxtEmail.Text))
            {
                filter += string.Format(" AND Email = '{0}'", TxtEmail.Text);
            }
            if (!String.IsNullOrEmpty(DTNgaylap.Text))
            {
                filter += string.Format(" AND Ngaylap = '{0}'", DTNgaylap.Value.Date.ToString());
            }
            return filter;
        }
        private void BtnTimkiem_Click(object sender, EventArgs e)
        {
            Hien(filter());
        }

        private void BtnBaocao_Click(object sender, EventArgs e)
        {
            Baocaopn rv = new Baocaopn();
            rv.ShowReport("CRPBaocaopn.rpt", "Báo cáo danh sách phiếu nhập ngày '" + DTNgaylap.Value.ToString("dd/MM/yyyy") + "'", DTNgaylap.Value, CbNguoilap.Text);
            rv.Activate();
            rv.Show();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)DGRDanhsachphieunhap.DataSource;
            DataTable t = dv.ToTable();
            DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                foreach (DataGridViewCell item in this.DGRDanhsachphieunhap.SelectedCells)
                {
                    if (PN.isHasMaPN(t.Rows[item.RowIndex]["MaPN"].ToString()))
                    {
                        MessageBox.Show("Phiếu nhập đã có sản phẩm.không được xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        PN.xoaPhieunhap(t.Rows[item.RowIndex]["Mapn"].ToString());
                    }
                }
            }
            Hien();
        }
    }
}
