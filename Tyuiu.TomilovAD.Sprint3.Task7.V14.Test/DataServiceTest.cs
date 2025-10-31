using Tyuiu.TomilovAD.Sprint3.Task7.V14.Lib;

namespace Tyuiu.TomilovAD.Sprint3.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int start = -5;
            int end = 5;

            int len = end - start + 1;

            double[] waitArray;
            waitArray = new double[len];

            waitArray[0] = -19.62;
            waitArray[1] = -17.12;
            waitArray[2] = -18.15;
            waitArray[3] = -63.13;
            waitArray[4] = -24.92;
            waitArray[5] = 0;
            waitArray[6] = -1.46;
            waitArray[7] = 1.57;
            waitArray[8] = 6.38;
            waitArray[9] = 32.78;
            waitArray[10] = 225.11;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, end);
            CollectionAssert.AreEqual(waitArray, res);
        }
    }
}
