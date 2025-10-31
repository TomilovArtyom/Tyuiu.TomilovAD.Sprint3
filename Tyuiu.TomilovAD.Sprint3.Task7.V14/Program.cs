using Tyuiu.TomilovAD.Sprint3.Task7.V14.Lib;

namespace Tyuiu.TomilovAD.Sprint3.Task7.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил Томилов А. Д. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Томилов А. Д. | ИСТНб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            int start = -5;
            int end = 5;

            Console.WriteLine("Старт шага" + start);
            Console.WriteLine("Конец шага" + end);

            int len = ds.GetMassFunction(start, end).Length;

            double[] array;
            array = new double[len];

            array = ds.GetMassFunction(start, end);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("x = " + start + ", f(x) = " + array[i]);
                start++;
            }    

            Console.ReadLine();
        }
    }
}