using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int leftSum = 0;
            int rightSum = numbers.Sum();

            for (int i = 0; i < numbers.Length; i++)
            {
                rightSum -= numbers[i];
                if(rightSum==leftSum)
                {
                    Console.WriteLine(i);
                   return;
                }
                else
                {
                    leftSum += numbers[i];
                }

            }

            Console.WriteLine("no");

        }
    }
}
