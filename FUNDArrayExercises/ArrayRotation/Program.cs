using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rotaions = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotaions%numbers.Length; i++)
            {
                int firstNum = numbers[0];
                for (int j = 0; j < numbers.Length-1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }
                numbers[numbers.Length - 1] = firstNum;
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
