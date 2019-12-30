using System;
using static System.Console;
namespace Точку__наиболее_удаленная_от_начала_координат_17._4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите количество точек:");
            int n = int.Parse(ReadLine());
            int[] x = new int[n];
            int[] y = new int[n];
            int i, x1 = 0, y1 = 0;
            double D, mx = 0;
            for (i = 0; i < n; i++)
            {
                Write($"Введите координату x[{i}]:");
                x[i] = int.Parse(ReadLine());
                Write($"Введите координату y[{i}]:");
                y[i] = int.Parse(ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                if (x[i] < 0 && y[i] > 0)
                {
                    D = Math.Sqrt(x[i] * x[i] + y[i] * y[i]);
                    if (D > mx)
                    {
                        mx = D;
                        x1 = x[i];
                        y1 = y[i];
                    }
                }
            }
            for (i = 0; i < 1; i++)
            {
                if (mx > 0)
                    Write($"Наиболее удаленная от начала координат точка x={x1},y={y1}");
                else Write($"{x[0]} {y[0]}");
            }
        }
    }
}
