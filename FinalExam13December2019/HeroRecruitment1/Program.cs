using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroRecruitment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                switch (command)
                {
                    case "Enroll":
                        heroes = Enroll(heroes, cmdArgs);
                        break;
                    case "Learn":
                        heroes = Learn(heroes, cmdArgs);
                        break;
                    case "Unlearn":
                        Unlearn(heroes, cmdArgs);
                        break;
                    default:
                        break;
                }
            }

            heroes = PrintResults(heroes);
        }

        private static Dictionary<string, List<string>> PrintResults(Dictionary<string, List<string>> heroes)
        {
            heroes = heroes.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine("Heroes:");
            foreach (var hero in heroes)
            {
                string result = string.Join(", ", hero.Value);
                Console.WriteLine($"== { hero.Key}: { result}");
            }

            return heroes;
        }

        private static void Unlearn(Dictionary<string, List<string>> heroes, string[] cmdArgs)
        {
            string hero = cmdArgs[1];
            string spell = cmdArgs[2];
            if (heroes.ContainsKey(hero))
            {
                if (heroes[hero].Contains(spell))
                {
                    heroes[hero].Remove(spell);
                }
                else
                {
                    Console.WriteLine($"{hero} doesn't know {spell}.");
                }
            }
            else
            {
                Console.WriteLine($"{hero} doesn't exist.");
            }
        }

        private static Dictionary<string,List<string>> Learn(Dictionary<string,List<string>>heroes, string[] cmdArgs)
        {
            string name = cmdArgs[1];
            string spell = cmdArgs[2];
            if(heroes.ContainsKey(name))
            {
                if(heroes[name].Contains(spell))
                {
                    Console.WriteLine($"{name} has already learnt {spell}.");
                }
                else
                {
                    heroes[name].Add(spell);
                }
            }
            else
            {
                Console.WriteLine($"{name} doesn't exist.");
            }
            return heroes;
        }

        private static Dictionary<string,List<string>> Enroll(Dictionary<string,List<string>> heroes,string[] cmdArgs)
        {
            string name = cmdArgs[1];
            if (!heroes.ContainsKey(name))
            {
                heroes.Add(name, new List<string>());
            }
            else
            {
                Console.WriteLine($"{name} is already enrolled.");
            }
            return heroes;
        }
    }
}
