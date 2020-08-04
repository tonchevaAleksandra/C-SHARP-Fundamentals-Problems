using System;
using System.Linq;

namespace Kamino
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int currentSequence = 1;
            int maxSequenceOnes = 1;
            int currIndex = 0;
            int bestIndex = int.MaxValue;
            int[] bestDNA = new int[n];

            int bestSequenceIndex = 0;
            int countDNA = 0;
            int bestSum = 0;

            while (command != "Clone them!")
            {
                int[] currDNA = command
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                countDNA++;
                int currSum = currDNA.Sum();
                

                for (int i = 1; i < currDNA.Length; i++)
                {

                    if (currDNA[i] == currDNA[i-1] && currDNA[i]==1)
                    {
                        currentSequence++;
                        currIndex = i-1;
                        
                       

                        if (currentSequence > maxSequenceOnes || (maxSequenceOnes == currentSequence && (bestIndex > currIndex||currSum>bestSum)))
                        {

                           
                            bestSum = currSum;
                            bestDNA = currDNA;
                            bestSequenceIndex = countDNA;
                            maxSequenceOnes = currentSequence;
                        }

                    }
                    else
                    {
                        currentSequence = 1;
                    }

                }
                command = Console.ReadLine();


            }

            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDNA));


        }
    }
}

