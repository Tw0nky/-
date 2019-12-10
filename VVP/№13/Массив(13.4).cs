using System;
using static System.Console;
namespace Массив_13._4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите размерность массива:");
            int n = int.Parse(ReadLine());
            int[] m = new int[n];
            int i;
            for (i = 0; i < n; i++)
            {
                Write("Введите элементы массива:");
                m[i] = int.Parse(ReadLine());
            }
            for (i = 0; i < n / 2; i++)
                Write($"{m[i]} {m[n - 1 - i]} ");
            if (n % 2 != 0)
                Write(m[(n / 2 + 1)]);
        }
    }
}