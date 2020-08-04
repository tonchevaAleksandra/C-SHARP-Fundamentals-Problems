using System;
using System.Linq;

namespace RoundingNums
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
                Console.WriteLine(numbers[i] +" => " + Math.Round(numbers[i], MidpointRounding.AwayFromZero) + " ");
            }
        }
    }
}
