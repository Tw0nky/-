using static System.Console;
namespace Подсчет_гласных_21._4_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            WriteLine("Введите строку состоящюу из русских слов, разделенных пробелами:");
            s = ReadLine();
            char[] vowel =  { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я', 'А', 'Е', 'Ё', 'И', 'О', 'У', 'Ы', 'Э', 'Ю', 'Я' };
            int i,j, count = 0;
            for (i = 0; i < s.Length; i++)
            {
                for (j = 0; j < s.Length; j++)
                {
                    if (s[i] == vowel[j])
                        count++;
                }
            }
            Write(count);

        }
    }
}