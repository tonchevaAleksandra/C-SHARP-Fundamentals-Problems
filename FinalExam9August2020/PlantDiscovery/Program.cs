using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> rarities = new Dictionary<string, int>();
            Dictionary<string, List<double>> ratings = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                //"{plant}<->{rarity}".
                string[] inputArgs = Console.ReadLine().Split("<->");
                string plant = inputArgs[0];
                int rarity = int.Parse(inputArgs[1]);
                if (!rarities.ContainsKey(plant))
                {
                    rarities.Add(plant, 0);
                    ratings.Add(plant, new List<double>());
                }
                rarities[plant] = rarity;

            }

            string cmd;
            while ((cmd = Console.ReadLine()) != "Exhibition")
            {

                //•	Rate: { plant}
                //- { rating}
                string[] cmdArgs = cmd.Split(": ");
                string command = cmdArgs[0];
                switch (command)
                {
                    case "Rate":
                        Rate(ratings, cmdArgs);
                        break;
                    case "Update":
                        //•	Update { plant}
                        //- { new_rarity}
                        Update(rarities, cmdArgs);
                        break;
                    case "Reset":
                        Reset(ratings, cmdArgs);
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            Dictionary<string, List<double>> ratePlants = SortTheDictinaries(rarities, ratings);
            //            Plants for the exhibition:
            //- { plant_name}; Rarity: { rarity}; Rating: { average_rating formatted to the 2nd digit}

            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in ratePlants)
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value[1]}; Rating: {item.Value[0]:f2}");
            }
        }

        private static void Reset(Dictionary<string, List<double>> ratings, string[] cmdArgs)
        {
            string plant = cmdArgs[1];
            if (ratings.ContainsKey(plant))
            {
                ratings[plant].Clear();
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        private static Dictionary<string, List<double>> SortTheDictinaries(Dictionary<string, int> rarities, Dictionary<string, List<double>> ratings)
        {
            Dictionary<string, List<double>> ratePlants = new Dictionary<string, List<double>>();
            foreach (var plant in ratings)
            {
                if (plant.Value.Count > 0)
                {
                    ratePlants.Add(plant.Key, new List<double>());
                    double avrgRate = plant.Value.Average();
                    ratePlants[plant.Key].Add(avrgRate);

                }
                else
                {
                    ratePlants.Add(plant.Key, new List<double>());
                    ratePlants[plant.Key].Add(0.00);

                }
            }
            foreach (var kvp in rarities)
            {
                double rarity = (double)kvp.Value;
                ratePlants[kvp.Key].Add(rarity);
            }
            ratePlants = ratePlants.OrderByDescending(x => x.Value[1]).ThenByDescending(x => x.Value[0]).ToDictionary(x => x.Key, x => x.Value);
            return ratePlants;
        }

        private static void Update(Dictionary<string, int> rarities, string[] cmdArgs)
        {
            string[] currArgs = cmdArgs[1].Split(" - ");
            string plant = currArgs[0];
            int rare = int.Parse(currArgs[1]);
            if (rarities.ContainsKey(plant))
            {
                rarities[plant] = rare;
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        private static void Rate(Dictionary<string, List<double>> ratings, string[] cmdArgs)
        {
            string[] currArgs = cmdArgs[1].Split(" - ");
            string plant = currArgs[0];
            double currRate = double.Parse(currArgs[1]);
            if (ratings.ContainsKey(plant))
            {
                ratings[plant].Add(currRate);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
