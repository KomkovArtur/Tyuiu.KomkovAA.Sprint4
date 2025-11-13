using Tyuiu.KomkovAA.Sprint4.Task1.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Комков А. А. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #19                                                             *");
        Console.WriteLine("* Выполнил: Комков Артур Александрович | РППб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите количество элементов массива");
        int len = Convert.ToInt32(Console.ReadLine());
        int[] mas = new int[len];
        for (int i = 0; i < len; i++)
        {
            Console.WriteLine($"Введите элемент {i} массива");
            mas[i] = Convert.ToInt32(Console.ReadLine());
        }
        int res = 0;
        for (int i = 0;i < len; i++)
        {
            if (mas[i] % 2 == 0)
            {
                res += mas[i];
            }
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        for (int i = 0; i < len; i++)
        {
            Console.WriteLine(mas[i]);
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.Write(res);
    }
}