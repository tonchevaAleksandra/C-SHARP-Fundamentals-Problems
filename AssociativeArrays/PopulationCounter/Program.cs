using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();

            string command;


            while ((command = Console.ReadLine()) != "report")
            {
                string[] input = command.Split("|");
                string name = input[0];
                string country = input[1];
                int population = int.Parse(input[2]);

                if (!countries.ContainsKey(country))
                {
                    countries[country] = new Dictionary<string, long>();
                }

                if (!countries[country].ContainsKey(name))
                {
                    countries[country].Add(name, 0);
                }

                countries[country][name] += population;
            }

            //countries = countries.OrderByDescending(x => x.Value.Values.Sum()).ToDictionary(a => a.Key, b => b.Value);
            PrintResult(countries);

        }

        private static void PrintResult(Dictionary<string, Dictionary<string, long>> countries)
        {
            Dictionary<string, long> sortedDict = new Dictionary<string, long>();

            foreach (var item in countries)
            {
                sortedDict[item.Key] = item.Value.Values.Sum();
            }

            foreach (var kvp in sortedDict.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{kvp.Key} (total population: {kvp.Value})");

                foreach (var city in countries[kvp.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
