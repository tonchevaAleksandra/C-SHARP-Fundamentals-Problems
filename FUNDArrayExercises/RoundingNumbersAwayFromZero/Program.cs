using System;
using System.Linq;

namespace RoundingNumbersAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
              .Split()
              .Select(double.Parse)
              .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(Convert.ToDecimal(numbers[i]) + " => " + Math.Round(Convert.ToDecimal(numbers[i]), MidpointRounding.AwayFromZero) + " ");
            }
        }
    }
}
