using System;
namespace Сумма_10._4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите вещественное число A:");
            float a =float.Parse(Console.ReadLine());
            Console.Write("Введите целое число N:");
            int n = int.Parse(Console.ReadLine());
            double r=1;
            for (int i = 1; i <= n; i++)
                r = r+Math.Pow(a, i);
            Console.Write(r);
        }
    }
}