using System;
namespace Произведение_9._2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N:");
            int n = int.Parse(Console.ReadLine());
            double r=1;
            for (int i = 0; i <= n; i++)
               r = r*(i * 0.1 + 1);
                Console.WriteLine($"{r}");
        }
    }
}