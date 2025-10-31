using Tyuiu.TomilovAD.Sprint3.Task4.V14.Lib;

namespace Tyuiu.TomilovAD.Sprint3.Task4.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = -5;
            int y = 5;
            double wait = 6.263;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(res, wait);
        }
    }
}
