using Tyuiu.KomkovAA.Sprint4.Task0.V30;
using Tyuiu.KomkovAA.Sprint4.Task0.V30.Lib;
namespace Tyuiu.KomkovAA.Sprint4.Task0.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] ch = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            int res = 30;
            int chres = ds.GetSumEvenArrEl(ch);
            Assert.AreEqual(res, chres);
        }
    }
}
