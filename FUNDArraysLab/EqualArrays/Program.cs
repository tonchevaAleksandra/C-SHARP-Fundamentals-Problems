using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            int count = 0;
            bool isEqual = false;
            for (int i = 0; i < arr1.Length; i++)
            {
               
                if(arr1[i]!=arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                else
                {
                    count++;
                    isEqual = true;
                    sum += arr1[i];
                }

            }
            if(isEqual && count==arr1.Length)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }

        }
    }
}
