using System;

namespace Lab2_2b
{
    class Program
    {
        static void Main(string[] args)
        {
            double y, x = 0, b = Math.PI, dx = Math.PI / 20;
            Console.WriteLine("  X\t\t Y");
            while (x <= b)
            {
                x = Math.Round(x, 2);
                if (x == 0)
                {
                    Console.WriteLine(Math.Round(x, 2) + "\t\tНеможливо");
                }
                else
                {
                    y = Math.Tan(x);
                    y = Math.Round(y, 2);
                    Console.WriteLine(x + "\t\t" + y);

                }
                x += dx;
            } 
        }
    }
}
