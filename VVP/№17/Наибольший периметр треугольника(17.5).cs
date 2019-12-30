using static System.Console;
using static System.Math;
namespace Наибольший_периметр_треугольника_17._5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите количество точек(N>2):");
            int n = int.Parse(ReadLine());
            int[] x = new int[n];
            int[] y = new int[n];
            int i, j, m, bufi = 0, bufj = 0, bufm = 0;
            double P = 0;
            for (i = 0; i < n; i++)
            {
                Write($"Введите координату x[{i}]:");
                x[i] = int.Parse(ReadLine());
                Write($"Введите координату y[{i}]:");
                y[i] = int.Parse(ReadLine());
            }
            for (i = 0; i < n - 2; i++)
            {
                for (j = i + 1; j < n - 1; j++)
                {
                    for (m = j + 1; m < n; m++)
                    {
                        if ((Sqrt(Pow(x[i] - x[j], 2) + Pow(y[i] - y[j], 2)) + Sqrt(Pow(x[j] - x[m], 2) + Pow(y[j] - y[m], 2)) + Sqrt(Pow(x[m] - x[i], 2) + Pow(y[m] - y[i], 2))) > P)
                        {
                            P = (Sqrt(Pow(x[i] - x[j], 2) + Pow(y[i] - y[j], 2)) + Sqrt(Pow(x[j] - x[m], 2) + Pow(y[j] - y[m], 2)) + Sqrt(Pow(x[m] - x[i], 2) + Pow(y[m] - y[i], 2)));
                            bufi = i;
                            bufj = j;
                            bufm = m;
                        }
                    }
                }
            }
            WriteLine($"Наибольший периметр треугольника = {P}");
            WriteLine($"1 точка= {x[bufi]},{y[bufi]}");
            WriteLine($"2 точка= {x[bufj]},{y[bufj]}");
            Write($"3 точка= {x[bufm]},{y[bufm]}");
        }
    }
}