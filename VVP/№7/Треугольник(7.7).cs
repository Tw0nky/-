using System;
namespace Треугольник_7._7_
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
            if (a + b > c && a + c > b && b + c > a)
                Console.Write("Треугольник со сторонами a, b, c существует");
            else Console.WriteLine("Треугольник со сторонами a, b, c не существует");
        }
    }
}