using System;
using System.Linq;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine()
                .Split()
                .ToArray();
            string[] arr2 = Console.ReadLine()
                .Split()
                .ToArray();

            int countRight = 0;
            int countLeft = 0;

            for (int i = 0; i < arr1.Length&&i<arr2.Length; i++)
            {
               if(arr1[i]==arr2[i])
                {
                    countLeft++;
                }
            }

            for (int i = 0; i < arr1.Length && i < arr2.Length; i++)
            {
                if(arr1[arr1.Length-1-i]==arr2[arr2.Length-1-i])
                {
                    countRight++;
                }
            }

            int maxSequence = Math.Max(countRight, countLeft);
            Console.WriteLine(maxSequence);
        }
    }
}
