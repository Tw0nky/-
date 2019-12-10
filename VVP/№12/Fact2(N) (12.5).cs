using System;
namespace Fact2_N___12._5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N:");
            double n = double.Parse(Console.ReadLine());
            double Fact2(double n)
            {
                if (n <= 1) return 1;
                else return n * Fact2(n - 2);
            }
            Console.WriteLine($"Двойной факториал = {Fact2(n)}");    
        }
    }
}