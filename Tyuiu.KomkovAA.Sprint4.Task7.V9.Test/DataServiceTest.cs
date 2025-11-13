using Tyuiu.KomkovAA.Sprint4.Task7.V9;
using Tyuiu.KomkovAA.Sprint4.Task7.V9.Lib;
namespace Tyuiu.KomkovAA.Sprint4.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {   
            DataService ds = new DataService();
            string str = "864299753";
            int res = ds.Calculate(3, 3, str);
            Assert.AreEqual(4,res);
        }
    }
}
