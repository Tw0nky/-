using static System.Console;
namespace Удвоить_вхождения_20._4_
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            Write("Введите символ C:");
            c = char.Parse(ReadLine());
            string s,s2="";
            Write("Введите строку S:");
            s = ReadLine();
            for (int i = 0; i <s.Length; i++)
            {
                s2 += s[i];
                if (s[i] == c)
                {
                    s2 += s[i];
                }
            }
            s=s2;
            Write(s);
        }
    }
}