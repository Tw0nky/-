using static System.Console;
namespace Верхняя_и_нижняя_четверти_поменяны_19._3_
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
            int buff = 0;
            for (i = 0; i < m / 2; i++)
            {
                for (j = 0; j < n / 2; j++)
                {
                    buff = mas[i, j];
                    mas[i, j] = mas[(m / 2) + i, (n / 2) + j];
                    mas[(m / 2) + i, (n / 2) + j] = buff;
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