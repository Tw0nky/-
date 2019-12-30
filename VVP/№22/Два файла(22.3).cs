using System.IO;
using static System.Console;
namespace Два_файла_22._3_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = File.ReadAllText(@$"J:\ЛАБЫ\Лабораторные по Введению в программирование\Лаб №22\22.3 №1.txt");
            string str1 = File.ReadAllText(@$"J:\ЛАБЫ\Лабораторные по Введению в программирование\Лаб №22\22.3 №2.txt");
            StreamWriter file = new StreamWriter(@$"J:\ЛАБЫ\Лабораторные по Введению в программирование\Лаб №22\22.3 №1.txt");
            file.Write($"{str1} {str}");
            file.Close();
        }
    }
}