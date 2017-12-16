using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_logic;
using System.Data;
using System.Data.SqlClient;

namespace Business_logic
{
   public class HOADON
    {
        Data da = new Data();
        public DataTable getNguoilap()
        {
            DataTable dt = new DataTable();
            dt = da.gettable_QR("select TAIKHOAN.Hoten from TAIKHOAN,QUYEN where QUYEN.TenQ= 'Bán hàng' OR QUYEN.TenQ = 'Admin' AND TAIKHOAN.MaQ = QUYEN.MaQ");
            return dt;
        }
        public DataTable getDongia(String TenSP)
        {
            DataTable dt = new DataTable();
            dt = da.gettable_QR("select Dongia from SANPHAM where TenSP = '" + TenSP + "'");
            return dt;
        }
        public DataTable gettable()
        {
            DataTable dt = new DataTable();
            dt = da.gettable("sp_HienHoadon");
            return dt;
        }
       public bool isExistMaHD(string MaHD)
        {
            DataTable List_MaHD = da.gettable_QR("select MaHD from HOADON where MaHD ='" + MaHD + "'");
            if (List_MaHD.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
        public void Laphoadon(String MaHD,String Hoten, DateTime Ngaytao, String TenKH,String SDT)
        {
            SqlParameter[] sqlparam = new SqlParameter[5];
            sqlparam[0] = new SqlParameter("@MaHD", SqlDbType.Char);
            sqlparam[0].Value = MaHD;
            sqlparam[1] = new SqlParameter("@Hoten", SqlDbType.NVarChar);
            sqlparam[1].Value = Hoten;
            sqlparam[2] = new SqlParameter("@Ngaytao", SqlDbType.DateTime);
            sqlparam[2].Value = Ngaytao.ToString();
            sqlparam[3] = new SqlParameter("@TenKH", SqlDbType.NVarChar);
            sqlparam[3].Value = TenKH;
            sqlparam[4] = new SqlParameter("@SDT", SqlDbType.Char);
            sqlparam[4].Value = SDT;
            da.Excutesp("sp_Themhoadon", sqlparam);
        }
        public void Suahoadon (String MaHD, int MaKH,String Hoten, DateTime Ngaytao, String TenKH,String SDT)
        {
            SqlParameter[] sqlparam = new SqlParameter[6];
            sqlparam[0] = new SqlParameter("@MaHD", SqlDbType.Char);
            sqlparam[0].Value = MaHD;
            sqlparam[1] = new SqlParameter("@MaKH", SqlDbType.Int);
            sqlparam[1].Value = MaKH;
            sqlparam[2] = new SqlParameter("@Hoten", SqlDbType.NVarChar);
            sqlparam[2].Value = Hoten;
            sqlparam[3] = new SqlParameter("@Ngaytao", SqlDbType.DateTime);
            sqlparam[3].Value = Ngaytao.ToString();
            sqlparam[4] = new SqlParameter("@TenKH", SqlDbType.NVarChar);
            sqlparam[4].Value = TenKH;
            sqlparam[5] = new SqlParameter("@SDT", SqlDbType.Text);
            sqlparam[5].Value = SDT;
            da.Excutesp("sp_Suahoadon", sqlparam);
        }
        public void xoaHoadon (String MaHD)
        {
            SqlParameter[] sqlparam = new SqlParameter[1];
            sqlparam[0] = new SqlParameter("@MaHD", SqlDbType.Char);
            sqlparam[0].Value = MaHD;
            da.Excutesp("sp_Xoahoadon", sqlparam);
        }
        public void tongTien (int MaHD)
        {
            SqlParameter[] sqlparam = new SqlParameter[1];
            sqlparam[0] = new SqlParameter("@MaHD", SqlDbType.Int);
            sqlparam[0].Value = MaHD;
            da.Excutesp("sp_Tongtienhoadon", sqlparam);
        }
        public bool isHasMaHD(String MaHD)
        {
            DataTable dt = da.gettable_QR("select MaHD from CTHD where MaHD ='" + MaHD + "'");
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
