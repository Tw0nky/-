using static System.Console;
namespace Количество_вхождений_20._5_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s0, s1;
            int count = 0;
            Write("Введите строку s0:");
            s0 = ReadLine();
            Write("Введите строку s1:");
            s1 = ReadLine();
            int i = 0;  
            int x = -1; 
            int coun = -1;
            while (i != -1)
            {
                i = s1.IndexOf(s0, x + 1); 
                x = i; 
                coun++; 
            }
            WriteLine(coun);
        }
    }
}