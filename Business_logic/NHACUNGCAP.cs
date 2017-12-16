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
    public class NHACUNGCAP
    {
        Data da = new Data();
        public DataTable gettable()
        {
            DataTable dt = new DataTable();
            dt = da.gettable_QR("Select * from NHACUNGCAP");
            return dt;
        }
        public bool isNccExist(string TenNCC)
        {
            DataTable dt = da.gettable_QR("select MaNCC from NHACUNGCAP where TenNCC ='" + TenNCC + "'");
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
        public void ThemNCC(String TenNCC, string Diachi, string SDT, String Email)
        {
            SqlParameter[] sqlparam = new SqlParameter[4];
            sqlparam[0] = new SqlParameter("@TenNCC", SqlDbType.NVarChar);
            sqlparam[0].Value = TenNCC;
            sqlparam[1] = new SqlParameter("@Diachi", SqlDbType.NVarChar);
            sqlparam[1].Value = Diachi;
            sqlparam[2] = new SqlParameter("@SDT", SqlDbType.Text);
            sqlparam[2].Value = SDT;
            sqlparam[3] = new SqlParameter("@Email", SqlDbType.Text);
            sqlparam[3].Value = Email;
            da.Excutesp("sp_ThemNCC", sqlparam);
        }
    }
}
