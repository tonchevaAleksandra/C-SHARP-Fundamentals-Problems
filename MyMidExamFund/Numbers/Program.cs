using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine()
           .Split()
           .Select(int.Parse)
           .ToList();

            double sum = numbers.Sum();
            double averageValue = (sum / numbers.Count);
            List<int> result = new List<int>();
            int countNums = 0;
            numbers.Sort();
            numbers.Reverse();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > averageValue)
                {
                    result.Add(numbers[i]);
                    countNums++;
                }
                if(countNums>=5)
                {
                    break;
                }

            }


            if (result.Count>0)
            {
                result.Sort();
                result.Reverse();

                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("No");
            }
            

        }
    }
}
