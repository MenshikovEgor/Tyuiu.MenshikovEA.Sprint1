using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint1.Task4.V16.Lib;

namespace Tyuiu.MenshikovEA.Sprint1.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 6;

            Assert.AreEqual(0.1, ds.Calculate(x));

        }
    }
}
