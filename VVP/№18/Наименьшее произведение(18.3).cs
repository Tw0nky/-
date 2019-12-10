using static System.Console;
namespace Наименьшее_произведение_18._3_
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
            int i, j,pr=1,minpr=1,minrow=0;
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
            for (i = 0; i < m; i++)
                minpr *= mas[i, 0];
            for (j = 0; j < n; j++)
            {
                pr = 1;
                for (i = 0; i <m; i++)
                    pr *= mas[i, j];
                if (pr < minpr)
                {
                    minpr = pr;
                    minrow = j;
                }
            }
            WriteLine($"Наименьшее произведение элементов = {minpr}");
            Write($"Номер столбца с наименьшим произведением элементов = {minrow}");
        }
    }
}
