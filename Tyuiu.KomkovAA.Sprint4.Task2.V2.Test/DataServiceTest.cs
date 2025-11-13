using Tyuiu.KomkovAA.Sprint4.Task2.V2;
using Tyuiu.KomkovAA.Sprint4.Task2.V2.Lib;
namespace Tyuiu.KomkovAA.Sprint4.Task2.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] mas = new int[11] { 6, 6, 9, 6, 9, 3, 8, 2, 9, 5, 7};
            DataService ds = new DataService();
            int ch = ds.Calculate(mas);
            Assert.AreEqual(76545, ch);
        }
    }
}
