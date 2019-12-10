using static System.Console;
namespace После_отрицательного_0__16._4_
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
                Write($" {mas[i]} ");
                if (mas[i] < 0)
                    Write(" 0 " );
            }
        }
    }
}