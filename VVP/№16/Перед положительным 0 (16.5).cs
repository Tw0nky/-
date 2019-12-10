using static System.Console;
namespace Перед_положительным_0__16._5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите размерность массива:");
            int n = int.Parse(ReadLine());
            int[] mas = new int[n];
            int i;
            for (i = 0; i < n; i++)
            {
                Write("Введите элемент массива:");
                mas[i] = int.Parse(ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                if (mas[i] > 0)
                    Write(" 0 ");
                Write($" {mas[i]} ");
            }
        }
    }
}