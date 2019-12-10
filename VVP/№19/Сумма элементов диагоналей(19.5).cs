using static System.Console;

namespace Сумма_элементов_диагоналей_19._5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите размерность матрицы:");
            int n = int.Parse(ReadLine());
            int[,] mas = new int[n, n];
            WriteLine("Введите элементы матрицы : ");
            int i, j, sum = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Write($"[{i}][{j}] =");
                    mas[i, j] = int.Parse(ReadLine());
                }
            }
            WriteLine("Исходная матрица:");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Write($"{mas[i, j]}\t");
                }
                WriteLine();
            }
            for (i = 0; i < n; i++)
            {
                sum = 0;
                for (j = i; j >= 0; j--)
                {
                    sum += mas[i - j, n - j - 1];
                }
                WriteLine($"Сумма диагонали параллельной главной= {sum}");
            }
            for (j = 1; j < n; j++)
            {
                sum = 0;
                for (i = j; i < n; i++)
                {
                    sum += mas[i, i - j];
                }
                WriteLine($"Сумма диагонали параллельной главной= {sum}");
            }
        }
    }
}