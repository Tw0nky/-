using System;
namespace Четное_двузначное_7._3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0 && a > 9 && a < 100)
                Console.Write("Данное число является четным двузначным");
            else Console.WriteLine("Данное число не является четным двузначным");
        }
    }
}