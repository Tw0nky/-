using System;
namespace Массив_13._1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N>0:");
            int n = int.Parse(Console.ReadLine());
            int[] m = new int[n];
            for (int i = 0, c = 1; i < n; i++, c += 2)
            {
                m[i] = c;
                Console.WriteLine(c);
            }
        }
    }
}