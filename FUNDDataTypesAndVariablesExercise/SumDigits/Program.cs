using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int digits = 0;
            int sumOfDigits = 0;
            while(n>0)
            {
                digits = n % 10;
                n /= 10;
                sumOfDigits += digits;
            }
            Console.WriteLine(sumOfDigits);
        }
    }
}
