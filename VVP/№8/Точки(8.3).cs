using System;
namespace Точки_8._3_
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
            if (Math.Abs(a - b) < Math.Abs(a - c))
                Console.Write($"Точка B ближе к точке A. Её расстояние от точки A = {Math.Abs(a-b)} ");
            else Console.Write($"Точка C ближе к точке A. Её расстояние от точки A = {Math.Abs(a-c)}");
        }
    }
}