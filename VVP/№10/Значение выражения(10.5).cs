using System;
namespace Значение_выражения_10._5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A:");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Введите N:");
            float n = float.Parse(Console.ReadLine());
            double k = 1;double r = 1;
            for (int i = 1; i <= n; i++)
            {
                k = a * k;
                k = k * (-1);
                r = r + k;
            }
            Console.WriteLine(r);
        }
    }
}