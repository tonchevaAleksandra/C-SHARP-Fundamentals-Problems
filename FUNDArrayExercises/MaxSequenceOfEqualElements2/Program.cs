using System;
using System.Linq;

namespace MaxSequenceOfEqualElements2
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
            int counter = 1;

            int number = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                int previousNum = numbers[i - 1];
                int currNum = numbers[i];
                if (previousNum == currNum)
                {
                    counter++;
                    if (counter > maxCount)
                    {
                        maxCount = counter;
                        number = numbers[i];

                    }
                }

                else
                {
                    counter = 1;
                }


            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
