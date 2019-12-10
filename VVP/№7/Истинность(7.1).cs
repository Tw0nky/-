using System;
namespace Истинность
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A:");
           int a = int.Parse(Console.ReadLine());
            Console.Write("Введите B:");
           int b = int.Parse(Console.ReadLine());
            if ((a > 2) && (b <= 3)) 
            Console.Write("Высказывание справедливы ли неравенства A > 2 и B <= 3 истинно");
            else Console.Write("Высказывание справедливы ли неравенства A > 2 и B <= 3 ложно");
        }
    }
}