using System;
namespace Quarter_12._4_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 4; i++)
            {
                Console.Write("Введите X:");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Введите Y:");
                int y = int.Parse(Console.ReadLine());
                int Quarter(double x, double y)
                {
                    if (x > 0 && y > 0) return 1;
                    if (x < 0 && y < 0) return 3;
                    if (x < 0 && y > 0) return 2;
                    if (x > 0 && y < 0) return 4;
                    return 0;
                }
                Console.WriteLine($"Данная точка лежит в {Quarter(x, y)} четверти");
            }
        }
    }
}