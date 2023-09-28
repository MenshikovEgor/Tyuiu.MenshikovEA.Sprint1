using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint1.Task7.V25.Lib;

namespace Tyuiu.MenshikovEA.Sprint1.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 1;
            double z = ds.Calculate(x, y);
            double wait = -0.078;

            Assert.AreEqual(wait, z);
        }
    }
}
