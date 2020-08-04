using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] checkNums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> result = new List<int>();

            for (int i = 0; i < checkNums[0]; i++)
            {
                result.Add(numbers[i]);
            }
            int counter = 0;
            for (int i = 0; i < result.Count; i++)
            {
                if(counter==checkNums[1])
                {
                    break;
                }
                result.RemoveAt(i);
                counter++;
                i -= 1;
                
            }
            
            if(result.Contains(checkNums[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
