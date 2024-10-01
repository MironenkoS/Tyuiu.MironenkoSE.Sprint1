using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MironenkoSE.Sprint1.Task3.V17.Lib;
namespace Tyuiu.MironenkoSE.Sprint1.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            var x = 5.701;

            bool res = ds.ZeroCheck(x);
            Assert.IsTrue(res);
        }
        public void TestMethod2()
        {
            DataService ds = new DataService();
            var x = 5.711;
            bool res = ds.ZeroCheck(x);
            Assert.IsTrue(res);

        }
    }
}