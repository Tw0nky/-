using static System.Console;
namespace Длина_самого_короткого_слова_21._2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            WriteLine("Введите строку состоящюу из русских слов, разделенных пробелами:");
            s = ReadLine();
            string[] s1 = s.Split(" ");
            int min = s1[0].Length;
            int i;
            for (i = 0; i < s1.Length; i++)
            {
                if (min > s1[i].Length)
                {
                    min = s1[i].Length;
                }
            }
            Write($"Длина самого кароткого слова:{min}");
        }
    }
}