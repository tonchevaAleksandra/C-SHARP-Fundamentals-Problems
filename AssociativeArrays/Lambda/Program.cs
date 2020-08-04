using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Enumerable.Range(0, 100).ToArray();

            var even = array.Select(x =>
              {
                  if (x % 2 == 0)
                  {
                      return x * 2;
                  }
                  return x;
              }).ToArray();

            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(n => n > 0)
                .ToArray();




            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

            var c = keyValuePairs
                .OrderBy(kvp => kvp.Value)
                .ToDictionary(a => a.Key, b => b.Value);
        }
    }
}
