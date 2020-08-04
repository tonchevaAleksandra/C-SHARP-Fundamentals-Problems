using System;
using System.Linq;

namespace MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int currSeq = 1;
            int maxSeq = 1;

            int startIndex = -1;
            int bestStartIndex = numbers.Length;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] < numbers[i])
                {
                    startIndex = i - currSeq;
                    currSeq++;

                }
                else
                {
                    currSeq = 1;
                }
                if (currSeq > maxSeq || (currSeq == maxSeq && startIndex < bestStartIndex))
                {
                    maxSeq = currSeq;
                    bestStartIndex = startIndex;
                }

            }

            for (int i = bestStartIndex; i < bestStartIndex+maxSeq; i++)
            {
                Console.Write(numbers[i] + " ");
            }


        }
    }
}
