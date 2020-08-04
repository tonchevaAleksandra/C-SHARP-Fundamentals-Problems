using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            ReadNumbers(command);


        }
        static void ReadNumbers(string command)
        {

            while (command != "END")
            {
                int number = int.Parse(command);
                Console.WriteLine(CheckIfNumberIsPalindrome(number).ToString().ToLower());

                command = Console.ReadLine();
            }
            if (command == "END")
            {
                return;
            }
        }

        static bool CheckIfNumberIsPalindrome(int number)
        {
            int sum = 0;
            int currNum = number;
            while (currNum > 0)
            {
                int digit = currNum % 10;
                sum = sum * 10 + digit;
                currNum /= 10;
            }
            if (sum == number)
            {
                return true;
            }

            return false;
        }
    }
}
