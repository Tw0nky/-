using static System.Console;
namespace Новый_массив_15._2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите размерность массива N:");
            int n = int.Parse(ReadLine());
            int[] a = new int[n];
            double[] b = new double[n];
            int i,k;
            for (i = 0; i < n; i++)
            {
                Write("Введите элемент массива А:");
                a[i] = int.Parse(ReadLine()); 
            }
            for (k = 0; k < n; k++)
            {
                for (i = 0; i <= k; i++)
                {
                    b[k] += a[i];
                }
                b[k] = b[k] / i;
            }
            for (k = 0; k < n; k++)
                Write($"{ b[k]} ");
        }
    }
}