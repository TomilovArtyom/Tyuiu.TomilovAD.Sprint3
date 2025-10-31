using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TomilovAD.Sprint3.Task1.V19.Lib
{
    public class DataService : ISprint3Task1V19
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multseries = 0;
            while (startValue <= stopValue)
            {
                multseries = multseries + (Math.Cos(value) + startValue / 4);
                startValue++;
            }
            return Math.Round(multseries, 3);
        }
    }
}
