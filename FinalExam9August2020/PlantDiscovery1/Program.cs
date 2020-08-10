using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantDiscovery1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();
            int n = int.Parse(Console.ReadLine());
            plants = AddPlantsAndRarirty(plants, n);

            string input;
            while ((input = Console.ReadLine()) != "Exhibition")
            {

                string[] cmdArgs = input.Split(new char[] { ':', '-',' ' }, StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];

                plants = SwitchCommand(plants, cmdArgs, command);
            }

            plants = PrintPlants(plants);
        }

        private static Dictionary<string, Plant> PrintPlants(Dictionary<string, Plant> plants)
        {
            plants = plants.OrderByDescending(x => x.Value.Rarity).ThenByDescending(x => x.Value.Rating.Count() > 0 ? x.Value.Rating.Average() : 0).ToDictionary(a => a.Key, a => a.Value);
            Console.WriteLine($"Plants for the exhibition:");
            foreach (var kvp in plants)
            {
                double average = 0;
                if (kvp.Value.Rating.Count > 0)
                {
                    average = kvp.Value.Rating.Average();
                }
                Console.WriteLine($"- {kvp.Key}; Rarity: {kvp.Value.Rarity}; Rating: {average:F2}");
            }

            return plants;
        }

        private static Dictionary<string, Plant> SwitchCommand(Dictionary<string, Plant> plants, string[] cmdArgs, string command)
        {
            switch (command)
            {
                case "Rate":
                    plants = Rate(plants, cmdArgs);
                    break;
                case "Update":
                    plants = Update(plants, cmdArgs);
                    break;
                case "Reset":
                    plants = Reset(plants, cmdArgs);
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

            return plants;
        }

        private static Dictionary<string, Plant> Reset(Dictionary<string, Plant> plants, string[] cmdArgs)
        {
            //•	Reset: { plant} – remove all the ratings of the given plant
            string plant = cmdArgs[1];
            if (plants.ContainsKey(plant))
            {
                plants[plant].Rating.Clear();
            }
            else
            {
                Console.WriteLine("error");
            }
            return plants;
        }

        private static Dictionary<string, Plant> Update(Dictionary<string, Plant> plants, string[] cmdArgs)
        {
            //•	Update { plant}
            //- { new_rarity} – update the rarity of the plant with the new one
            string plant = cmdArgs[1];
            int rarity = int.Parse(cmdArgs[2]);
            if (plants.ContainsKey(plant))
            {
                plants[plant].Rarity = rarity;
            }
            else
            {
                Console.WriteLine("error");
            }
            return plants;
        }

        private static Dictionary<string, Plant> AddPlantsAndRarirty(Dictionary<string, Plant> plants, int n)
        {
            for (int i = 0; i < n; i++)
            {
                //"{plant}<->{rarity}"
                string[] components = Console.ReadLine().Split("<->");
                string plant = components[0];
                int rarity = int.Parse(components[1]);
                if (!plants.ContainsKey(plant))
                {
                    plants.Add(plant, new Plant(rarity, new List<double>()));
                }
                plants[plant].Rarity = rarity;
            }
            return plants;
        }

        private static Dictionary<string, Plant> Rate(Dictionary<string, Plant> plants, string[] cmdArgs)
        {
            string plant = cmdArgs[1];
            double rating = double.Parse(cmdArgs[2]);
            if (plants.ContainsKey(plant))
            {
                plants[plant].Rating.Add(rating);
            }
            else
            {
                Console.WriteLine("error");
            }
            return plants;
        }
    }
    class Plant
    {
        public int Rarity { get; set; }
        public List<double> Rating { get; set; }

        public Plant(int rarity,List<double> rating)
        {
            this.Rarity = rarity;
            this.Rating = rating;
        }
    }
}
