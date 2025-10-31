using Tyuiu.TomilovAD.Sprint3.Task6.V6.Lib;

namespace Tyuiu.TomilovAD.Sprint3.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = 16;
            int end = 24;

            int wait = 12;
            int res = ds.GetSumTheDivisors(start, end);

            Assert.AreEqual(wait, res);
        }
    }
}
