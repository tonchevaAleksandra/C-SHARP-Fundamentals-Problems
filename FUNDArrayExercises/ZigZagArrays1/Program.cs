using System;
using System.Linq;

namespace ZigZagArrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArr = new int[n];
            int[] secondArr = new int[n];
            int[] row = new int[2];
            for (int i = 0; i < n; i++)
            {
                row = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                if (i % 2 == 0)
                {
                    firstArr[i] = row[0];
                    secondArr[i] = row[1];
                }
                else
                {
                    firstArr[i] = row[1];
                    secondArr[i] = row[0];
                }
            }

            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}
