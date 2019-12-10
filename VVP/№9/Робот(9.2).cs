using System;
namespace Робот_9._2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите направление робота,«С» — север, «З» — запад, «Ю» — юг, «В» — восток:");
            string c =Console.ReadLine();
            Console.WriteLine("Введите команду(0 — продолжать движение, 1 — поворот налево, -1 — поворот направо) :");
            int n = int.Parse(Console.ReadLine());
            switch (c)
            {
                case "З":
                    switch (n)
                    {
                        case 1:c = "Юг";
                            break;
                        case 0:c = "Запад";
                            break;
                        case -1:c = "Север";
                            break;
                    }
                    break;
                case "В":
                    switch (n)
                    {
                        case 1:
                            c = "Север";
                            break;
                        case 0:
                            c = "Восток";
                            break;
                        case -1:
                            c = "Юг";
                            break;
                    }
                    break;
                case "Ю":
                    switch (n)
                    {
                        case 1:
                            c = "Восток";
                            break;
                        case 0:
                            c = "Юг";
                            break;
                        case -1:
                            c = "Запад";
                            break;

                    }
                    break;
                case "С":
                    switch (n)
                    {
                        case 1:
                            c = "Запад";
                            break;
                        case 0:
                            c = "Север";
                            break;
                        case -1:
                            c = "Восток";
                            break;
                    }
                    break;
            }
            Console.WriteLine($"Направление - {c}");
        }
    }
}