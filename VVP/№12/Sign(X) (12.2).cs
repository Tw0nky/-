using System;
namespace Sign_X___12._2_
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите A:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите B:");
            double b = double.Parse(Console.ReadLine());
            int sign(double x)
            {
                if (x < 0) return -1;
                if (x > 0) return 1;
                if (x == 0) return 0;
                return 0;
            }
            Console.WriteLine(sign(a) + sign(b));
        }
    }
}