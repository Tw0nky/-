using System;
namespace Конфеты_10._1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цену 1 кг конфет:");
            int c = int.Parse(Console.ReadLine());
            for (double i = 1; i <= 10; i++)
                Console.WriteLine($"{c*i/10}") ;
        }
    }
}