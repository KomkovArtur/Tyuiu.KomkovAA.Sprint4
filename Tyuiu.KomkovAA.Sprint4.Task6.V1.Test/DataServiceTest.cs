using Tyuiu.KomkovAA.Sprint4.Task6.V1;
using Tyuiu.KomkovAA.Sprint4.Task6.V1.Lib;
namespace Tyuiu.KomkovAA.Sprint4.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] str = new string[] { "Яблоко", "Банан", "Вишня", "Драгонфрут", "Бузина", "Инжир", "Виноград" };
            int res = ds.Calculate(str);
            Assert.AreEqual(2, res);

        }
    }
}
