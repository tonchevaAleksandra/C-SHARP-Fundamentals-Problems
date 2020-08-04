using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int maxCount = 1;
            int currentCount = 1;
            int number = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                int previousNumber = numbers[i - 1];
                int currentNumber = numbers[i];
                if(previousNumber==currentNumber)
                {
                    currentCount++;
                    if(currentCount>maxCount)
                    {
                        maxCount = currentCount;
                        number = currentNumber;
                    }
                }
                else
                {
                    currentCount = 1;
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}
