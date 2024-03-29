﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VengoVE.Sprint3.Task0.V25.Lib;

namespace Tyuiu.VengoVE.Sprint3.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double value = 5;
            int startValue = 1;
            int stopValue = 7;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 1;

            Assert.AreEqual(wait, res);

        }
    }
}
