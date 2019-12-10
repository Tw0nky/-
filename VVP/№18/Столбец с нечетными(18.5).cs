using static System.Console;
namespace Столбец_с_нечетными_18._5_
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
            int i, j,num=0;
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
            int odd;
            for (j = 0; j < n; j++)
            {
                odd = 0;
                for (i = 0; i < m; i++)
                    if (mas[i, j] % 2 == 0)
                        odd = 1;
                if (odd == 0)
                    num = j + 1;
            }
            Write($"Номер столбца содержащего только нечетные числа:{num}");
        }       
    }
}
