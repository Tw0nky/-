using System;
namespace Истинность_7._2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A:");
            int a =int.Parse(Console.ReadLine());
            Console.Write("Введите B:");
            int b =int.Parse(Console.ReadLine());
            Console.Write("Введите C:");
            int c =int.Parse(Console.ReadLine());
            if ((a < b) && (b < c))
                Console.Write("Двойное неравенство A < B < C справедливо");
            else Console.Write("Двойное неравенство A < B < C несправедливо");
        }
    }
}