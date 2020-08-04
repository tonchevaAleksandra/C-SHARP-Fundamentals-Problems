using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            List<int> result = new List<int>();
            FindTheSquareNumbers(numbers, result);

            result.Sort();
            result.Reverse();

            Console.WriteLine(string.Join(" ", result));

        }

        private static void FindTheSquareNumbers(List<int> numbers, List<int> result)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                double square = Math.Sqrt(numbers[i]);

                if (square % 1 == 0)
                {
                    result.Add(numbers[i]);
                }
            }
        }
    }
}
