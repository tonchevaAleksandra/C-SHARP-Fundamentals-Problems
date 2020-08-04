using System;

namespace EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int digit = n % 10;
            string number = string.Empty;
            if (digit == 0) { number = "zero"; }
            else if (digit == 1)
            { 
                number = "one";
            }
            else if (digit == 2) 
            { 
                number = "two"; 
            }
            else if (digit == 3)
            { 
                number = "three"; 
            }
            else if (digit == 4) 
            { 
                number = "four"; 
            }
            else if (digit == 5) 
            {
                number = "five"; 
            }
            else if (digit == 6) 
            { 
                number = "six"; 
            }
            else if (digit == 7)
            {
                number = "seven";
            }
            else if (digit == 8) 
            { 
                number = "eight";
            }
            else if (digit == 9)
            {
                number = "nine"; 
            }

            Console.WriteLine(number);

        }
    }
}
