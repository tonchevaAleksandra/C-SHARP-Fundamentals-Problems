using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int magicNum = int.Parse(Console.ReadLine());
            int currentSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                   
                    

                    currentSum = numbers[i] + numbers[j];
                    if (currentSum == magicNum)
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[j]}");
                    }

                }
            }

        }
    }
}
