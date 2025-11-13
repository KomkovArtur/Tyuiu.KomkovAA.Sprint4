using Tyuiu.KomkovAA.Sprint4.Task4.V3;
using Tyuiu.KomkovAA.Sprint4.Task4.V3.Lib;
namespace Tyuiu.KomkovAA.Sprint4.Task4.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mat = { { 7, 9, 7, 8, 6 }, { 4, 4, 4, 8, 6 }, { 7, 9, 6, 7, 6 }, { 7, 5, 4, 9, 8 }, { 9, 6, 4, 9, 8 } };
            int count = ds.Calculate(mat);
            Assert.AreEqual(85, count);
        }
    }
}
