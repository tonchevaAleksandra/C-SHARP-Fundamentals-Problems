using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> items = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();


            bool isFound = false;
            items.Add("shards", 0);
            items.Add("fragments", 0);
            items.Add("motes", 0);
            while (!isFound)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string name = input[i + 1].ToLower();

                    if (items.ContainsKey(name))
                    {
                        items[name] += quantity;
                        if (items[name] >= 250)
                        {
                            isFound = true;
                            string legendaryItem = FindTheLegendaryItem(name);
                            Console.WriteLine($"{legendaryItem} obtained!");
                            items[name] -= 250;
                            break;
                        }
                    }

                    else
                    {
                        if (!junk.ContainsKey(name))
                        {
                            junk[name] = 0;
                        }
                        junk[name] += quantity;
                    }
                }
            }

            items = items.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key).ToDictionary(a => a.Key.ToLower(), b => b.Value);

            junk = junk.OrderBy(kvp => kvp.Key.ToLower()).ToDictionary(a => a.Key.ToLower(), b => b.Value);

            foreach (var kvp in items)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in junk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

        }

        private static string FindTheLegendaryItem(string name)
        {
            string legendaryItem = string.Empty;
            switch (name)
            {
                case "shards":
                    legendaryItem = "Shadowmourne";
                    break;

                case "fragments":
                    legendaryItem = "Valanyr";
                    break;
                case "motes":
                    legendaryItem = "Dragonwrath";
                    break;
            }

            return legendaryItem;
        }
    }
}
