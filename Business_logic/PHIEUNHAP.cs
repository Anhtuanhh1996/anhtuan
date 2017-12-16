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
    public class PHIEUNHAP
    {
        Data da = new Data();
        public DataTable getNguoilap()
        {
            DataTable dt = new DataTable();
            dt = da.gettable_QR("select TAIKHOAN.Hoten from TAIKHOAN,QUYEN where QUYEN.TenQ= 'Kho' OR QUYEN.TenQ = 'Admin' AND TAIKHOAN.MaQ = QUYEN.MaQ");
            return dt;
        }
        public DataTable gettable()
        {
            DataTable dt = new DataTable();
            dt = da.gettable("sp_HienPhieunhap");
            return dt;
        }
        public bool isExistMaPN(string MaPN)
        {
            DataTable dt = da.gettable_QR("select MaPN from PHIEUNHAP where MaPN ='" + MaPN + "'");
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
        public bool isHasMaPN(String MaPN)
        {
            DataTable dt = da.gettable_QR("select MaPN from CTPN where MaPN ='" + MaPN + "'");
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public bool isExistNCC(string TenNCC)
        {
            DataTable dt = da.gettable_QR("select MaNCC from NHACUNGCAP where TenNCC ='" + TenNCC + "'");
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
        public void Themphieunhap(String MaPN, String Hoten, DateTime Ngaylap, String TenNCC, String Diachi, String SDT, String Email)
        {
            SqlParameter[] sqlparam = new SqlParameter[7];
            sqlparam[0] = new SqlParameter("@MaPN", SqlDbType.Char);
            sqlparam[0].Value = MaPN;
            sqlparam[1] = new SqlParameter("@Hoten", SqlDbType.NVarChar);
            sqlparam[1].Value = Hoten;
            sqlparam[2] = new SqlParameter("@Ngaylap", SqlDbType.DateTime);
            sqlparam[2].Value = Ngaylap.ToString();
            sqlparam[3] = new SqlParameter("@TenNCC", SqlDbType.NVarChar);
            sqlparam[3].Value = TenNCC;
            sqlparam[4] = new SqlParameter("@Diachi", SqlDbType.NVarChar);
            sqlparam[4].Value = Diachi;
            sqlparam[5] = new SqlParameter("@SDT", SqlDbType.Text);
            sqlparam[5].Value = SDT;
            sqlparam[6] = new SqlParameter("@Email", SqlDbType.Char);
            sqlparam[6].Value =Email;
            da.Excutesp("sp_Themphieunhap", sqlparam);
        }
        public void Capnhatphieunhap(String MaPN,int MaNCC, String Hoten, DateTime Ngaylap, String TenNCC, String Diachi, String SDT, String Email)
        {
            SqlParameter[] sqlparam = new SqlParameter[8];
            sqlparam[0] = new SqlParameter("@MaPN", SqlDbType.Char);
            sqlparam[0].Value = MaPN;
            sqlparam[1] = new SqlParameter("@MaNCC", SqlDbType.Int);
            sqlparam[1].Value = MaNCC;
            sqlparam[2] = new SqlParameter("@Hoten", SqlDbType.NVarChar);
            sqlparam[2].Value = Hoten;
            sqlparam[3] = new SqlParameter("@Ngaylap", SqlDbType.DateTime);
            sqlparam[3].Value = Ngaylap.ToString();
            sqlparam[4] = new SqlParameter("@TenNCC", SqlDbType.NVarChar);
            sqlparam[4].Value = TenNCC;
            sqlparam[5] = new SqlParameter("@Diachi", SqlDbType.NVarChar);
            sqlparam[5].Value = Diachi;
            sqlparam[6] = new SqlParameter("@SDT", SqlDbType.Text);
            sqlparam[6].Value = SDT;
            sqlparam[7] = new SqlParameter("@Email", SqlDbType.Char);
            sqlparam[7].Value = Email;
            da.Excutesp("sp_Capnhatphieunhap", sqlparam);
        }
        public void xoaPhieunhap(String MaPN)
        {
            SqlParameter[] sqlparam = new SqlParameter[1];
            sqlparam[0] = new SqlParameter("@MaPN", SqlDbType.Char);
            sqlparam[0].Value = MaPN;
            da.Excutesp("sp_Xoapn", sqlparam);
        }
    }
}
