using Data_logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_logic
{
   public class SANPHAM
    {
        Data da = new Data();
        public DataTable gettable()
        {
            DataTable dt = new DataTable();
            dt = da.gettable("sp_HienSanpham");
            return dt;
        }
        public DataTable getLSP()
        {
            DataTable dt = new DataTable();
            dt = da.gettable("sp_HienLSP");
            return dt;
        }
        public bool isSP_use(int MaSP)
        {
            DataTable dt = da.gettable_QR("select MaSP from CTHD where MaSP ='" + MaSP + "'");
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public void ThemSP(String TenSP, int Soluong, string TenLSP, int Dongia,int Gianhap)
        {
            SqlParameter[] sqlparam = new SqlParameter[5];
            sqlparam[0] = new SqlParameter("@TenSP", SqlDbType.NVarChar);
            sqlparam[0].Value = TenSP;
            sqlparam[1] = new SqlParameter("@Soluong", SqlDbType.Int);
            sqlparam[1].Value = Soluong;
            sqlparam[2] = new SqlParameter("@TenLSP", SqlDbType.Text);
            sqlparam[2].Value = TenLSP;
            sqlparam[3] = new SqlParameter("@Dongia", SqlDbType.Int);
            sqlparam[3].Value = Dongia;
            sqlparam[4] = new SqlParameter("@Gianhap", SqlDbType.Int);
            sqlparam[4].Value = Gianhap;
            da.Excutesp("sp_Themsanpham", sqlparam);
        }
        public void CapnhatSP(int MaSP,String TenSP, int Soluong, string TenLSP, int Dongia,int Gianhap)
        {
            SqlParameter[] sqlparam = new SqlParameter[6];
            sqlparam[0] = new SqlParameter("@MaSP", SqlDbType.Int);
            sqlparam[0].Value = MaSP;
            sqlparam[1] = new SqlParameter("@TenSP", SqlDbType.NVarChar);
            sqlparam[1].Value = TenSP;
            sqlparam[2] = new SqlParameter("@Soluong", SqlDbType.Int);
            sqlparam[2].Value = Soluong;
            sqlparam[3] = new SqlParameter("@TenLSP", SqlDbType.Text);
            sqlparam[3].Value = TenLSP;
            sqlparam[4] = new SqlParameter("@Dongia", SqlDbType.Int);
            sqlparam[4].Value = Dongia;
            sqlparam[5] = new SqlParameter("@Gianhap", SqlDbType.Int);
            sqlparam[5].Value = Gianhap;
            da.Excutesp("sp_Capnhatsanpham", sqlparam);
        }
        public void XoaSP(int MaSP)
        {
            SqlParameter[] sqlparam = new SqlParameter[1];
            sqlparam[0] = new SqlParameter("@MaSP", SqlDbType.Int);
            sqlparam[0].Value = MaSP;
            da.Excutesp("sp_Xoasanpham", sqlparam);
        }
        public bool isSanphamExist(string TenSP)
        {
            DataTable List_sp = da.gettable_QR("select MaSP from SANPHAM where TenSP ='" + TenSP + "'");
            if (List_sp.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
    }
}
