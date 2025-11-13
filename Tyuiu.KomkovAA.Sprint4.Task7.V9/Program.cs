using Tyuiu.KomkovAA.Sprint4.Task7.V9;
using Tyuiu.KomkovAA.Sprint4.Task7.V9.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Комков А. А. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                    *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Комков Артур Александрович | РППб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ: Дана строка из одноразрядных цифр 864299753. Преобразуйте      *");
        Console.WriteLine("* ее в матрицу 3 на 3 и подсчитайте количество четных чисел.              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[,] mat = new int[3,3];
        string str = "864299753";
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                mat[i, j] = int.Parse(str[i * 3 + j].ToString());
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{mat[i, j]} ");
            }
            Console.WriteLine();

        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(3,3,str));
    }
}