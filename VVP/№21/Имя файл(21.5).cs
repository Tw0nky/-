using static System.Console;
namespace Имя_файл_21._5_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s; /*  C:\\Sand\\text12.txt   */
            WriteLine("Введите строку, содержащую полное имя файла, то есть имя диска, список каталогов (путь), собственно имя и расширение:");
            s = ReadLine();
            int count1 = 0, count2 = 0, i;
            for (i = s.Length - 1; i >= 0; i--)
                if (s[i] != '.')
                    count1++;
                else break;
            for (i = s.Length - count1-1; i >= 0; i--)
                if (s[i] != '\\')
                    count2++;
                else break;
            for (i = s.Length - count1 -count2; i < s.Length - count1-1; i++)
                Write(s[i]);
        }
    }
}