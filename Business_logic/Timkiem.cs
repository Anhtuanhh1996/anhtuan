using Data_logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_logic
{
   public class TIMKIEM
    {
        Data da = new Data();
        public DataTable dt1(string chuoitk)
        {
            DataTable dt = new DataTable();
            dt = da.gettable_QR("select MaSP as [Mã sản phẩm],TenSP as [Tên sản phẩm],Soluong as [Số lượng],MaLSP as [Mã loại SP],Dongia as [Giá bán],Gianhap as [Giá nhập] from SANPHAM where   TenSP = '" + chuoitk + "'");
            return dt;
        }
        public DataTable dt2(string chuoitk)
        {
            DataTable dt = new DataTable();
            dt = da.gettable_QR("select MaNCC as [Mã nhà cung cấp],TenNCC as [Tên nhà cung cấp],Diachi as [Địa chỉ],SDT as [Số điện thoại],Email as [Email] from NHACUNGCAP where  (TenNCC='" + chuoitk + "' or Diachi='" + chuoitk + "'or SDT='" + chuoitk + "' or Email='" + chuoitk + "')");
            return dt;
        }
        public DataTable dt3(string chuoitk)
        {
            DataTable dt = new DataTable();
            dt = da.gettable_QR("select MaKH as [Mã Khách hàng],TenKH as [Tên khách hàng],Diachi as [Địa chỉ],SDT as [Số điện thoại],Gioitinh as [Giới tính] from KHACHHANG where (TenKH='" + chuoitk + "' or Diachi='" + chuoitk + "' or SDT='" + chuoitk + "')");
            return dt;
        }
    }
}
