using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroRecruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> spellBook = new Dictionary<string, List<string>>();

            string input;

            while ((input=Console.ReadLine())!="End")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];

                switch (command)
                {
                    case "Enroll":
                       spellBook= EnrollHeroes(spellBook, cmdArgs);
                        break;
                    case "Learn":
                       spellBook= LearnHeroes(spellBook, cmdArgs);
                        break;

                    case "Unlearn":
                        UnlearnHeroes(spellBook, cmdArgs);
                        break;
                   
                }
            }

            spellBook = spellBook.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
       
            Console.WriteLine("Heroes:");
            foreach (var kvp in spellBook)
            {             
                string spells= string.Join(", ",kvp.Value);
                Console.WriteLine($"== {kvp.Key}: {spells}");
            }
        }

        private static void UnlearnHeroes(Dictionary<string, List<string>> spellBook, string[] cmdArgs)
        {
            string hero = cmdArgs[1];
            string spell = cmdArgs[2];
            if (spellBook.ContainsKey(hero))
            {
                if (spellBook[hero].Contains(spell))
                {
                    spellBook[hero].Remove(spell);
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

        private static Dictionary<string,List<string>> LearnHeroes(Dictionary<string, List<string>> spellBook, string[] cmdArgs)
        {
            string hero = cmdArgs[1];
            string spell = cmdArgs[2];
            if (spellBook.ContainsKey(hero))
            {
                if (spellBook[hero].Contains(spell))
                {
                    Console.WriteLine($"{hero} has already learnt {spell}.");
                }
                else
                {
                    spellBook[hero].Add(spell);
                }
            }

            else
            {
                Console.WriteLine($"{hero} doesn't exist.");
            }

            return spellBook;
        }

        private static Dictionary<string,List<string>> EnrollHeroes(Dictionary<string, List<string>> spellBook, string[] cmdArgs)
        {
            string hero = cmdArgs[1];
            if (spellBook.ContainsKey(hero))
            {
                Console.WriteLine($"{hero} is already enrolled.");
            }
            else
            {
                spellBook.Add(hero, new List<string>());
            }

            return spellBook;
        }
    }
}
