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
   public class KHACHHANG
    {
        Data da = new Data();
        public DataTable gettable()
        {
            DataTable dt = new DataTable();
            dt = da.gettable("sp_HienKhachhang");
            return dt;
        }
        public bool isKh_Exist(string TenKH,string SDT)
        {
            DataTable dt = da.gettable_QR("select MaKH from KHACHHANG where  SDT = '"+ SDT +"' AND TenKH = '" + TenKH + "'");
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
        public void ThemKH(bool Gioitinh, string TenKH, string Diachi, string SDT)
        {
            SqlParameter[] sqlparam = new SqlParameter[4];
            sqlparam[0] = new SqlParameter("@Gioitinh", SqlDbType.Bit);
            sqlparam[0].Value = Gioitinh;
            sqlparam[1] = new SqlParameter("@TenKH", SqlDbType.NVarChar);
            sqlparam[1].Value = TenKH;
            sqlparam[2] = new SqlParameter("@Diachi", SqlDbType.NVarChar);
            sqlparam[2].Value = Diachi;
            sqlparam[3] = new SqlParameter("@SDT", SqlDbType.Char);
            sqlparam[3].Value = SDT;
            da.Excutesp("sp_ThemKH", sqlparam);
        }
        public void CapnhatKH(int MaKH,bool Gioitinh, string TenKH, string Diachi, string SDT)
        {
            SqlParameter[] sqlparam = new SqlParameter[5];
            sqlparam[0] = new SqlParameter("@MaKH", SqlDbType.Int);
            sqlparam[0].Value = MaKH;
            sqlparam[1] = new SqlParameter("@Gioitinh", SqlDbType.Bit);
            sqlparam[1].Value = Gioitinh;
            sqlparam[2] = new SqlParameter("@TenKH", SqlDbType.NVarChar);
            sqlparam[2].Value = TenKH;
            sqlparam[3] = new SqlParameter("@Diachi", SqlDbType.NVarChar);
            sqlparam[3].Value = Diachi;
            sqlparam[4] = new SqlParameter("@SDT", SqlDbType.Char);
            sqlparam[4].Value = SDT;
            da.Excutesp("sp_CapnhatKH", sqlparam);
        }
        public void XoaKH(int MaKH)
        {
            SqlParameter[] sqlparam = new SqlParameter[1];
            sqlparam[0] = new SqlParameter("@MaKH", SqlDbType.Int);
            sqlparam[0].Value = MaKH;
            da.Excutesp("sp_XoaKH", sqlparam);
        }

    }
}
