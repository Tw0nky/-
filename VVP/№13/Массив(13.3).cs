using System;
using static System.Console;
namespace Массив_13._3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите N>2:");
            int n = int.Parse(ReadLine());
            Write("Введите A:");
            int a = int.Parse(ReadLine());
            Write("Введите B:");
            int b = int.Parse(ReadLine());
            int[] m = new int[n];
            m[0] = a; m[1] = b;
            int i, k = a + b;
            for (i = 2; i < n; i++)
            {
                m[i] = k;
                k += m[i];
            }
            for (i = 0; i < n; i++)     
                Write($"{m[i]} " );           
        }
    }
}