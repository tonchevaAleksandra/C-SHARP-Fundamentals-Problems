using System;
using System.Collections.Generic;
using System.Linq;

namespace NikuldensMeal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> likedMeals = new Dictionary<string, List<string>>();
            int countUnlikedMeals = 0;
            string input;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] cmdArgs = input.Split("-");
                string command = cmdArgs[0];
                switch (command)
                {
                    case "Like":
                        Like(likedMeals, cmdArgs);
                        break;
                    case "Unlike":
                        countUnlikedMeals = Unlike(likedMeals, countUnlikedMeals, cmdArgs);
                        break;
                    default:
                        break;
                }
            }
            likedMeals = PrintResult(likedMeals, countUnlikedMeals);
        }

        private static Dictionary<string, List<string>> PrintResult(Dictionary<string, List<string>> likedMeals, int countUnlikedMeals)
        {
            likedMeals = likedMeals.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);


            foreach (var kvp in likedMeals)
            {
                Console.WriteLine($"{kvp.Key}: {string.Join(", ", kvp.Value)}");
            }
            Console.WriteLine($"Unliked meals: {countUnlikedMeals}");
            return likedMeals;
        }

        private static int Unlike(Dictionary<string, List<string>> likedMeals, int countUnlikedMeals, string[] cmdArgs)
        {
            string guest = cmdArgs[1];
            string meal = cmdArgs[2];
            if (likedMeals.ContainsKey(guest))
            {
                if (likedMeals[guest].Contains(meal))
                {
                    likedMeals[guest].Remove(meal);
                    countUnlikedMeals++;
                    Console.WriteLine($"{guest} doesn't like the {meal}.");
                }
                else
                {
                    Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                }
            }
            else
            {
                Console.WriteLine($"{guest} is not at the party.");
            }

            return countUnlikedMeals;
        }

        private static void Like(Dictionary<string, List<string>> likedMeals, string[] cmdArgs)
        {
            string guest = cmdArgs[1];
            string meal = cmdArgs[2];
            if (!likedMeals.ContainsKey(guest))
            {
                likedMeals.Add(guest, new List<string>());
                likedMeals[guest].Add(meal);
            }
            else
            {
                if (!likedMeals[guest].Contains(meal))
                {
                    likedMeals[guest].Add(meal);
                }

            }
        }
    }
}
