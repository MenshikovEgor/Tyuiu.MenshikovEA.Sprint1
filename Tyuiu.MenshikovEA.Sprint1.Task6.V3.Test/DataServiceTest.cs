using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint1.Task6.V3.Lib;

namespace Tyuiu.MenshikovEA.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string words = "Как же хорошо быть программистом";

            DataService ds = new DataService();

            string res = ds.LastLetterWord(words);

            Assert.AreEqual("кеоьм", res);
        }
    }
}
