using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Tyuiu.MironenkoSE.Sprint1.Task2.V12.Lib;

namespace Tyuiu.MironenkoSE.Sprint1.Tas2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds= new DataService();
            int value = 3;
            int valueTwo=6;
            int valueTree = 9;
            var res = ds.CalculateParallelepipedVolume(value,valueTwo , valueTree);
            Assert.AreEqual(162, res);

        }
    }
}
