using System;
using System.Linq;

namespace MaxSequenceOfEqualElements1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int currentCount = 1;
            int maxCount = 1;
            int number = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                int previousNum = numbers[i - 1];
                int currentNum = numbers[i];

                if(previousNum==currentNum)
                {
                    currentCount++;
                    
                    if(currentCount>maxCount)
                    {
                        maxCount = currentCount;
                        number = numbers[i];
                    }
                   
                }

                else
                {
                    currentCount = 1;
                }

            }

            for (int j = 0; j < maxCount; j++)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
