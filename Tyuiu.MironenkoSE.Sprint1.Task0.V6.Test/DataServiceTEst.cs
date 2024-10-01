using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MironenkoSE.Sprint1.Task0.V6.Lib;
namespace Tyuiu.MironenkoSE.Sprint1.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTEst
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(15,res);
        }
    }
}
