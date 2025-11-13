using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KomkovAA.Sprint4.Task6.V1.Lib
{
    public class DataService : ISprint4Task6V1
    {
        public int Calculate(string[] array)
        {
            int res = array.Count(x => x.Length > 6);

            return res;
        }
    }
}
