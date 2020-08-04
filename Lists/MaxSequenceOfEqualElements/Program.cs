using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int bestSequence = 1;
            int number = numbers[0];
            int currSeq = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currSeq++;
                    if (currSeq > bestSequence)
                    {
                        bestSequence = currSeq;
                        number = numbers[i];
                    }
                }
                else
                {
                    currSeq = 1;
                }

            }
            for (int i = 0; i < bestSequence; i++)
            {
                Console.Write(number + " ");
            }

        }
    }
}
