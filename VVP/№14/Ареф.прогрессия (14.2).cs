using System;
using static System.Console;
namespace Ареф.прогрессия__14._2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите размер массива N:");
            int n = int.Parse(ReadLine());
            int[] m = new int[n];
            int i,d=0;
            
            for (i = 0; i < n; i++)
            {
                Write("Введите элемент массива:");
                m[i] = int.Parse(ReadLine());
            }
            d = m[1] - m[0];
            for (i = 1; i < n; i++)
                if (m[i] - m[i - 1] != d) d = 0;
            Write(d);
        }
    }
}