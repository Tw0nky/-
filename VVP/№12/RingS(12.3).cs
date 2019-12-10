using System;
namespace Sign_X___12._2_
{
    class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i < 4; i++)
            {
                Console.Write("Введите радиус R1:");
                double R1 = double.Parse(Console.ReadLine());
                Console.Write("Введите радиус R2:");
                double R2 = double.Parse(Console.ReadLine());
                double RingS(double R1, double R2)
                {
                    double RingS = 3.14 * (Math.Pow(R1, 2) - Math.Pow(R2, 2));
                    return RingS;
                }
                Console.WriteLine(RingS(R1, R2));                                                          
            }
        }
    }
}