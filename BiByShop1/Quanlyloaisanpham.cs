using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiByShop1
{
    public partial class Quanlyloaisanpham : Form
    {
        public Quanlyloaisanpham()
        {
            InitializeComponent();
        }
        public string connectionString;
        private DataTable getloaisanpham()
        {

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_HienLoaisanpham", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable("LOAISP");
                        da.Fill(dt);
                        return dt;
                    }

                }
            }
        }
        private void Hien(string filter = "")
        {
            DataTable dt = getloaisanpham();
            DataView dv = new DataView(dt);
            if (!string.IsNullOrEmpty(filter))
            {
                dv.RowFilter = filter;
            }
            DGRLoaiSP.AutoGenerateColumns = false;
            DGRLoaiSP.DataSource = dv;
            BtnSua.Enabled = DGRLoaiSP.RowCount > 0;
        }
        private void BtnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void Quanlyloaisanpham_Load(object sender, EventArgs e)
        {
            connectionString = "Data Source=WINDOWS-S8RLUFM\\SQLXPRESS; Initial Catalog= BibyShop;Integrated Security=True";
            Hien();
            this.ControlBox = false;
        }

        private void BtnHuybo_Click(object sender, EventArgs e)
        {
            TxtTenLSP.Text = TxtMaLSP.Text = String.Empty;
        }

        private void DGRLoaiSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
