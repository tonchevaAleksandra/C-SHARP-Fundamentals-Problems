using System;
using System.Collections.Generic;
using System.Linq;

namespace NikuldensMeal1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, List<string>> guests = new Dictionary<string, List<string>>();
            int unlikeMeals = 0;
            string input;
            while ((input=Console.ReadLine())!="Stop")
            {
                string[] cmdArgs = input.Split("-");
                string command = cmdArgs[0];
                switch (command)
                {
                    case "Like":
                        Like(guests, cmdArgs);
                        break;
                    case "Unlike":
                        Unlike(guests, cmdArgs, ref unlikeMeals);
                        break;
                    default:
                        break;
                }
            }
            guests = guests.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var kvp in guests)
            {
                string result = string.Join(", ", kvp.Value);
                Console.WriteLine($"{kvp.Key}: {result}");
            }
            Console.WriteLine($"Unliked meals: {unlikeMeals}");
        }

        private static void Unlike(Dictionary<string, List<string>> guests, string[] cmdArgs, ref int unlikeMeals)
        {
            string name = cmdArgs[1];
            string meal = cmdArgs[2];
            if (!guests.ContainsKey(name))
            {
                Console.WriteLine($"{name} is not at the party.");
            }

            else
            {
                if (guests[name].Contains(meal))
                {
                    guests[name].Remove(meal);
                    Console.WriteLine($"{name} doesn't like the {meal}.");
                    unlikeMeals++;
                }
                else
                {
                    Console.WriteLine($"{name} doesn't have the {meal} in his/her collection.");
                }
            }
        }

        private static void Like(Dictionary<string, List<string>> guests, string[] cmdArgs)
        {
            string name = cmdArgs[1];
            string meal = cmdArgs[2];
            if (!guests.ContainsKey(name))
            {
                guests.Add(name, new List<string>());
            }
            if (!guests[name].Contains(meal))
            {
                guests[name].Add(meal);
            }
        }
    }
}
