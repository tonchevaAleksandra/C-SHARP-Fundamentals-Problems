using System;
using System.Linq;

namespace EqualSums2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rightSum = numbers.Sum();
            int leftSum = 0;
            int index = 0;
            bool isFound = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                
                int currNum = numbers[i];
                rightSum -= currNum;
                if(leftSum==rightSum)
                {
                    index = i;
                    isFound = true;
                }
               
                leftSum += currNum;
            }

            if(isFound)
            {
                Console.WriteLine(index);
            }

            else
            {
                Console.WriteLine("no");
            }

            
        }
    }
}
