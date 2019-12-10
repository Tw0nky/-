using System;
namespace Наименьшее_11._3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N(N>1):");
            int n = int.Parse(Console.ReadLine());
            int k = 1;int s = 0;
            while (s + k < n)
            {
                s = s + k;
                k++;
             }
            Console.WriteLine($"K={k}");
            Console.Write($"Сумма={(n+k)-1}");
        }
    }
}