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
            int i, min=0;
           
            for (i=0 ; i <n; i++)
            {
                m[0] = m[1];
                Write("Введите элемент массива:");
                m[i] = int.Parse(ReadLine());
            }
            for (i = 1; i < n; i += 2)
            {
                min = m[1];
                if (m[i] < min) min = m[i];
            }
            Write($"Минимальный элемент из элементов с четными номерами = {min}");
        }
    }
}