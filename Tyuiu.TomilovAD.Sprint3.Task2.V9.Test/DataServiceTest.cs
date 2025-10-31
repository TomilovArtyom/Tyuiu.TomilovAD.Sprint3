using Tyuiu.TomilovAD.Sprint3.Task2.V9.Lib;

namespace Tyuiu.TomilovAD.Sprint3.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 5;
            int startvalue = 1;
            int endvalue = 10;

            double res = ds.GetSumSeries(value, startvalue, endvalue);

            double wait = 0.042;

            Assert.AreEqual(wait, res);
        }
    }
}
