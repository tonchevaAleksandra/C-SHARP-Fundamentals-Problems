using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace BattleManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> hp = new Dictionary<string, int>();
            Dictionary<string, int> nrg = new Dictionary<string, int>();

            string input;
            while ((input = Console.ReadLine()) != "Results")
            {
                string[] cmdArgs = input.Split(":",StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                switch (command)
                {
                    case "Add":
                        Add(hp, nrg, cmdArgs);
                        break;
                    case "Attack":
                        Attack(hp, nrg, cmdArgs);
                        break;
                    case "Delete":
                        Delete(hp, nrg, cmdArgs);
                        break;
                    default:
                        break;
                }
            }

            PrintResults(hp, nrg);
        }

        private static void PrintResults(Dictionary<string, int> hp, Dictionary<string, int> nrg)
        {
            Console.WriteLine($"People count: { hp.Keys.Count}");

            hp = hp.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in hp)
            {
                string name = kvp.Key;
                int health = kvp.Value;
                int energy = nrg[name];
                Console.WriteLine($"{name} - {health} - {energy}");
            }
        }

        private static void Delete(Dictionary<string, int> hp, Dictionary<string, int> nrg, string[] cmdArgs)
        {
            string user = cmdArgs[1];
            if (user == "All")
            {
                hp.Clear();
                nrg.Clear();
            }
            else if(hp.ContainsKey(user))
            {
                hp.Remove(user);
                nrg.Remove(user);
            }
        }

        private static void Attack(Dictionary<string, int> hp, Dictionary<string, int> nrg, string[] cmdArgs)
        {
            string attacker = cmdArgs[1];
            string defender = cmdArgs[2];
            int damage = int.Parse(cmdArgs[3]);
            if (hp.ContainsKey(attacker) && hp.ContainsKey(defender))
            {
                hp[defender] -= damage;
                if (hp[defender] <= 0)
                {
                    hp.Remove(defender);
                    nrg.Remove(defender);
                    Console.WriteLine($"{defender} was disqualified!");
                }
                nrg[attacker]-=1;
                if (nrg[attacker] <= 0)
                {
                    hp.Remove(attacker);
                    nrg.Remove(attacker);
                    Console.WriteLine($"{attacker} was disqualified!");
                }
            }
        }

        private static void Add(Dictionary<string, int> hp, Dictionary<string, int> nrg, string[] cmdArgs)
        {
            string name = cmdArgs[1];
            int health = int.Parse(cmdArgs[2]);
            int energy = int.Parse(cmdArgs[3]);
            if (!hp.ContainsKey(name))
            {
                hp.Add(name, health);
                nrg.Add(name, energy);
            }
            else
            {
                hp[name] += health;
            }
            
           
        }
    }
}
