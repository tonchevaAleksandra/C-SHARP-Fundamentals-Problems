using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                  .Split()
                  .Select(double.Parse)
                  .ToArray();

            SortedDictionary<double, int> count = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (count.ContainsKey(numbers[i]))
                {
                    count[numbers[i]]++;
                }
                else
                {
                    count.Add(numbers[i], 1);
                }


            }


            foreach (var item in count)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }

            
        }
    }
}
