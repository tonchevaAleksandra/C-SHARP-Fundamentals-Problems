using System;
using System.Linq;

namespace FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                long[] numbers = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();
                long maxNum = Math.Max(numbers[0], numbers[1]);
                long currSumOfDigits = 0;
                while (Math.Abs(maxNum)>0)
                {
                    currSumOfDigits += maxNum % 10;
                    maxNum /= 10;
                }

                    Console.WriteLine(Math.Abs(currSumOfDigits));
         
            }

        }
    }
}
