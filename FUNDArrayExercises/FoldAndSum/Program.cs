using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] startArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int k = startArr.Length / 4;
            int[] firstRow = new int[k * 2];
            int[] secondRow = new int[k * 2];

            for (int i = 0; i < firstRow.Length / 2; i++)
            {
                firstRow[i] = startArr[k - i - 1];
            }
            for (int i = firstRow.Length / 2; i < firstRow.Length; i++)
            {
                firstRow[i] = startArr[startArr.Length - 1 - i + k];
            }
            for (int i = 0; i < secondRow.Length; i++)
            {
                secondRow[i] = startArr[k + i];
            }

            int[] result = new int[k * 2];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = firstRow[i] + secondRow[i];
            }

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
