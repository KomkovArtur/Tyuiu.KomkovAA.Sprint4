using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KomkovAA.Sprint4.Task3.V23.Lib
{
    public class DataService : ISprint4Task3V23
    {
        public int Calculate(int[,] array)
        {
            int str = array.GetUpperBound(0) + 1;
            int col = array.Length / str;
            int count = 0;
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        count++;

                    }

                }
            }
            return count;
        }
    }
}
