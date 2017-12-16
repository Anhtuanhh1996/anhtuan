using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_logic
{
    public  class Data
    {
        String connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        public SqlConnection cnn;
        public void KetNoi()
        {
            cnn = new SqlConnection(connectionString);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
        }

        public void NgatKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
        public DataTable tblTenQ(String email, string matkhau)
        {
            
            KetNoi();
            SqlDataAdapter sda = new SqlDataAdapter("select QUYEN.TenQ from QUYEN, TAIKHOAN where TAIKHOAN.Email = '" + email + "' And TAIKHOAN.MatKhau = '" + matkhau + "' And QUYEN.MaQ = TAIKHOAN.MaQ", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable gettable(String proc)
        {
            KetNoi();
            SqlCommand cmd = new SqlCommand(proc, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            NgatKetNoi();
            return dt;
        }
        public DataTable getCTHD(String proc, int MaHD)
        {
            KetNoi();
            SqlCommand cmd = new SqlCommand(proc, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHD", MaHD);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            NgatKetNoi();
            return dt;
        }
        public DataTable gettable_QR(string sql)
        {
            KetNoi();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            NgatKetNoi();
            return dt;
        }
        public void Excutesp(String procname,SqlParameter[] parameter)
        {
            KetNoi();
            SqlCommand cmd = new SqlCommand(procname,cnn);
            cmd.CommandType = CommandType.StoredProcedure; 
            cmd.Parameters.AddRange(parameter);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            NgatKetNoi();
        }
    }
}
