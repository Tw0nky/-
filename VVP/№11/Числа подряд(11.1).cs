using System;
namespace Числа_подряд_11._1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A(A<B):");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число B(B>A):");
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
                for (int j = 0; j < i; j++)
                    Console.WriteLine(i);
        }
    }
}