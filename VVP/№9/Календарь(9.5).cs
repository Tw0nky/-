using System;
namespace Календарь_9._5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Год ");
            switch (a%10) 
            {
                case 0:
                case 1:
                    Console.Write("бел");
                        break;
                case 2:
                case 3:
                    Console.Write("черн");
                    break;
                case 4:
                case 5:
                    Console.Write("зелен");
                    break;
                case 6:
                case 7:
                    Console.Write("красн");
                    break;
                case 8:
                case 9:
                    Console.Write("желт");
                    break;                 
            }
            switch (a % 12)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 9:
                case 10:
                case 11:
                    Console.Write("ой ");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.Write("ого ");
                    break;
            }
            switch((a+8)%12)
            {
                case 0:
                    Console.Write("крысы");
                    break;
                case 1:
                    Console.Write("коровы");
                    break;
                case 2:
                    Console.Write("тигра");
                    break;
                case 3:
                    Console.Write("зайца");
                    break;
                case 4:
                    Console.Write("дракона");
                    break;
                case 5:
                    Console.Write("змеи");
                    break;
                case 6:
                    Console.Write("лошади");
                    break;
                case 7:
                    Console.Write("овцы");
                    break;
                case 8:
                    Console.Write("обезьяны");
                    break;
                case 9:
                    Console.Write("курицы");
                    break;
                case 10:
                    Console.Write("собаки");
                    break;
                case 11:
                    Console.Write("свиньи");
                    break;
            }
        }
    }
}
