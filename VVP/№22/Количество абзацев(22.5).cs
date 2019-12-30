using System.IO;
using System.Text;
using static System.Console;
namespace Количество_абзацев_22._5_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = File.ReadAllText(@$"J:\ЛАБЫ\Лабораторные по Введению в программирование\Лаб №22\22.5.txt");
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' &&str[i+1]==' ' && str[i+2] == ' ' && str[i+3] == ' '&&str[i+4]==' ')
                {
                    count++;
                }
            }
            Write(count);
        }
    }
}