using Tyuiu.TomilovAD.Sprint3.Task1.V19.Lib;

namespace Tyuiu.TomilovAD.Sprint3.Task1.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 1;
            int startvalue = 1;
            int endvalue = 9;

            double res = ds.GetMultiplySeries(value, startvalue, endvalue);

            double wait = 96.895;

            Assert.AreEqual(wait, res);
        }
    }
}
