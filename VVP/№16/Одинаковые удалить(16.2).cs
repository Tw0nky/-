using static System.Console;
namespace Одинаковые_удалить_16._2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите размерность массива:");
            int n = int.Parse(ReadLine());
            int i, j,count,nsize,buf;
            int[] mas = new int[n];
            for (i = 0; i < n; i++)
            {
                Write("Введите элемент массива:");
                mas[i] = int.Parse(ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                count = 0;
                for (j = 0; j < n; j++)
                    if (mas[i] == mas[j])
                        count++;
                if (count == 2)
                {
                    nsize = i - 1;
                    buf = mas[i];
                    for (j = i; j < n; j++)
                        if (mas[j] != buf)
                        {
                            nsize++;
                            mas[nsize] = mas[j];
                        }
                    n = nsize + 1;
                    i--;
                }
            }
            WriteLine($"Размер = {n}");
            for (i = 0; i < n; i++)
                Write(mas[i]);
        }
    }
}