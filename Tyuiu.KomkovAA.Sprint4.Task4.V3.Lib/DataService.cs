using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KomkovAA.Sprint4.Task4.V3.Lib
{
    public class DataService : ISprint4Task4V3
    {
        public int Calculate(int[,] matrix)
        {
            int str = matrix.GetUpperBound(0) + 1;
            int col = matrix.Length / str;
            int sum = 0;
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        sum += matrix[i, j];

                    }

                }
            }
            return sum;
        }
    }
}
