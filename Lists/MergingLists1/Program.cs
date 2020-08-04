using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> numbers2 = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();
            List<int> result = new List<int>();
            int minLength = Math.Min(numbers1.Count, numbers2.Count);
            for (int i = 0; i < minLength; i++)
            {
                result.Add(numbers1[i]);
                result.Add(numbers2[i]);
            }

            if(numbers1.Count>numbers2.Count)
            {
                result.AddRange(GetRemainingElements(numbers1, numbers2));
            }
            else if(numbers2.Count> numbers1.Count)
            {
                result.AddRange(GetRemainingElements(numbers2, numbers1));
            }
            Console.WriteLine(string.Join(" ",result));
        }

        static List<int> GetRemainingElements(List<int> longerList, List<int> shorterList)
        {
            List<int> nums = new List<int>();
            for (int i = shorterList.Count; i < longerList.Count; i++)
            {
                nums.Add(longerList[i]);
            }

            return nums;
        }
    }
}
