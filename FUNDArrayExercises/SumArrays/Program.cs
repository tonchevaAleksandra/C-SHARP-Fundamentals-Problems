using System;
using System.Linq;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] arr2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            int[] finalResult = new int[Math.Max(arr1.Length, arr2.Length)];

            for (int i = 0; i < finalResult.Length; i++)
            {

                finalResult[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];

            }
            
            Console.WriteLine(string.Join(" ", finalResult));

        }
    }
}
