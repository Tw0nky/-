using static System.Console;
namespace Длина_серий_и_значения_элементов_17._1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите размерность массива:");
            int n = int.Parse(ReadLine());
            int[] masA = new int[n];
            int[] masB = new int [n];
            int[] masC = new int[n];
            int i,j,k=0;
            for (i = 0; i < n; i++)
            {
                Write("Введите элемент массива:");
                    masA[i] = int.Parse(ReadLine());
            }
            for (i = 0; i < n; i=j)
            {
                j = i + 1;
                while ((j < n) && (masA[j] == masA[i]))
                    j++;
                masC[k] = masA[i];
                masB[k] = j - i;
                k++;
            }
            Write("Длины серий:");
            for (j = 0; j < k; j++)
            {
                Write($" {masB[j]}");
            }
            Write("\nЗначения:");
            for (j = 0; j < k; j++)
            {
               Write($" {masC[j]}");
            }
        }
    }
}