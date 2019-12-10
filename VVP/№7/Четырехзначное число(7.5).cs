using System;
namespace Четырехзначное_число_7._5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите четырехзначное число:");
                int a = int.Parse(Console.ReadLine());
            if ((a / 1000 == a % 100 % 10) && (a / 1000 % 100 == a /100/10))
                Console.Write("Данное число читается одинаково слева направо и справа налево");
            else Console.WriteLine("Данное число не читается одинаково слева направо и справа налево");
        }
    }
}