using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace PracticeSessions
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> roads = new Dictionary<string, List<string>>();
            string input;
            while ((input=Console.ReadLine())!="END")
            {
                string[] cmdArgs = input.Split("->");
                string command = cmdArgs[0];
                switch (command)
                {
                    case "Add":
                       roads= Add(roads, cmdArgs);
                        break;
                    case "Move":
                        roads=Move(roads, cmdArgs);
                        break;
                    case "Close":
                        string road = cmdArgs[1];
                        if(roads.ContainsKey(road))
                        {
                            roads.Remove(road);
                        }
                        break;
                   
                }

            }

            roads = roads.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine("Practice sessions:");
            foreach (var kvp in roads.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value))
            {
                Console.WriteLine(kvp.Key);
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"++{item}");
                }
            }


        }

        private static Dictionary<string, List<string>> Move(Dictionary<string, List<string>> roads, string[] cmdArgs)
        {
            string currRoad = cmdArgs[1];
            string racer = cmdArgs[2];
            string nextRoad = cmdArgs[3];
            if (roads[currRoad].Contains(racer))
            {
                roads[currRoad].Remove(racer);
                roads[nextRoad].Add(racer);
            }
            return roads;
        }

        private static Dictionary<string, List<string>> Add(Dictionary<string, List<string>> roads, string[] cmdArgs)
        {
            string road = cmdArgs[1];
            string racer = cmdArgs[2];
            if (!roads.ContainsKey(road))
            {
                roads.Add(road, new List<string>());
            }
           
                roads[road].Add(racer);
            
            return roads; 
        }
    }
}
