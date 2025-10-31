using Tyuiu.TomilovAD.Sprint3.Task3.V21.Lib;

namespace Tyuiu.TomilovAD.Sprint3.Task3.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            char c = 'e';
            string x = "f3g5ht g4j 34kg4";
            string wait = "fegeht gej eekge";
            string res = ds.ReplaceNumOnChar(x, c);
            Assert.AreEqual(wait, res);
        }
    }
}
