using System;
namespace Строка_описание_8._5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            int x = int.Parse(Console.ReadLine());
            if (x == 0)
                Console.Write("Число нулевое");
            else
            {
                if (x > 0)
                    Console.Write("Число положительное");
                else Console.Write("Число отрицательное");
                if (x % 2 == 0)
                    Console.Write(" четное");
                else
                    Console.Write(" нечетное");
            }
        }
    }
}