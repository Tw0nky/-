using System;
namespace Учебные_здания_9._3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество учебных зданий в диапазоне 10-40:");
            int a = int.Parse(Console.ReadLine());
            if (a / 10 == 1)
                switch (a)
                {
                    case 10:
                        Console.Write("Десять учебных заданий");
                        break;
                    case 11:
                        Console.Write("Одинадцать учебных заданий");
                        break;
                    case 12:
                        Console.Write("Двенадцать учебных заданий");
                        break;
                    case 13:
                        Console.Write("Тринадцать учебных заданий");
                        break;
                    case 14:
                        Console.Write("Четырнадцать учебных заданий");
                        break;
                    case 15:
                        Console.Write("Пятнадцать учебных заданий");
                        break;
                    case 16:
                        Console.Write("Шестнадцать учебных заданий");
                        break;
                    case 17:
                        Console.Write("Семнадцать учебных заданий");
                        break;
                    case 18:
                        Console.Write("Восемнадцать учебных заданий");
                        break;
                    case 19:
                        Console.Write("Девятнадцать учебных заданий");
                        break;
                }
            else
            {
                switch(a/10)
                {
                    case 2:
                        Console.Write("Двадацать "); 
                            break;
                    case 3:
                        Console.Write("Тридцать ");
                           break;
                    case 4:
                        Console.Write("Сорок ");
                            break;
                }
                switch (a % 10)
                {
                    case 1:
                        Console.Write("одно ");
                        break;
                    case 2:
                        Console.Write("два ");
                        break;
                    case 3:
                        Console.Write("три ");
                        break;
                    case 4:
                        Console.Write("четыре ");
                        break;
                    case 5:
                        Console.Write("пять ");
                        break;
                    case 6:
                        Console.Write("шесть ");
                        break;
                    case 7:
                        Console.Write("семь ");
                        break;
                    case 8:
                        Console.Write("восемь ");
                        break;
                    case 9:
                        Console.Write("девять ");
                        break;
                }
                switch (a % 10)
                {
                    case 1:
                        Console.Write("учебное задание ");
                        break;
                    case 0:
                    case 2:
                    case 3:
                    case 4:
                    case 5:                    
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        Console.Write("учебных заданий");
                        break;                                                                      
                }
            }
        }
    }
}