using static System.Console;
namespace Упорядоченный_15._5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите размерность массива:");
            int n = int.Parse(ReadLine());
            int[] a = new int[n];
            int i,buff;
            for (i = 0; i < n; i++)
            {
                Write("Введите элемент массива:");
                a[i] = int.Parse(ReadLine());
            }
            int max = a[0];
            for (i = 1; i < n; i++)
                if (a[0] < a[i]) max = a[i];
            for (i = 0; i < n-1; i++)
                if (a[i] > a[i + 1]&&a[i]<=max) 
                {buff = a[i]; a[i] = a[i + 1]; a[i + 1] = buff;}
            for (i = 0; i < n; i++)
                Write($"{a[i]} ");
        }
    }
}