using static System.Console;
namespace Элементы__больших_среднего_арифметического_18._4_
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
            int i, j, sr_aref = 0, sum = 0, num;
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Write($"[{i}][{j}] =");
                    mas[i, j] = int.Parse(ReadLine());
                }
            }
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Write($"{mas[i, j]}\t");
                }
                WriteLine();
            }
            for (j = 0; j < n; j++)
            {
                sum = 0;
                for (i = 0; i < m; i++)
                {
                    sum += mas[i, j];
                }
                sr_aref = sum / m;
                num = 0;
                for (i = 0; i < m; i++)
                {
                    if (mas[i, j] > sr_aref)
                        num++;
                }
                WriteLine($"Количесвто элементов > средн.ареф в {j} столбце = {num}");
            }
        }
    }
}
