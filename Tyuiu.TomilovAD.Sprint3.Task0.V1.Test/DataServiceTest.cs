using Tyuiu.TomilovAD.Sprint3.Task0.V1.Lib;

namespace Tyuiu.TomilovAD.Sprint3.Task0.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 4;
            int startvalue = 1;
            int endvalue = 15;

            double res = ds.GetSumSeries(value, startvalue, endvalue);

            double wait = 375;

            Assert.AreEqual(wait, res);
        }
    }
}
