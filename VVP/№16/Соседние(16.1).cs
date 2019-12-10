using static System.Console;
namespace Соседние_16._1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите размерность массива:");
            int n = int.Parse(ReadLine());
            int i, j = 0;
            int[] mas = new int[n];
            for (i = 0; i < n; i++)
            {
                Write("Введите элемент массива:");
                mas[i] = int.Parse(ReadLine());
            }
            for (i = 1; i < n; i++)
            {
                if (mas[j] != mas[i])
                {
                    j++;
                    mas[j] = mas[i];
                }
            }
            n = j + 1;
            for (i = 0; i < n; i++)
                Write(mas[i]);
        }
    }
}