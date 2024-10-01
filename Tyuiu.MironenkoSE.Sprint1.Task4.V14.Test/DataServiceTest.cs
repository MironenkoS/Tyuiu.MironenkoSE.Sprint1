﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MironenkoSE.Sprint1.Task4.V14.Lib;
namespace Tyuiu.MironenkoSE.Sprint1.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 6;
            double wait = 0.015;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
