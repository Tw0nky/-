using System.IO;
using static System.Console;
namespace Замена_пробелов_22._4_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = File.ReadAllText(@$"J:\ЛАБЫ\Лабораторные по Введению в программирование\Лаб №22\22.4.txt");
            StreamWriter file = new StreamWriter(@$"J:\ЛАБЫ\Лабораторные по Введению в программирование\Лаб №22\22.4.txt");
            for (int i = 0; i < str.Length; i++)
                if (str[i] != ' ' || str[i] == ' ' && str[i - 1] != ' ')
                    file.Write(str[i]);
            file.Close();
        }
    }
}