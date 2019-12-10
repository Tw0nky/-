using static System.Console;
namespace Обнуление_массива_15._4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите размерность массива:");
            int n = int.Parse(ReadLine());
            int[] a = new int[n];
            int i,min=0,max=0;
            for (i = 0; i < n; i++)
            {
                Write("Введите элемент массива:");
                a[i] = int.Parse(ReadLine());
            }
            for (i = 1; i < n; i++)
            {
                if (a[i] < a[min])
                    min = i;
                if (a[i] > a[max])
                    max = i;
            }
            if (min < max) 
                for (i = min + 1; i < max; i++)
                    a[i] = 0;
            else for (i = max + 1; i < min; i++)
                    a[i] = 0;
            for (i = 0; i < n; i++)
                Write($"{a[i]} ");
        }
    }
}