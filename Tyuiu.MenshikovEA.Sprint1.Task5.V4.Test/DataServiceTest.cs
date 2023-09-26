using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint1.Task5.V4.Lib;

namespace Tyuiu.MenshikovEA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpectation()
        {
            DataService ds = new DataService();

            int time = 12440;

            Assert.AreEqual(3, ds.SecondsToHours(time));

        }
    }
}
