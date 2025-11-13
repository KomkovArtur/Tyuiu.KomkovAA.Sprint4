using Tyuiu.KomkovAA.Sprint4.Task5.V1;
using Tyuiu.KomkovAA.Sprint4.Task5.V1.Lib;
namespace Tyuiu.KomkovAA.Sprint4.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mat = { { 7, 9, 7, 8, 6 }, { 4, 4, 4, 8, 6 }, { 7, 9, 6, 7, 6 }, { 7, 5, 4, 9, 8 }, { 9, 6, 4, 9, 8 } };
            int[,] sra = { { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 } };
            int[,] mat2 = ds.Calculate(mat);
            CollectionAssert.AreEqual(sra, mat2);
            
        }
    }
}
