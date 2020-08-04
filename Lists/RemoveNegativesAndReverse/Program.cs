using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> positiveNums= RemoveNegativeNumbers(numbers);
            
            if(positiveNums.Count>0)
            {
                positiveNums.Reverse();
                Console.WriteLine(string.Join(" ", positiveNums));
            }
            else
            {
                Console.WriteLine("empty");
            }

        }

        static List<int> RemoveNegativeNumbers(List<int>numbers)
        {
            List<int> positiveNums = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i]>0)
                {
                    positiveNums.Add(numbers[i]);
                }
            }
            return positiveNums;
        }
    }
}
