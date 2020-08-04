using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 1; num <= n; num++)
            {
                int digit = num;
                int sumDigits = 0;
                bool isSpecial = false;
                while (digit > 0)
                {
                    sumDigits += digit % 10;
                    digit /=10;
                }
                if (sumDigits == 5 || sumDigits == 7 || sumDigits == 11)
                {
                    isSpecial = true;
                }
                Console.WriteLine($"{num} -> {isSpecial}");

            }
        }
    }
}
