using System;
using System.Linq;

namespace KamionoSanyaSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int bestLength = 1;
            int bestStartIndex = 0;
            int bestSum = 0;
            int sequenceCounter = 0;
            int bestSeqIndex = 0;

            int[] bestSequence = new int[n];

            while (input!="Clone them!")
            {
                int[] currSeq = input
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                sequenceCounter++;
                int length = 1;
                int bestCurrLength = 1;
                int startIndex = 0;
                int currSum = 0;

                for (int i = 0; i < currSeq.Length-1; i++)
                {
                    if(currSeq[i]==currSeq[i+1])
                    {
                        length++;
                    }
                    else
                    {
                        length = 1;
                    }
                    if(length>bestCurrLength)
                    {
                        bestCurrLength = length;
                        startIndex = i;
                    }

                    currSum += currSeq[i];
                }
                currSum += currSeq[currSeq.Length - 1];

                if(bestCurrLength>bestLength)

                {
                    bestLength = bestCurrLength;
                    bestStartIndex = startIndex;
                    bestSum = currSum;
                    bestSeqIndex = sequenceCounter;
                    bestSequence = currSeq.ToArray();
                }
                else if(bestCurrLength==bestLength)
                {
                    if (startIndex < bestStartIndex)
                    {
                        bestLength = bestCurrLength;
                        bestStartIndex = startIndex;
                        bestSum = currSum;
                        bestSeqIndex = sequenceCounter;
                        bestSequence = currSeq.ToArray();
                    }
                    else if(startIndex==bestStartIndex)
                    {
                        if(currSum>bestSum)
                        {
                            bestLength = bestCurrLength;
                            bestStartIndex = startIndex;
                            bestSum = currSum;
                            bestSeqIndex = sequenceCounter;
                            bestSequence = currSeq.ToArray();
                        }
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSeqIndex} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestSequence));
        }
    }
}
