using static System.Console;
namespace Сумма_и_произведение_k_строки_18._2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите количество строк M:");
            int m = int.Parse(ReadLine());
            Write("Введите количесвто столбцов N:");
            int n = int.Parse(ReadLine());
            Write("Введите целое число K (1<=K<=M):");
            int k = int.Parse(ReadLine());
            int[,] mas=new int[m,n];
            WriteLine("Введите элементы матрицы:");
            int i,j;
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
            int sum = 0,pr = 1;
            for (j = 0; j < n; j++)
            {
                sum += mas[k-1, j];
                pr *= mas[k-1, j];
            }
            WriteLine($"Сумма {k}-ой строки = {sum}");
            Write($"Произведение {k}-ой строки = {pr}");
        }
    }
}
