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
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

namespace BiByShop1
{
    public partial class Capnhattaikhoan : Form
    {
        public Capnhattaikhoan()
        {
            InitializeComponent();
        }
        TAIKHOAN TK = new TAIKHOAN();
        string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
        String connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        public void Hien(string filter = "")
        {
            DataTable dt = new DataTable();
            dt = TK.gettable();
            DataView dv = new DataView(dt);
            if (!string.IsNullOrEmpty(filter))
            {
                dv.RowFilter = filter;
            }
            DGRTaikhoan.AutoGenerateColumns = false;
            DGRTaikhoan.DataSource = dv;
        }
        private bool gioitinh()
        {
            bool gioitinh = true ;
            if (RbGt01.Checked == true)
            {
                gioitinh = true;
            }
            else 
            {
                gioitinh = false;
            }
            return gioitinh;
        }
        private void Load_CbQuyen()
        {
            CBQuyen.Items.Clear();
            DataTable dt = new DataTable();
            dt = TK.getTenQ();
            foreach (DataRow dr in dt.Rows)
            {
                CBQuyen.Items.Add(dr["TenQ"].ToString());
            }
        }
       
        private void Capnhattaikhoan_Load(object sender, EventArgs e)
        {
            
            Hien();
            //TxtMatkhau.PasswordChar = '*';
            this.ControlBox = false;
            Load_CbQuyen();  
                
        }
        
        private void BtnThem_Click(object sender, EventArgs e)
        {
            if( string.IsNullOrEmpty(TxtEmail.Text) || string.IsNullOrEmpty(CBQuyen.Text) || string.IsNullOrEmpty(TxtMatkhau.Text))
            {
                MessageBox.Show("hãy nhập đủ thông tin các trường bắt buộc");
                return;
            }
            if (TK.isEmailExist(TxtEmail.Text))
            {
                MessageBox.Show("Email đã tồn tại");
                return;
            }
            else
            {
                Regex reg = new Regex(match);
                if (reg.IsMatch(this.TxtEmail.Text))
                {
                    TK.ThemTK(TxtEmail.Text, TxtMatkhau.Text, TxtHoten.Text, DTNgaysinh.Value.Date, TxtDiachi.Text, gioitinh(), CBQuyen.Text);
                    MessageBox.Show("Thêm thành công");
                    Hien();
                    BtnHuybo_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Email nhập vào không hợp lệ", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            
        }

        private void DGRTaikhoan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataView dv = (DataView)DGRTaikhoan.DataSource;
            DataTable t = dv.ToTable();
            BtnSua.Tag = t.Rows[DGRTaikhoan.CurrentRow.Index]["MaTK"].ToString();
            TxtEmail.Text = t.Rows[DGRTaikhoan.CurrentRow.Index]["Email"].ToString();
            TxtHoten.Text = t.Rows[DGRTaikhoan.CurrentRow.Index]["Hoten"].ToString();
            TxtDiachi.Text = t.Rows[DGRTaikhoan.CurrentRow.Index]["Diachi"].ToString();
            TxtMatkhau.Text = t.Rows[DGRTaikhoan.CurrentRow.Index]["Matkhau"].ToString();
            CBQuyen.Text = t.Rows[DGRTaikhoan.CurrentRow.Index]["TenQ"].ToString();
            DTNgaysinh.Value = DateTime.Parse(t.Rows[DGRTaikhoan.CurrentRow.Index]["Ngaysinh"].ToString());
            if ((Boolean)t.Rows[DGRTaikhoan.CurrentRow.Index]["Gioitinh"])
            {
                RbGt01.Checked = true;
            }
            else
            {
                RbGT02.Checked = true;
            }
        }

        private void DGRTaikhoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.DGRTaikhoan.Columns[e.ColumnIndex].Name == "Gioitinh")
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

        private void BtnSua_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)DGRTaikhoan.DataSource;
            DataTable t = dv.ToTable();
            if (string.IsNullOrWhiteSpace(TxtEmail.Text) || string.IsNullOrEmpty(CBQuyen.Text) || string.IsNullOrEmpty(TxtMatkhau.Text))
            {
                MessageBox.Show("hãy nhập đủ thông tin các trường bắt buộc");
                return;
            }
            if (TK.isEmailExist(TxtEmail.Text) && TxtEmail.Text != t.Rows[DGRTaikhoan.CurrentRow.Index]["Email"].ToString())
            {
                MessageBox.Show("Email đã tồn tại");
                return;
            }
            else
            {
                TK.SuaTK(int.Parse(BtnSua.Tag.ToString()), TxtEmail.Text, TxtMatkhau.Text, TxtHoten.Text, DTNgaysinh.Value.Date, TxtDiachi.Text, gioitinh(), CBQuyen.Text);
                Hien();
                BtnHuybo_Click(sender, e);
            }
            
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)DGRTaikhoan.DataSource;
            DataTable t = dv.ToTable();
            DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                foreach (DataGridViewCell item in this.DGRTaikhoan.SelectedCells)
                {
                    TK.XoaTK(int.Parse(t.Rows[item.RowIndex]["MaTK"].ToString()));
                }
                
            }
            Hien();
        }
        private String filter()
        {
            String filter = "MaTK > 0 ";
            if (!String.IsNullOrEmpty(TxtEmail.Text))
            {
                filter += string.Format(" AND Email = '{0}'", TxtEmail.Text);
            }
            if (!String.IsNullOrEmpty(TxtHoten.Text))
            {
                filter += string.Format(" AND Hoten LIKE '%{0}%'", TxtHoten.Text);
            }
            if (RbGt01.Checked)
            {
                filter += string.Format("AND Gioitinh = true");
            }
            if (RbGT02.Checked)
            {
                filter += string.Format(" AND Gioitinh = false");
            }
            if (!String.IsNullOrEmpty(DTNgaysinh.Text))
            {
                filter += string.Format(" AND ngaysinh >= '{0}'", DTNgaysinh.Value.Date.ToString());
            }

            if (!String.IsNullOrEmpty(TxtMatkhau.Text))
            {
                filter += string.Format(" AND Matkhau = '{0}'", TxtMatkhau.Text);
            }
            if (!String.IsNullOrEmpty(CBQuyen.Text))
            {
                filter += string.Format(" AND TenQ = '{0}'", CBQuyen.Text);
            }
            if (!String.IsNullOrEmpty(TxtDiachi.Text))
            {
                filter += string.Format(" AND Diachi Like '%{0}%'", TxtDiachi.Text);
            }
            return filter;
        }
        private void BtnTimkiem_Click(object sender, EventArgs e)
        {   
            Hien(filter());
        }

        private void BtnHuybo_Click(object sender, EventArgs e)
        {
            TxtDiachi.Text = TxtEmail.Text = TxtHoten.Text = TxtMatkhau.Text = CBQuyen.Text = DTNgaysinh.Text = String.Empty;
            RbGt01.Checked = RbGT02.Checked = false;
            Hien();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtMatkhau_TextChanged(object sender, EventArgs e)
        {
            if (TxtMatkhau.Text.Length < 6 || TxtMatkhau.Text.Length > 10)
            {
                Kiemtramatkhau.SetError(TxtMatkhau, "Mật khẩu phải từ 6 - 10 kí tự");
                BtnThem.Enabled = false;
            }
            else
            {
                BtnThem.Enabled = true;
                Kiemtramatkhau.Clear();
            }
        }
    }
}
