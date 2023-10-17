using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskihVA.Sprint2.Review.Lib;

namespace Tyuiu.KosovskihVA.Sprint2.Review.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.2;
            double y = 1.2;
            bool wait = ds.CheckDotInShadedArea(x, y);
            bool res = true;
            Assert.AreEqual(wait, res);
        }
    }
}
