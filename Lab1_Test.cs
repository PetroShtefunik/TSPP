using System;
namespace TSPP_LAB1
{

    public class Program
    {

        public static int firstDigit(int n)
        {
            while (n >= 10) n /= 10;

            return n;
        }

        public static int lastDigit(int n)
        {
            return (n % 10);
        }

        public static void Main()
        {
            int n = 777 ;
            Console.WriteLine(firstDigit(n) + " " + lastDigit(n));
        }
    }
}