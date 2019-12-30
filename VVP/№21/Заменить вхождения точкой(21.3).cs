using System.Text;
using static System.Console;
namespace Заменить_вхождения_точкой_21._3_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            WriteLine("Введите строку состоящюу из русских слов,набранных заглавными буквами и разделенных пробелами:");
            s = ReadLine();
            int k = s[0];
            int i=1;
            StringBuilder s1 = new StringBuilder(s);
            s1[i] = s[i];
            s = s1.ToString();

            for (i = 1; i < s1.Length; i++)
            {
                if (s1[i] != ' ' && s1[i - 1] == ' ')
                    k = s1[i];

                if (s1[i] != ' ' && s1[i] == k && s1[i - 1] != ' ')
                {
                  
                    s1[i] = '.';
                }
            }
            for (i = 0; i < s1.Length; i++)
                Write(s1[i]);
        }
    }
}