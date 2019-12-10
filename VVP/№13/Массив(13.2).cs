using System;
namespace Массив_13._2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N>1:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите первый член массива :");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите знаменатель:");
            int d = int.Parse(Console.ReadLine());
            double[] m = new double[n];
            int i;
            m[0] = a;
            for (i = 1; i < n; i++)
                m[i] = a*Math.Pow(d,i);
            for (i = 0; i < n; i++)
                Console.WriteLine(m[i]);
        }
    }
}