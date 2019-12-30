using static System.Console;
namespace Название_последнего_каталога_21._6_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s; /*  C:\\Sand\\abcasda\\tx\\asd.exe   */
            WriteLine("Введите строку, содержащую полное имя файла, то есть имя диска, список каталогов (путь), собственно имя и расширение:");
            s = ReadLine();
            int count1 = 0, count2 = 0,count3=0, i,j;
            for (i = 0; i < s.Length; i++)
                if (s[i] == '\\')
                    count1++;
            if (count1 == 4)
            {
                Write("\\");
            }
            if (count1 > 4)
            {
                for (i = s.Length - 1; i >= 0; i--)
                    if (s[i] != '\\')
                        count2++;
                    else break;
                for (i = s.Length - 3 - count2; i >= 0; i--)
                    if (s[i] != '\\')
                        count3++;
                    else break;
                for (i = s.Length - 2 - count2 - count3; i >= 0; i++)
                    if (s[i] != '\\')
                        Write(s[i]);
                    else break;
            }
        }
    }
}