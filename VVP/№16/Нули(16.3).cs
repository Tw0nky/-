using static System.Console;
namespace Нули_16._3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите размерность массива:");
            int n = int.Parse(ReadLine());
            int i, max=0,min=0;
            int[] mas = new int[n];
            for (i = 0; i < n; i++)
            {
                Write("Введите элемент массива:");
                mas[i] = int.Parse(ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                if (mas[i] < mas[min])
                    min = i;
                if (mas[i] > mas[max])
                    max = i;
            }
            for (i = 0; i < n; i++)
            {
                if (mas[i] == mas[min])
                    Write(" 0 ");
                Write($" {mas[i]} ");
              if(  mas[i] == mas[max])
                    Write(" 0 ");
            }
        }
    }
}