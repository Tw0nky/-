using System.IO;
using static System.Console;
namespace Имя_файла__строчки_22._2_
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите имя файла:");
            string fileName = ReadLine();
            StreamWriter file = new StreamWriter(@$"J:\ЛАБЫ\Лабораторные по Введению в программирование\Лаб №22\{fileName}.txt");
            Write("Введите количество строк:");
            int n = int.Parse(ReadLine());
            Write("Введите количество символов '*':");
            int k = int.Parse(ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    file.Write("*");
                }
                file.WriteLine();
            }
            file.Close();
        }
    }
}