using System;
using System.Linq;

namespace EqualSums1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rightsSum = arr.Sum();
            int leftSum = 0;


            for (int i = 0; i < arr.Length; i++)
            {

                rightsSum -= arr[i];

                if (leftSum == rightsSum)
                {
                    Console.WriteLine(i);

                    return;
                }
                else
                {
                    leftSum += arr[i];
                }

            }


            Console.WriteLine("no");


        }
    }
}
