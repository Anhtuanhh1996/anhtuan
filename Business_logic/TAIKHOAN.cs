using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_logic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Business_logic
{
    public class TAIKHOAN
    {
        String[] paramname = { "@Email", "@Matkhau", "@Hoten", "@Ngaysinh", "@Diachi", "@Gioitinh", "@TenQ" };
        String Email, Hoten, Matkhau, Diachi, TenQ;
        bool Gioitinh;
        DateTime Ngaysinh;
        Data da = new Data();
        public DataTable gettable()
        {
            DataTable dt = new DataTable();
            dt = da.gettable("sp_HienTaikhoan");
            return dt ;
        }
        public DataTable getTenQ()
        {
            DataTable dt = new DataTable();
            dt = da.gettable("sp_HienTenQ");
            return dt;
        }
        public void ThemTK(String Email, String Matkhau, String Hoten, DateTime Ngaysinh, String Diachi, bool Gioitinh, String TenQ)
        {
            SqlParameter[] sqlparam = new SqlParameter[7];
            sqlparam[0] = new SqlParameter("@Email", SqlDbType.Text);
            sqlparam[0].Value = Email;
            sqlparam[1] = new SqlParameter("@Matkhau", SqlDbType.Text);
            sqlparam[1].Value = Matkhau;
            sqlparam[2] = new SqlParameter("@Hoten", SqlDbType.NVarChar);
            sqlparam[2].Value = Hoten;
            sqlparam[3] = new SqlParameter("@Ngaysinh", SqlDbType.DateTime);
            sqlparam[3].Value = Ngaysinh.ToString();
            sqlparam[4] = new SqlParameter("@Diachi", SqlDbType.NVarChar);
            sqlparam[4].Value = Diachi;
            sqlparam[5] = new SqlParameter("@Gioitinh", SqlDbType.Bit);
            sqlparam[5].Value = Gioitinh;
            sqlparam[6] = new SqlParameter("@TenQ", SqlDbType.NVarChar);
            sqlparam[6].Value = TenQ;
            da.Excutesp("sp_ThemTaikhoan", sqlparam);
        }
        public void SuaTK(int MaTK,String Email, String Matkhau, String Hoten, DateTime Ngaysinh, String Diachi, bool Gioitinh, String TenQ)
        {
            SqlParameter[] sqlparam = new SqlParameter[8];
            sqlparam[0] = new SqlParameter("@MaTK", SqlDbType.Int);
            sqlparam[0].Value = MaTK;
            sqlparam[1] = new SqlParameter("@Email", SqlDbType.Text);
            sqlparam[1].Value = Email;
            sqlparam[2] = new SqlParameter("@Matkhau", SqlDbType.Text);
            sqlparam[2].Value = Matkhau;
            sqlparam[3] = new SqlParameter("@Hoten", SqlDbType.NVarChar);
            sqlparam[3].Value = Hoten;
            sqlparam[4] = new SqlParameter("@Ngaysinh", SqlDbType.DateTime);
            sqlparam[4].Value = Ngaysinh.ToString();
            sqlparam[5] = new SqlParameter("@Diachi", SqlDbType.NVarChar);
            sqlparam[5].Value = Diachi;
            sqlparam[6] = new SqlParameter("@Gioitinh", SqlDbType.Bit);
            sqlparam[6].Value = Gioitinh;
            sqlparam[7] = new SqlParameter("@TenQ", SqlDbType.NVarChar);
            sqlparam[7].Value = TenQ;
            da.Excutesp("sp_Capnhattaikhoan", sqlparam);
        }
        public void XoaTK(int MaTK)
        {
            SqlParameter[] sqlparam = new SqlParameter[1];
            sqlparam[0] = new SqlParameter("@MaTK", SqlDbType.Int);
            sqlparam[0].Value = MaTK;
            da.Excutesp("sp_XoaTK", sqlparam);
        }
        public DataTable getTenQ(string email, string matkhau)
        {
            DataTable TenQ = new DataTable();
            TenQ = da.tblTenQ(email, matkhau);
            return TenQ;    
        }
        public string getTenTK(string email, string matkhau)
        {
            DataTable dt = new DataTable();
            dt = da.gettable_QR(" Select Hoten from TAIKHOAN where Email = '" + email + "' And MatKhau = '" + matkhau + "'");
            string Tentk = dt.Rows[0][0].ToString();
            return Tentk;
        }
        public DataTable getMaTK(int MaTK)
        {
            DataTable dt = new DataTable();
            dt = da.gettable_QR(" select MaTK,TAIKHOAN.MaQ,TenQ,Email,MatKhau,Hoten,Ngaysinh,Diachi,Gioitinh from TAIKHOAN, QUYEN where TAIKHOAN.MaQ = QUYEN.MaQ and MaTK = '" + MaTK + "'");
            return dt;
        }


        public bool isEmailExist(string email)
        {
            DataTable List_email = da.gettable_QR("select MaTK from TAIKHOAN where Email ='"+email+"'");
            if(List_email.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
    }
}
