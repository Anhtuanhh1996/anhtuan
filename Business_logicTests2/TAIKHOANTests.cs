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
    public class TAIKHOANTests
    {
        [TestMethod()]
        public void ThemTKTest()
        {
            TAIKHOAN TK = new TAIKHOAN();
            DataTable dt = TK.gettable();
            int truoc = dt.Rows.Count;
            string Email = "anhtuan2@gmail.com";
            string Matkhau = "1234567";
            string Hoten = "Nguyễn Anh Tuấn 2";
            string Diachi = "Bắc Giang";
            string TenQ = "Admin";
            bool Gioitinh = true;
            DateTime Ngaysinh = DateTime.Parse("01/01/1996");
            TK.ThemTK(Email, Matkhau, Hoten, Ngaysinh, Diachi, Gioitinh, TenQ);
            DataTable dt2 = TK.gettable();
            int sau = dt2.Rows.Count;
            Assert.AreEqual(sau, (truoc + 1));
            Assert.AreEqual(dt2.Rows[dt2.Rows.Count - 1].ItemArray[3].ToString().Trim(), Email);
            Assert.AreEqual(dt2.Rows[dt2.Rows.Count - 1].ItemArray[4].ToString().Trim(), Matkhau);
            Assert.AreEqual(dt2.Rows[dt2.Rows.Count - 1].ItemArray[5].ToString().Trim(), Hoten);
            Assert.AreEqual(dt2.Rows[dt2.Rows.Count - 1].ItemArray[7].ToString().Trim(), Diachi);
            Assert.AreEqual(dt2.Rows[dt2.Rows.Count - 1].ItemArray[6].ToString().Trim(), Ngaysinh.ToString());
            Assert.AreEqual(dt2.Rows[dt2.Rows.Count - 1].ItemArray[2].ToString().Trim(), TenQ);
            Assert.AreEqual(dt2.Rows[dt2.Rows.Count - 1].ItemArray[8], Gioitinh);
        }

        [TestMethod()]
        public void SuaTKTest()
        {
            TAIKHOAN TK = new TAIKHOAN();
            DataTable dt = TK.gettable();
            int MaTK = 32;
            string Email = "anhtuan2@gmail.com";
            string Matkhau = "1234567";
            string Hoten = "Nguyễn Anh Tuấn 2";
            string Diachi = "Bắc Giang";
            string TenQ = "Admin";
            bool Gioitinh = true;
            DateTime Ngaysinh = DateTime.Parse("01/01/1996");
            TK.SuaTK(MaTK, Email, Matkhau, Hoten, Ngaysinh, Diachi, Gioitinh, TenQ);
            DataTable dt2 = TK.getMaTK(MaTK);
            Assert.AreEqual(dt2.Rows[0].ItemArray[5].ToString().Trim(), Hoten);
            Assert.AreEqual(dt2.Rows[0].ItemArray[7].ToString().Trim(), Diachi);
            Assert.AreEqual(dt2.Rows[0].ItemArray[6].ToString().Trim(), Ngaysinh.ToString());
            Assert.AreEqual(dt2.Rows[0].ItemArray[2].ToString().Trim(), TenQ);
            Assert.AreEqual(dt2.Rows[0].ItemArray[8], Gioitinh);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod()]
        public void XoaTKTest()
        {
            TAIKHOAN TK = new TAIKHOAN();
            DataTable dt = TK.gettable();
            int truoc = dt.Rows.Count;
            int MaTK = 32;
            TK.XoaTK(MaTK);
            DataTable maTK = TK.getMaTK(MaTK);
            DataTable dt2 = TK.gettable();
            int sau = dt2.Rows.Count;
            Assert.AreEqual(truoc, (sau + 1));
            Assert.AreEqual(maTK.Rows.Count, 0);
        }
    }
}