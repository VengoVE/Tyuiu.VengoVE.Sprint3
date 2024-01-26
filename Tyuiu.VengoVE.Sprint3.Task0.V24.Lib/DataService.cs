﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VengoVE.Sprint3.Task0.V25.Lib
{
    public class DataService : ISprint3Task0V25
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
                double sumSeries = 0;
                int i;
                for (i = startValue; i <= stopValue; i++)
                {
                    sumSeries = sumSeries + (Math.Pow((3 / i + Math.Pow(value, -i)), 2));
                }
                return Math.Round(sumSeries, 3);
        }
    }
}
