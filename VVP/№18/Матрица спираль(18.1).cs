using static System.Console;
namespace Матрица_спираль_18._1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите размерность матрицы:");
            int n = int.Parse(ReadLine());
            int[,] mas = new int[n,n];
            WriteLine("Введите элементы матрицы : ");
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Write($"[{i}][{j}] =");
                    mas[i,j] = int.Parse(ReadLine());
                }
            }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Write($"{mas[i,j]}\t");
                }
                WriteLine();
            }
            Write("Матрица выведенная по спирали:");
             for (i = 0; i < n; i++)
                Write(mas[i, 0]);
             for (i = n-1; i < n; i++)
                for (j = 1; j < n; j++)
                    Write(mas[i, j]);
             for (i = n - 2; i > 0; i--)
                Write(mas[i, n - 1]);
             for (j = n - 1; j > 0; j--)
                 Write(mas[0, j]);
             for (i = 1; i < n-1; i++)
                    Write(mas[i, 1]);
             for (j = 2; j < n - 1; j++)
                Write(mas[n-2, j]);
             for (i = n - 3; i > 0; i--)
                Write(mas[i, n - 2]);
             for (j = n - 3; j > 1; j--)
                Write(mas[1, j]);
             for (i = n / 2;i<n/2;i++)
                Write(mas[i, i]);
        }
    }
}