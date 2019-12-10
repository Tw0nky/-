using System;
namespace Треугольник_7._6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите B:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите C:");
            int c = int.Parse(Console.ReadLine());
            if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
                Console.Write("Треугольник со сторонами a, b, c является прямоугольным");
            else Console.WriteLine("Треугольник со сторонами a, b, c не является прямоугольным");
        }
    }
}