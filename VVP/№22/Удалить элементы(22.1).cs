using static System.Console;
using System.IO;
namespace Удалить_элементы_22._1_
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"J:\ЛАБЫ\Лабораторные по Введению в программирование\Лаб №22\22.1.txt";
            string text = File.ReadAllText(fileName);
            int space = text.IndexOf(' ');
            text = text.Remove(0,space+1);
            File.WriteAllText(fileName, text);
        }
    }
}