using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] seq = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();
            //int[] len = new int[seq.Length];

            //int maxLen = 0;
            //int lastIndex = -1;

            //for (int x = 0; x < seq.Length; x++)
            //{
            //    len[x] = 1;

            //    for (int i = 0; i <= x-1; i++)
            //    {
            //        if(seq[i]<seq[x] && len[i]+1> len[x])
            //        {
            //            len[x] = 1 + len[i];
            //        }
            //    }
            //}

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] result = new int[numbers.Length];
            int[] previous = new int[numbers.Length];

            int maxSeq = 0;
            int maxSeqIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currResult = 1;
                int prevIndex = -1;
                int currNum = numbers[i];

                for (
                    int j = 0; j < i; j++)
                {
                    int prevNumber = numbers[j];

                    int prevResult = result[j];

                    if(currNum>prevNumber && prevResult>=currResult)
                    {
                        currResult = prevResult + 1;
                        prevIndex = j;
                    }
                }
                result[i] = currResult;
                previous[i] = prevIndex;

                if(currResult>maxSeq)
                {
                    maxSeq = currResult;
                    maxSeqIndex = i;
                }
            }

            int index = maxSeqIndex;
           List<int> finalResult = new List<int>();

            while(index!=-1)
            {
                int currNum = numbers[index];
                finalResult.Add(currNum);
                index = previous[index];

            }

            finalResult.Reverse();
            Console.WriteLine(string.Join(" ",finalResult));
        }
    }
}
