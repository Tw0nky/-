using System;
namespace Квадрат_10._3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N:");
            int n = int.Parse(Console.ReadLine());
            int r=0;
            for (int i = 1; i <= (2 * n - 1); i=i+2) {
                r=i; 
                Console.WriteLine(r);
            }
            Console.WriteLine($"Квадрат = {n*n}");
        }
    }
}