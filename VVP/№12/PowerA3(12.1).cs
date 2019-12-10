using System;

namespace PowerA3_12._1_
{
    class Program
    {
        static void PowerA3(double a , out double b)
        {         
                b = Math.Pow(a, 3);
        }
        public static void Main()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Введите число:");
                double a = double.Parse(Console.ReadLine());
                PowerA3(a, out double b);              
                Console.WriteLine(b);              
            }
        }
    }
}
