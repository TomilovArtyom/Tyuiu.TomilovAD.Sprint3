using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TomilovAD.Sprint3.Task7.V14.Lib
{
    public class DataService : ISprint3Task7V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] Array;
            int len = (stopValue - startValue) + 1;
            Array = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    Array[count] = 0;
                    count++;
                }
                else
                {
                    y = Math.Round((2 * x - 4 + ((2 * x - 1) / (Math.Sin(x) + 1))), 2);
                    Array[count] = y;
                    count++;
                }
            }
            return Array;
        }
    }
}
