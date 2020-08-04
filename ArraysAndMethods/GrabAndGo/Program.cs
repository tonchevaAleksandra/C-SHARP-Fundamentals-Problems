using System;
using System.Linq;

namespace GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine()
                 .Split()
                 .Select(long.Parse)
                 .ToArray();

            long n = long.Parse(Console.ReadLine());
            long sum = 0;

            if(numbers.Contains(n))
            {
                sum = FindTheSum(numbers, n, sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }

        }

        private static long FindTheSum(long[] numbers, long n, long sum)
        {
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] == n)
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        sum += numbers[j];
                    }
                    Console.WriteLine(sum);
                    break;
                }
            }

            return sum;
        }
    }
}
