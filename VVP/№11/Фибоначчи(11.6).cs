using System;
namespace Фибоначчи_11._6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N(N>1):");
            int n = int.Parse(Console.ReadLine());
            int a=1, b=1,c=3;
            while (n > b)
            {
                b = a + b;
                a = b - a;
                c++;
            }
            Console.Write($"Порядковый номер = {c}");
        }
    }
}