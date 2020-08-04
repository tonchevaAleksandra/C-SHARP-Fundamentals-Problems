using System;
using System.Linq;

namespace ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;
            double average = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

                sum += numbers[i];
            }

            average = sum * 1.00 / numbers.Length;
            PrintResults(min, max, sum, average);
        }

         static void PrintResults(int min, int max, int sum, double average)
        {
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }       
    }
}
