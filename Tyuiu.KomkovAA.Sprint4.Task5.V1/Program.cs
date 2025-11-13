using System;
using Tyuiu.KomkovAA.Sprint4.Task5.V1;
using Tyuiu.KomkovAA.Sprint4.Task5.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();
        int[,] mas = new int[5, 5];
        Console.Title = "Спринт #4 | Выполнил: Комков А. А. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                    *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Комков Артур Александрович | РППб-25-1                        *");
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                mas[i, j] = rnd.Next(-9, 8);
            }
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"{mas[i, j]} ");
            }
            Console.WriteLine();

        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int[,] mat2 = ds.Calculate(mas);
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"{mat2[i, j]} ");
            }
            Console.WriteLine();

        }

    }
}