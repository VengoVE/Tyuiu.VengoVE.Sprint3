using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VengoVE.Sprint3.Task1.V24.Lib
{
    public class DataService : ISprint3Task1V24
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 1;
            while (startValue <= stopValue)
            {
                sumSeries = sumSeries + (Math.Pow((2 / 6 + Math.Pow(value, startValue)), startValue));
                startValue++;
            }
            return Math.Round(sumSeries, 3);
        }

        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            throw new NotImplementedException();
        }
    }
}
