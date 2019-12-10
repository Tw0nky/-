using System;
namespace День_месяц_9._1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите день от 1 до 31:");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Введите месяц от 1 до 12:");
            int m = int.Parse(Console.ReadLine());
            if (d / 10 == 1)
                switch (d)
                {
                    case 10:
                        Console.Write(" десятое");
                        break;
                    case 11:
                        Console.Write(" одинадцатое");
                        break;
                    case 12:
                        Console.Write(" двенадцатое");
                        break;
                    case 13:
                        Console.Write(" тринадцатое");
                        break;
                    case 14:
                        Console.Write(" четырнадцатое");
                        break;
                    case 15:
                        Console.Write(" пятнадцатое");
                        break;
                    case 16:
                        Console.Write(" шестнадцатое");
                        break;
                    case 17:
                        Console.Write(" семнадцатое");
                        break;
                    case 18:
                        Console.Write(" восемнадцатое");
                        break;
                }
            else
            {
                switch (d / 10)
                {
                    case 2:
                        Console.Write("двадвацать ");
                        break;
                    case 3:
                        Console.Write("тридацать");
                        break;
                }
                switch (d % 10)
                {
                    case 1:
                        Console.Write(" первое");
                        break;
                    case 2:
                        Console.Write(" второе");
                        break;
                    case 3:
                        Console.Write(" третье");
                        break;
                    case 4:
                        Console.Write(" четвертое");
                        break;
                    case 5:
                        Console.Write(" пятое");
                        break;
                    case 6:
                        Console.Write(" шестое");
                        break;
                    case 7:
                        Console.Write(" седьмое");
                        break;
                    case 8:
                        Console.Write(" восьмое");
                        break;
                    case 9:
                        Console.Write(" девятое");
                        break;
                }
            }
                switch (m)
                {
                    case 1:
                        Console.Write(" января");
                        break;
                    case 2:
                        Console.Write(" февраля");
                        break;
                    case 3:
                        Console.Write(" марта");
                        break;
                    case 4:
                        Console.Write(" апреля");
                        break;
                    case 5:
                        Console.Write(" мая");
                        break;
                    case 6:
                        Console.Write(" июня");
                        break;
                    case 7:
                        Console.Write(" июля");
                        break;
                    case 8:
                        Console.Write(" августа");
                        break;
                    case 9:
                        Console.Write(" сентября");
                        break;
                    case 10:
                        Console.Write(" октября");
                        break;
                    case 11:
                        Console.Write(" ноября");
                        break;
                    case 12:
                        Console.Write(" декабря");
                        break;
                }
        }
    }
}
