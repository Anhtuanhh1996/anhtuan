using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business_logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Business_logic.Tests
{
    [TestClass()]
    public class SANPHAMTests
    {
        [TestMethod()]
        public void ThemSPTest()
        {
            SANPHAM SP = new SANPHAM();
            DataTable dt = SP.gettable();
            int Sodong = dt.Rows.Count;
            String TenSP = "SP07";
            int Soluong = 3;
            String TenLSP = "LSP01";
            int Dongia = 200000;
            SP.ThemSP(TenSP, Soluong, TenLSP, Dongia);
            DataTable da = SP.gettable();
            
            Assert.AreEqual(da.Rows.Count, (Sodong +1));
            Assert.AreEqual(da.Rows[da.Rows.Count - 1].ItemArray[1].ToString(), TenSP);
            Assert.AreEqual(int.Parse(da.Rows[da.Rows.Count - 1].ItemArray[2].ToString()), Soluong);
        }
    }
}