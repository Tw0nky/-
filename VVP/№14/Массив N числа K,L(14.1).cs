using System;
using static System.Console;
namespace Массив_N_числа_K_L_14._1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите размер массива N:");
            int n = int.Parse(ReadLine());
            Write("Введите L (L <= N):");
            int l = int.Parse(ReadLine());
            Write("Введите K (K >= 1 и K <= L):");
            int k = int.Parse(ReadLine());
            int[] m = new int[n];
            int i;
            for (i = 0; i<n; i++)
            {
                Write("Введите элемент массива:");
                    m[i] = int.Parse(ReadLine());
            }
            double cr=0;
            for (i = k; i <= l; i++)
                cr +=m[i-1];
             Write(cr/(l-k+1) );

        }
    }
}
