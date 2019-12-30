using static System.Console;
namespace Заменить_серию_на_0__17._2__
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите размерность массива:");
            int n = int.Parse(ReadLine());
            Write("Введите L (L>0):");
            int l = int.Parse(ReadLine());
            int[] mas = new int[n];
            int i, j = 1, count;
            for (i = 0; i < n; i++)
            {
                Write("Введите элемент массива:");
                mas[i] = int.Parse(ReadLine());
            }
            l -= 1;
            for (i = 0; i < n; i++)
            {
                count = 0;
                for (j =i+1; j < n; j++)
                {
                    if (mas[i] == mas[j])
                    {
                        count++;
                    }
                }
                if (count > l)
                {
                    i += count;
                    Write("0");
                }
                if (count <= l)
                {
                    Write(mas[i]);
                }
            }
        }
    }
}