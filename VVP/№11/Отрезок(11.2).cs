using System;
namespace Отрезок_11._2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите А:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите B:");
            int b = int.Parse(Console.ReadLine());
            while (a >= b)
                a = a - b;
            Console.WriteLine($"Длина незанятой части отрезка A={a}");
        }
    }
}