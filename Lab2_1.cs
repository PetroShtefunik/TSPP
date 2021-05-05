using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int month;
            do
            {
                Console.Write("Введiть номер мiсяця:");
                month = int.Parse(Console.ReadLine());
                switch (month)
                {
                    case 1: Console.WriteLine("Сiчень\n"); break;
                    case 2: Console.WriteLine("Лютий\n"); break;
                    case 3: Console.WriteLine("Березень\n"); break;
                    case 4: Console.WriteLine("Квiтень\n"); break;
                    case 5: Console.WriteLine("Травень\n"); break;
                    case 6: Console.WriteLine("Червень\n"); break;
                    case 7: Console.WriteLine("Липень\n"); break;
                    case 8: Console.WriteLine("Серпень\n"); break;
                    case 9: Console.WriteLine("Вересень\n"); break;
                    case 10: Console.WriteLine("Жовтень\n"); break;
                    case 11: Console.WriteLine("Листопад\n"); break;
                    case 12: Console.WriteLine("Грудень\n"); break;
                    default: Console.WriteLine("такого мiсяця не iснує\n"); break;
                }
            } while (month != 0);
        }
    }
}
