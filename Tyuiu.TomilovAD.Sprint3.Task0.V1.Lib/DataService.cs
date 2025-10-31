﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TomilovAD.Sprint3.Task0.V1.Lib
{
    public class DataService : ISprint3Task0V1
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            {
                value = 4;
                double sumSeries = 0;
                int i;
                for (i = startValue; i <= stopValue; i++)
                {
                    sumSeries = sumSeries + ((Math.Pow(value, 2) * i) + 1);
                }
                return Math.Round(sumSeries, 3);
            }
        }
    }
}
