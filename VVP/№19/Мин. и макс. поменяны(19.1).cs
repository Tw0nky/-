using static System.Console;
namespace Мин._и_макс._поменяны_19._1_
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
            int min , max ,buff=0,jmax=0,jmin=0;
            for (i = 0; i < m; i++)
            {
                max = mas[i, 0];
                min = mas[i, 0];
                for (j = 0; j < n; j++)
                {
                    if (mas[i, j] < min)
                    {
                        min = mas[i, j];
                        jmin = j;
                    }
                    if (mas[i, j] > max)
                    {
                        max = mas[i, j];
                        jmax = j;
                    }
                }
                buff = mas[i,jmin];
                mas[i, jmin] = mas[i, jmax];
                mas[i, jmax] = buff;
                jmax = 0;
                jmin = 0;
            }
            WriteLine("Матрица после преобразования:");
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
