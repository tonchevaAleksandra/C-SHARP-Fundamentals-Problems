using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            CheckAllNumberInARange(number);
        }

        static void CheckAllNumberInARange(int number)
        {
            for (int i = 1; i < number; i++)
            {
                if (CheckIfNumIsDivisibleBy8(i) && CheckForAtLeastOneOddDigit(i))
                {
                    Console.WriteLine(i); ;
                }
                else
                {
                    continue;
                }
            }
        }

        static bool CheckIfNumIsDivisibleBy8(int i)
        {
            int currNum = i;
            int sumOfDigits = 0;

            while (currNum > 0)
            {
                int digit = currNum % 10;
                sumOfDigits += digit;
                currNum /= 10;
            }

            if (sumOfDigits % 8 == 0)
            {
                return true;
            }

            return false;

        }

        static bool CheckForAtLeastOneOddDigit(int i)
        {
            int currNum = i;
            
            while (currNum > 0)
            {
                int digit = currNum % 10;
                if (digit % 2 != 0)
                {
                    return true;
                }
                currNum /= 10;
                
            }
            return false;

        }
    }
}


