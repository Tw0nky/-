using static System.Console;
namespace Количество_прописных_латинских_букв_20._3_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Write("Введите строку:");
            s = ReadLine();
            int i ,count=0;
            for (i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    count++;
                }
            }
            Write($"Количество прописных латинских букв в строке = {count}");
        }
    }
}