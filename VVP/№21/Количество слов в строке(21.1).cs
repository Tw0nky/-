using static System.Console;
namespace Количество_слов_в_строке_21._1_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            WriteLine("Введите строку состоящюу из русских слов, разделенных пробелами:");
            s = ReadLine();
            int count = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] == ' ') && (i != 0) && (s[i - 1] != ' ')) count++;
            }
            Write(count);
        }
    }
}