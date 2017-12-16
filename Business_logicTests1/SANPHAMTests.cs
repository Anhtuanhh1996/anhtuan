using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business_logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Data_logic;

namespace Business_logic.Tests
{
    [TestClass()]
    public class SANPHAMTests
    {
        [TestMethod()]
        
        public void ThemSPTest()
        {
            Data da = new Data();
            SqlParameter[] sqlparam = new SqlParameter[4];
            sqlparam[0] = new SqlParameter("@TenSP", SqlDbType.NVarChar);
            sqlparam[0].Value = "Sp07";
            sqlparam[1] = new SqlParameter("@Soluong", SqlDbType.Int);
            sqlparam[1].Value = "20";
            sqlparam[2] = new SqlParameter("@TenLSP", SqlDbType.Text);
            sqlparam[2].Value = "LSP01";
            sqlparam[3] = new SqlParameter("@Dongia", SqlDbType.Int);
            sqlparam[3].Value = 200000;
            da.Excutesp("sp_Themsanpham", sqlparam);
            Assert.Fail();
        }
    }
}