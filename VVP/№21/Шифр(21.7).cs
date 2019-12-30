using static System.Console;
namespace Шифр_21._7_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s; 
            WriteLine("Введите строку:");
            s = ReadLine();
            int i;
            for (i = 0; i < s.Length; i++)
                if (i % 2 == 1)
                    Write(s[i]);
            for (i = s.Length - 1; i >= 0; i--)
                if (i % 2 != 1)
                    Write(s[i]);
        }
    }
}