using System;
using System.Globalization;
using System.Linq;

namespace ArrayRotation1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations%numbers.Length; i++)
            {
                int currNum = numbers[0];

                for (int j = 0; j < numbers.Length-1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }
                numbers[numbers.Length - 1] = currNum;
            }

            Console.WriteLine(string.Join(" ",numbers));

        }
    }
}
