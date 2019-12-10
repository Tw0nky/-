using System;
using static System.Console;
namespace Символ_C_20._1_
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            Write("Введите символ C:");
            c = char.Parse(ReadLine());
            WriteLine($"Предшествующий= {Convert.ToChar(c-1)}, сам символ= {c}, следующий символ= {Convert.ToChar(c+1)}");
        }
    }
}