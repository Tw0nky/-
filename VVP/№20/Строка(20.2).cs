using static System.Console;
namespace Строка_20._2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Write("Введите строку:");
            s = ReadLine();
            foreach (char x in s)
            {
                Write($"{x} ");
            }
        }
    }
}