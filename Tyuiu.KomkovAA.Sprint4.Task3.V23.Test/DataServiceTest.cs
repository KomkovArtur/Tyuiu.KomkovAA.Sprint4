using Tyuiu.KomkovAA.Sprint4.Task3.V23;
using Tyuiu.KomkovAA.Sprint4.Task3.V23.Lib;
namespace Tyuiu.KomkovAA.Sprint4.Task3.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mat = { { 7, 5, 5, 6, 5 }, { 8, 7, 8, 4, 3 }, { 5, 6, 7, 8, 3},{4, 2, 3, 6, 4 },{ 5, 2, 4, 2, 3} };
            int count = ds.Calculate(mat);
            Assert.AreEqual(13, count);
        }
    }
}
