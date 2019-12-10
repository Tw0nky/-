using System;
using static System.Console;
namespace Нечетные_номера_массив_13._5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите размер массива:");
            int n = int.Parse(ReadLine());
            int[] m = new int[n];
            int i;
            for (i = 0; i < n; i++)
            {
                Write("Введите элемент массива:");
                m[i] = int.Parse(ReadLine());
            }
            for (i = 0; i < n; i+=2)              
                 Write($"{m[i]} ");
            for (i =n-1; i >-1; i-= 2)
                 Write($"{m[i]} ");
        }
    }
}