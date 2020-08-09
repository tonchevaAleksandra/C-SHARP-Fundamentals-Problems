using System;
using System.Collections.Generic;
using System.Linq;

namespace Pirates1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, City> cities = new Dictionary<string, City>();
            string input;
            while ((input = Console.ReadLine()) != "Sail")
            {
                cities = FullFillTheCities(cities, input);
            }
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split("=>");
                string command = cmdArgs[0];
                switch (command)
                {
                    case "Plunder":
                        Plunder(cities, cmdArgs);

                        break;
                    case "Prosper":
                        Prosper(cities, cmdArgs);
                        break;
                   
                }
            }
            cities = PrintResults(cities);

        }

        private static Dictionary<string, City> PrintResults(Dictionary<string, City> cities)
        {
            if (cities.Keys.Count > 0)
            {
                cities = cities.OrderByDescending(x => x.Value.Gold).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
                Console.WriteLine($"Ahoy, Captain! There are {cities.Keys.Count} wealthy settlements to go to:");
                foreach (var city in cities)
                {
                    Console.WriteLine($"{ city.Key} -> Population: { city.Value.Population} citizens, Gold: { city.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }

            return cities;
        }

        private static void Prosper(Dictionary<string, City> cities, string[] cmdArgs)
        {
            string town = cmdArgs[1];
            int gold = int.Parse(cmdArgs[2]);
            if (gold < 0)
            {
                Console.WriteLine($"Gold added cannot be a negative number!");
            }
            else
            {
                cities[town].Gold += gold;
                Console.WriteLine($"{gold} gold added to the city treasury. {town} now has { cities[town].Gold} gold.");
            }
        }

        private static void Plunder(Dictionary<string, City> cities, string[] cmdArgs)
        {
            string town = cmdArgs[1];
            int people = int.Parse(cmdArgs[2]);
            int gold = int.Parse(cmdArgs[3]);
            Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
            cities[town].Population -= people;
            cities[town].Gold -= gold;
            if (cities[town].Population <= 0 || cities[town].Gold <= 0)
            {
                Console.WriteLine($"{town} has been wiped off the map!");
                cities.Remove(town);
            }
        }

        private static Dictionary<string, City> FullFillTheCities(Dictionary<string, City> cities, string input)
        {
            string[] townArgs = input.Split("||");
            string city = townArgs[0];
            int population = int.Parse(townArgs[1]);
            int gold = int.Parse(townArgs[2]);
            if (!cities.ContainsKey(city))
            {
                cities.Add(city, new City(0, 0));
            }
            cities[city].Population += population;
            cities[city].Gold += gold;
            return cities;
        }
    }

    class City
    {
        public int Population { get; set; }
        public int Gold { get; set; }

        public City(int population, int gold)
        {
            this.Population = population;
            this.Gold = gold;
        }
    }
}
