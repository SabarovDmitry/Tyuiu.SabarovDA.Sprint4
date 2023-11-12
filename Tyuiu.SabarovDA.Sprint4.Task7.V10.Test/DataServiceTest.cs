﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SabarovDA.Sprint4.Task7.V10.Lib;
namespace Tyuiu.SabarovDA.Sprint4.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 3;
            int m = 4;
            int[,] mtrx = new int[n, m];
            string value = "695847142536";
            int res = ds.Calculate(n, m, value);
            int wait = 30;
            Assert.AreEqual(wait, res);
        }
    }
}
