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
    public class CTHD
    {
        Data da = new Data();
        public DataTable gettable(String MaHD)
        {
            DataTable dt = new DataTable();
            dt = da.gettable_QR("select CTHD.MaSP, SANPHAM.TenSP, CTHD.Soluong, CTHD.Dongia, (CTHD.Soluong * CTHD.Dongia) as Thanhtien from CTHD, SANPHAM,HOADON where CTHD.MaSP = SANPHAM.MaSP AND  CTHD.MaHD = '"+ MaHD + "'AND CTHD.MaHD = HOADON.MaHD");
            return dt;
        }
        public void ThemCTHD(string MaHD, string TenSP, int Soluong, int Dongia,int Gianhap)
        {
            SqlParameter[] sqlparam = new SqlParameter[5];
            sqlparam[0] = new SqlParameter("@MaHD", SqlDbType.Char);
            sqlparam[0].Value = MaHD;
            sqlparam[1] = new SqlParameter("@TenSP", SqlDbType.NVarChar);
            sqlparam[1].Value = TenSP;
            sqlparam[2] = new SqlParameter("@Soluong", SqlDbType.Int);
            sqlparam[2].Value = Soluong;
            sqlparam[3] = new SqlParameter("@Dongia", SqlDbType.Int);
            sqlparam[3].Value = Dongia;
            sqlparam[4] = new SqlParameter("@Gianhap", SqlDbType.Int);
            sqlparam[4].Value = Gianhap;
            da.Excutesp("sp_ThemCTHD", sqlparam);
        }
        public int soLuong (string TenSP)
        {
            DataTable dt = new DataTable();
            dt = da.gettable_QR("select Soluong from SANPHAM where TenSP = '" + TenSP + "'");
            int soLuong = int.Parse(dt.Rows[0][0].ToString());
            return soLuong;
        }
        public int donGia (string TenSP)
        {
            DataTable dt = new DataTable();
            dt = da.gettable_QR("select Dongia from SANPHAM where TenSP = '" + TenSP + "'");
            int dongia = int.Parse(dt.Rows[0][0].ToString());
            return dongia;
        }
        public int giaNhap(string TenSP)
        {
            DataTable dt = new DataTable();
            dt = da.gettable_QR("select Gianhap from SANPHAM where TenSP = '" + TenSP + "'");
            int gianhap = int.Parse(dt.Rows[0][0].ToString());
            return gianhap;
        }
        public void suaCTHD(String MaHD, string TenSP, int Soluong, int Dongia, int Gianhap)
        {
            SqlParameter[] sqlparam = new SqlParameter[5];
            sqlparam[0] = new SqlParameter("@MaHD", SqlDbType.Char);
            sqlparam[0].Value = MaHD;
            sqlparam[1] = new SqlParameter("@TenSP", SqlDbType.NVarChar);
            sqlparam[1].Value = TenSP;
            sqlparam[2] = new SqlParameter("@Soluong", SqlDbType.Int);
            sqlparam[2].Value = Soluong;
            sqlparam[3] = new SqlParameter("@Dongia", SqlDbType.Int);
            sqlparam[3].Value = Dongia;
            sqlparam[4] = new SqlParameter("@Gianhap", SqlDbType.Int);
            sqlparam[4].Value = Gianhap;
            da.Excutesp("sp_Capnhatcthd", sqlparam);
        }
        public void XoaCTHD(String MaHD, int MaSP)
        {
            SqlParameter[] sqlparam = new SqlParameter[2];
            sqlparam[0] = new SqlParameter("@MaHD", SqlDbType.Char);
            sqlparam[0].Value = MaHD;
            sqlparam[1] = new SqlParameter("@MaSP", SqlDbType.Int);
            sqlparam[1].Value = MaSP;
            da.Excutesp("sp_XoaCTHD", sqlparam);
        }
        public int Tongtienhd(string MaHD)
        {
            int tt = 0;
            DataTable dt = new DataTable();
            dt = da.gettable_QR("select MaHD, sum(Soluong * Dongia) as [Tongtien] from CTHD where MaHD = '" + MaHD + "'group by MaHD");
            if(dt.Rows.Count > 0)
            {
                 tt = int.Parse(dt.Rows[0]["Tongtien"].ToString());
            }
            return tt; 
        }
        public string TenSP(string TenSP)
        {
            string Tensp = "";
            DataTable dt = new DataTable();
            dt = da.gettable_QR("select TenSP from SANPHAM where TenSP = '" + TenSP + "'");
            if(dt.Rows.Count > 0)
            {
                Tensp = dt.Rows[0][0].ToString();
            }
            return Tensp;
        }
        public bool isSanphamExist(string TenSP,string MaHD)
        { 
            DataTable dt = da.gettable_QR("select CTHD.MaSP,CTHD.MaHD,SANPHAM.TenSP from HOADON, CTHD,SANPHAM where CTHD.MaSP = SANPHAM.MaSP AND SANPHAM.TenSP ='" + TenSP + "'AND CTHD.MaHD = '" +MaHD+ "'");
            if(dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
    }
}
