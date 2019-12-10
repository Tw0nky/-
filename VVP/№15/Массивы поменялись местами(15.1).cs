using static System.Console;
namespace Массивы_поменялись_местами_15._1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите размерность массива:");
            int n = int.Parse(ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            int[] buf=new int[n];
            int i;
            for (i = 0; i < n; i++)
            {
                Write("Введите элемент массива A:");
                a[i] = int.Parse(ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                Write("Введите элемент массива B:");
                b[i] = int.Parse(ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                buf[i]= a[i];
                a[i] = b[i];            
            }
            for (i = 0; i < n; i++)
                Write($"{a[i]} ");
            for (i = 0; i < n; i++)
                Write($"{buf[i]} ");
        }
    }
}