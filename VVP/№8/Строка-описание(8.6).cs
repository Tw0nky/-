using System;
namespace Строка_описание_8._6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число в диапазоне от 1 до 999:");
            int a = int.Parse(Console.ReadLine());
            if (a%2==0) Console.Write("Число четное");
            else Console.Write("Число нечетное");
            if (a<10) Console.Write(" однозначное");
            if (a>9&&a<100) Console.Write(" двузначное");
            if (a > 99 && a < 1000) Console.Write(" трехзначное");
        }
    }
}