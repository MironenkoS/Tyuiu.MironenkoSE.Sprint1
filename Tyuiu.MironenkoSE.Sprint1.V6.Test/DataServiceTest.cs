using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MironenkoSE.Sprint1.V6.Lib2;
namespace Tyuiu.MironenkoSE.Sprint1.V6.Test2
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds= new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(21,res);
        }
    }
}
