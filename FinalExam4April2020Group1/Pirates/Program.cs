using System;
using System.Collections.Generic;
using System.Linq;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> treasure = new Dictionary<string, int>();
            Dictionary<string, int> populations = new Dictionary<string, int>();
            string input;
            while ((input = Console.ReadLine()) != "Sail")
            {
                FillTheDictionaries(treasure, populations, input);
            }

            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];

                switch (command)
                {
                    case "Plunder":
                        PlunderTheTown(treasure, populations, cmdArgs);
                        break;
                    case "Prosper":
                        string town = cmdArgs[1];
                        int gold = int.Parse(cmdArgs[2]);
                        if (gold < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                            continue;
                        }
                        treasure[town] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {treasure[town]} gold.");
                        break;
                }
            }

            treasure = PrintResult(treasure, populations);
        }

        private static Dictionary<string, int> PrintResult(Dictionary<string, int> treasure, Dictionary<string, int> populations)
        {
            if (treasure.Count > 0)
            {
                treasure = treasure.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
                Console.WriteLine($"Ahoy, Captain! There are {treasure.Count} wealthy settlements to go to:");
                foreach (var town in treasure)
                {
                    Console.WriteLine($"{town.Key} -> Population: { populations[town.Key]} citizens, Gold: { town.Value} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }

            return treasure;
        }

        private static void PlunderTheTown(Dictionary<string, int> treasure, Dictionary<string, int> populations, string[] cmdArgs)
        {
            string town = cmdArgs[1];
            int people = int.Parse(cmdArgs[2]);
            int gold = int.Parse(cmdArgs[3]);
            treasure[town] -= gold;
            populations[town] -= people;
            Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
            if (populations[town] <= 0 || treasure[town] <= 0)
            {
                Console.WriteLine($"{town} has been wiped off the map!");
                treasure.Remove(town);
                populations.Remove(town);
            }
        }

        private static void FillTheDictionaries(Dictionary<string, int> treasure, Dictionary<string, int> populations, string input)
        {
            string[] cityArgs = input.Split("||", StringSplitOptions.RemoveEmptyEntries);
            string town = cityArgs[0];
            int people = int.Parse(cityArgs[1]);
            int gold = int.Parse(cityArgs[2]);
            if(!treasure.ContainsKey(town))
            {
                treasure.Add(town, gold);
                populations.Add(town, people);
            }
            else
            {
                treasure[town] += gold;
                populations[town] += people;
            }
            
        }
    }
}
