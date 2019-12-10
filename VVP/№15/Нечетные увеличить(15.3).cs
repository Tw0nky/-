using static System.Console;
namespace Нечетные_увеличить_15._3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите разерность массива:");
            int n = int.Parse(ReadLine());
            int[] a=new int[n];
            int i,buff=0;
            for (i = 0; i < n; i++)
            {
                Write("Введите элемент массива:");
                a[i] = int.Parse(ReadLine());
                if(a[i] % 2 != 0)
                    buff = a[i];
            }
            for (i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0)
                    a[i] += buff;
            }
            for (i = 0; i < n; i++)
            Write($"{a[i]} ");
        }
    }
}