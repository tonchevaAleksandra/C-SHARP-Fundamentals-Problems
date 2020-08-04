using System;
using System.Linq;

namespace SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumEvenNums = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i]%2==0)
                {
                   sumEvenNums += nums[i];
                    
                }
            }
            Console.WriteLine(sumEvenNums);
        }
    }
}
