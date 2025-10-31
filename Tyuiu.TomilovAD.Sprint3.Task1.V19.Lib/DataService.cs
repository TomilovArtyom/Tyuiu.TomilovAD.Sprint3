﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TomilovAD.Sprint3.Task1.V19.Lib
{
    public class DataService : ISprint3Task1V19
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multseries = 1;
            while (startValue <= stopValue)
            {
                multseries = multseries * ((Math.Cos(value*(Math.PI/180))) + (startValue / 4));
                startValue++;
            }
            return multseries;
        }
    }
}
