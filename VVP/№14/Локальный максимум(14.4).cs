using static System.Console;
namespace Локальный_максимум_14._4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите размер массива N:");
            int n = int.Parse(ReadLine());
            int[] m = new int[n];
            int i;
            for (i = 0; i < n; i++)
            {
                Write("Введите элемент массива:");
                m[i] = int.Parse(ReadLine());
            }
            int buf = 0;
            for (i = 1; i < n - 1; i++)
            {
                if (m[i] > m[i + 1] && m[i] > m[i - 1])
                  buf = i;
            }
            Write($"Номер локального максимума = {buf+1}");
        }
    }
}