using System;
using System.Linq;

namespace KaminoFactoryLastSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int currSubSeq = 1;
            int bestSubSeq = 1;

            int currIndex = int.MaxValue;
            int bestIndex = int.MaxValue;

            int bestSum = 0;

            int countDNA = 0;
            int bestCount = 0;

            int[] bestDNA = new int[n];
            string command = Console.ReadLine();

            while (command != "Clone them!")
            {
                int[] currDNA = command
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                countDNA++;
                int currSum = currDNA.Sum();
                for (int i = 1; i < n; i++)
                {
                    if (currDNA[i] == 0)
                    {
                        currSubSeq = 1;
                        continue;
                    }
                    else if (currDNA[i] == currDNA[i - 1])
                    {
                        currSubSeq++;

                        currIndex = i - 1;
                        if (currSubSeq > bestSubSeq)
                        {
                            bestSubSeq = currSubSeq;

                        }
                    }
                    if ((currIndex < bestIndex || currSum > bestSum && currSubSeq == bestSubSeq) || currSubSeq > bestSubSeq)
                    {
                        bestSubSeq = currSubSeq;
                        bestIndex = currIndex;
                        bestSum = currSum;
                        bestCount = countDNA;
                        bestDNA = currDNA.ToArray();
                    }
                }
                command = Console.ReadLine();
            }


            Console.WriteLine($"Best DNA sample {bestCount} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDNA));


        }
    }
}
