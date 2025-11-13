using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KomkovAA.Sprint4.Task5.V1.Lib
{
    public class DataService : ISprint4Task5V1
    {
        public int[,] Calculate(int[,] matrix)
        {
            int str = matrix.GetUpperBound(0) + 1;
            int col = matrix.Length / str;
            int sum = 0;
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j]  > 0)
                    {
                        matrix[i, j] = 1;

                    }

                }
            }
            return matrix;
        }
    }
}
