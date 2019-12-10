using System;

namespace Координаты_8._4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите X:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите Y:");
            int y = int.Parse(Console.ReadLine());
                if (x > 0 && y > 0)
                    Console.Write("Данная точка лежит в 1 четвери");
                if (x < 0 && y < 0)
                    Console.Write("Данная точка лежит в 3 четвери");
                if (x < 0 && y > 0)
                    Console.Write("Данная точка лежит в 2 четвери");
                if (x > 0 && y < 0)
                    Console.Write("Данная точка лежит в 4 четвери");
        }
    }
}
