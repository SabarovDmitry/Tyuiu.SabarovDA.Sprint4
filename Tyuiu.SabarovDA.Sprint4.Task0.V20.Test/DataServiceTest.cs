﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SabarovDA.Sprint4.Task0.V20.Lib; 
namespace Tyuiu.SabarovDA.Sprint4.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };
            int wait = 24576;
            int res = ds.GetMultEvenArrEl(numsArray);
            Assert.AreEqual(wait, res);

        }
    }
}
