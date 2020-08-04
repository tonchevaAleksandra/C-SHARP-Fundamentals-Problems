using System;
using System.Collections.Generic;
using System.Linq;

namespace SortListAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 20, -2, 40, -80, 25, 60, 3, -1, 7 };

            for (int i = 0; i < numbers.Count-1; i++)
            {
                for (int j = i+1; j < numbers.Count; j++)
                {
                    int temp = numbers[i];
                    if(numbers[j]<numbers[i])
                    {
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));



            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            nums=Sort(nums);

          
        }

       static List<int> Sort(List<int> nums)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                result.Add(nums[i]);
            }
            for (int i = 0; i < result.Count; i++)
            {
                int min = i;
                for (int j = i; j < result.Count; j++)
                {
                    if (result[j] < result[min])
                    {
                        min = j;
                    }
                }

                int temp = result[i];
                result[i] = result[min];
                result[min] = temp;
            }
            return result;
        }
    }
}
