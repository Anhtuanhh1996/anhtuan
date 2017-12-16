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
    public partial class Quanlynhacungcap : Form
    {
        public Quanlynhacungcap()
        {
            InitializeComponent();
        }
        NHACUNGCAP ncc = new NHACUNGCAP();
        string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
        public void Hien(string filter = "")
        {
            DataTable dt = new DataTable();
            dt = ncc.gettable();
            DataView dv = new DataView(dt);
            if (!string.IsNullOrEmpty(filter))
            {
                dv.RowFilter = filter;
            }
            DGRDanhsachnhacungcap.AutoGenerateColumns = false;
            DGRDanhsachnhacungcap.DataSource = dv;
        }
        private void Quanlynhacungcap_Load(object sender, EventArgs e)
        {
            Hien();
            this.ControlBox = false;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtTenNCC.Text) || string.IsNullOrEmpty(MtbEmail.Text) || string.IsNullOrEmpty(MtbSDT.Text))
            {
                MessageBox.Show("hãy nhập đủ thông tin các trường");
                return;
            }
            if (ncc.isNccExist(TxtTenNCC.Text))
            {
                MessageBox.Show("Nhà cung cấp đã tồn tại");
                return;
            }
            else
            {
                Regex reg = new Regex(match);
                if (reg.IsMatch(MtbEmail.Text))
                {
                    ncc.ThemNCC(TxtTenNCC.Text, TxtDiachi.Text, MtbSDT.Text, MtbEmail.Text);
                    BtnHuybo_Click(sender, e);
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Email nhập vào không hợp lệ", "Thông Báo", MessageBoxButtons.OK);
                }   
                Hien();
                
            }
        }

        private void BtnHuybo_Click(object sender, EventArgs e)
        {
            TxtDiachi.Text = TxtTenNCC.Text = MtbEmail.Text = MtbSDT.Text = String.Empty;
        }

        private void DGRDanhsachnhacungcap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataView dv = (DataView)DGRDanhsachnhacungcap.DataSource;
            DataTable t = dv.ToTable();
            BtnSua.Tag = t.Rows[DGRDanhsachnhacungcap.CurrentRow.Index]["MaNCC"].ToString();
            TxtTenNCC.Text = t.Rows[DGRDanhsachnhacungcap.CurrentRow.Index]["TenNCC"].ToString();
            TxtDiachi.Text = t.Rows[DGRDanhsachnhacungcap.CurrentRow.Index]["Diachi"].ToString();
            MtbSDT.Text = t.Rows[DGRDanhsachnhacungcap.CurrentRow.Index]["SDT"].ToString();
            MtbEmail.Text = t.Rows[DGRDanhsachnhacungcap.CurrentRow.Index]["Email"].ToString();
        }
    }
}
