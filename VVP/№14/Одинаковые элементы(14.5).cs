using static System.Console;
namespace Ареф.прогрессия__14._2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите размер массива N:");
            int n = int.Parse(ReadLine());
            int[] m = new int[n];
            int i, j;
            for (i = 0; i < n; i++)
            {
                Write("Введите элемент массива:");
                m[i] = int.Parse(ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (m[i] == m[j]  && i < j)
                        Write($"{i+1} {j+1}");
                }
            }                   
        }
    }
}
