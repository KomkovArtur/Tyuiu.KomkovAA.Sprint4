using Tyuiu.KomkovAA.Sprint4.Task1.V19.Lib;
namespace Tyuiu.KomkovAA.Sprint4.Task1.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] mas = new int[12] { 6, 6, 9, 6, 9, 3, 8, 2, 9, 5, 7, 4 };
            DataService ds = new DataService();
            int ch = ds.Calculate(mas);
            Assert.AreEqual(32, ch);
        }
    }
}
