using System;
using System.Collections.Generic;
using System.Linq;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mine = new Dictionary<string, int>();
            string product = string.Empty;

            while ((product = Console.ReadLine()) != "stop")
            {
              
                int quantity = int.Parse(Console.ReadLine());

                if (!mine.ContainsKey(product))
                {
                    mine[product] = 0;
                }
              
                    mine[product] += quantity;
             
            }

            PrintDictionary(mine);
        }

        private static void PrintDictionary(Dictionary<string, int> mine)
        {
            foreach (var kvp in mine)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
