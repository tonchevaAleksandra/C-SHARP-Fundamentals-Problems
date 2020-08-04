using System;
using System.Collections.Generic;
using System.Linq;

namespace OnTheWayToAnnapurna
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> stores = new Dictionary<string, List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = input.Split("->");
                string command = cmdArgs[0];
                switch (command)
                {
                    case "Add":
                        stores = Add(stores, cmdArgs);

                        break;
                    case "Remove":
                        string store = cmdArgs[1];
                        if (stores.ContainsKey(store))
                        {
                            stores.Remove(store);
                        }
                        break;
                    default:
                        break;
                }
            }

            stores = PrintResult(stores);
        }

        private static Dictionary<string, List<string>> PrintResult(Dictionary<string, List<string>> stores)
        {
            stores = stores.OrderByDescending(x => x.Value.Count()).ThenByDescending(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Stores list:");
            foreach (var kvp in stores)
            {
                Console.WriteLine(kvp.Key);
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }

            return stores;
        }

        private static Dictionary<string, List<string>> Add(Dictionary<string, List<string>> stores, string[] cmdArgs)
        {
            string store = cmdArgs[1];
            string[] items = cmdArgs[2].Split(",");
            if (!stores.ContainsKey(store))
            {
                stores.Add(store, new List<string>());

            }
            if (items.Length == 1)
            {

                stores[store].Add(items[0]);
            }
            else if (items.Length > 1)
            {
                foreach (var item in items)
                {
                    stores[store].Add(item);
                }
            }

            return stores;
        }
    }
}
