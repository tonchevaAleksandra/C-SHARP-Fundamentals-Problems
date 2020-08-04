using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split("|",StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<int> result = new List<int>();

            for (int i = numbers.Count-1; i >=0; i--)
            {
                var currNums = numbers[i]
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int j = 0; j < currNums.Count; j++)
                {
                    result.Add(int.Parse(currNums[j]));
                }
            }          

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
