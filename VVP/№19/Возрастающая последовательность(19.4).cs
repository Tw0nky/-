using static System.Console;
namespace Возрастающая_последовательность_19._4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите количество строк M:");
            int m = int.Parse(ReadLine());
            Write("Введите количесвто столбцов N:");
            int n = int.Parse(ReadLine());
            WriteLine("Введите элементы матрицы:");
            int[,] mas = new int[m, n];
            int i, j;
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Write($"[{i}][{j}] =");
                    mas[i, j] = int.Parse(ReadLine());
                }
            }
            WriteLine("Исходная матрица:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Write($"{mas[i, j]}\t");
                }
                WriteLine();
            }
            int buff= 0,k;
            for (i = 0; i < m - 1; i++)
            {
                for (k = i + 1; k < m; k++)
                {
                    if (mas[i, 0] > mas[k, 0])
                    {
                        for (j = 0; j < n; j++)
                        {
                            buff = mas[i, j];
                            mas[i, j] = mas[k, j];
                            mas[k, j] = buff;
                        }
                    }
                }
            }
            WriteLine("Преобразованная матрица:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Write($"{mas[i, j]}\t");
                }
                WriteLine();
            }
        }
    }
}