using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint1.Task3.V9.Lib;

namespace Tyuiu.MenshikovEA.Sprint1.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 156;
            var res1 = ds.ConvertMinutesToHours(a);
            var res2 = ds.ConvertMinutesToMinutes(a);
            Assert.AreEqual(2, res1);
            Assert.AreEqual(36, res2);
        }
    }
}
