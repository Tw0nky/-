using System;
namespace Вклад_11._4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите процент вклада (0<P<25):");
            int p = int.Parse(Console.ReadLine());
            float v = 1000;int m = 1;;
            while (v <= 1100)
            {
                ++m;
                v = v + (v * p / 100);
            }
            Console.WriteLine($"Количество месяцев {m}");
            Console.Write($"Итоговый размер вклада {v}");
        }
    }
}