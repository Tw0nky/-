using System;
namespace Переменные_8._1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A :");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите B :");
            int b = int.Parse(Console.ReadLine());
            if ((a != b) && (a > b))
            {
                b = a;
            }
                if ((a != b) && (a < b))
            {  
                a = b;
            }
            else { a = 0; b = 0; }
            Console.WriteLine($"Переменная A = {a}  и B = {b}");
        }
    }
}