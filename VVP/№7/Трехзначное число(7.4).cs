using System;
namespace Трехзначное_число_7._4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число:");
            int a = int.Parse(Console.ReadLine());
            if ((a / 100 > a % 100 / 10 && a % 100 / 10 > a % 10) || (a / 100 < a % 100 / 10 && a % 100 / 10 < a % 10))
                Console.Write("Цифры данного числа образуют возрастающую или убывающую последовательность");
            else Console.WriteLine("Цифры данного числа не образуют возрастающую или убывающую последовательность");
        }
    }
}