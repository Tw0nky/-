using System;
namespace Нод_11._2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите B:");
            int b = int.Parse(Console.ReadLine());
            while (a != 0 & b != 0)
            {
                if (a > b)
                    a = a % b;
                else if (b > a)
                    b = b % a;
            }
            Console.WriteLine(a + b);
        }
    }
}