using System;
namespace Два_числа__8._2_
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
            if (a > b)
                Console.Write($"Cумму двух наибольших={a+b}");
            if (b > c)           
                Console.Write($"Cумму двух наибольших={a+c}");                         
             if (c > a)
                Console.Write($"Cумму двух наибольших={c+b}");
            else
                Console.Write($"Cумму двух наибольших={b+a}");
        }
    }
}