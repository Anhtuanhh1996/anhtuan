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
    public class CTPN
    {
        Data da = new Data();
        public DataTable gettable(String MaPN)
        {
            DataTable dt = new DataTable();
            dt = da.gettable_QR("select CTPN.MaSP,SANPHAM.Dongia,SANPHAM.Gianhap,SANPHAM.MaSP,LOAISP.TenLSP, SANPHAM.TenSP, CTPN.Soluong, CTPN.Gianhap, (CTPN.Soluong * CTPN.Gianhap) as Thanhtien from CTPN, SANPHAM,LOAISP where CTPN.MaSP = SANPHAM.MaSP AND SANPHAM.MaLSP = LOAISP.MaLSP AND CTPN.MaPN = '" + MaPN + "'");
            return dt;
        }
        public bool isSanphamExisit(String TenSP)
        {
            DataTable dt = da.gettable_QR("select MaSP from SANPHAM where TenSP ='" + TenSP + "'");
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
        public void ThemCTPN(String MaPN, String TenSP, int Soluongnhap , int Gianhap, int Giaban,string LoaiSP)
        {
            SqlParameter[] sqlparam = new SqlParameter[6];
            sqlparam[0] = new SqlParameter("@MaPN", SqlDbType.Char);
            sqlparam[0].Value = MaPN;
            sqlparam[1] = new SqlParameter("@TenSP", SqlDbType.NVarChar);
            sqlparam[1].Value = TenSP;
            sqlparam[2] = new SqlParameter("@Soluongnhap", SqlDbType.Int);
            sqlparam[2].Value = Soluongnhap;
            sqlparam[3] = new SqlParameter("@Gianhap", SqlDbType.Int);
            sqlparam[3].Value = Gianhap;
            sqlparam[4] = new SqlParameter("@Giaban", SqlDbType.Int);
            sqlparam[4].Value = Giaban;
            sqlparam[5] = new SqlParameter("@TenLSP", SqlDbType.NVarChar);
            sqlparam[5].Value = LoaiSP;
            da.Excutesp("sp_ThemCTPN", sqlparam);
        }
        public void ThemCTPN1(String MaPN, String TenSP, int Soluongnhap, int Gianhap,String TenLSP,int Dongia)
        {
            SqlParameter[] sqlparam = new SqlParameter[6];
            sqlparam[0] = new SqlParameter("@MaPN", SqlDbType.Char);
            sqlparam[0].Value = MaPN;
            sqlparam[1] = new SqlParameter("@TenSP", SqlDbType.NVarChar);
            sqlparam[1].Value = TenSP;
            sqlparam[2] = new SqlParameter("@Soluongnhap", SqlDbType.Int);
            sqlparam[2].Value = Soluongnhap;
            sqlparam[3] = new SqlParameter("@Gianhap", SqlDbType.Int);
            sqlparam[3].Value = Gianhap;
            sqlparam[4] = new SqlParameter("@TenLSP", SqlDbType.NVarChar);
            sqlparam[4].Value = TenLSP;
            sqlparam[5] = new SqlParameter("@Dongia", SqlDbType.Int);
            sqlparam[5].Value = Dongia;
            da.Excutesp("sp_ThemCTPN1", sqlparam);
        }
        public void CapnhatCTPN(String MaPN, String TenSP, int Soluongnhap, int Gianhap, String TenLSP, int Dongia)
        {
            SqlParameter[] sqlparam = new SqlParameter[6];
            sqlparam[0] = new SqlParameter("@MaPN", SqlDbType.Char);
            sqlparam[0].Value = MaPN;
            sqlparam[1] = new SqlParameter("@TenSP", SqlDbType.NVarChar);
            sqlparam[1].Value = TenSP;
            sqlparam[2] = new SqlParameter("@Soluongnhap", SqlDbType.Int);
            sqlparam[2].Value = Soluongnhap;
            sqlparam[3] = new SqlParameter("@Gianhap", SqlDbType.Int);
            sqlparam[3].Value = Gianhap;
            sqlparam[4] = new SqlParameter("@Dongia", SqlDbType.Int);
            sqlparam[4].Value = Dongia;
            sqlparam[5] = new SqlParameter("@TenloaiSP", SqlDbType.NVarChar);
            sqlparam[5].Value = TenLSP;
            da.Excutesp("sp_Capnhatctpn", sqlparam);
        }
        public void Xoa_CTPN(String MaPN,int MaSP)
        {
            SqlParameter[] sqlparam = new SqlParameter[2];
            sqlparam[0] = new SqlParameter("@MaPN", SqlDbType.Char);
            sqlparam[0].Value = MaPN;
            sqlparam[1] = new SqlParameter("@MaSP", SqlDbType.Int);
            sqlparam[1].Value = MaSP;
            da.Excutesp("Xoa_CTPN", sqlparam);
        }
        public DataTable getLSP()
        {
            DataTable dt = new DataTable();
            dt = da.gettable("sp_HienLSP");
            return dt;
        }
    }
}
