using System;
using System.Collections.Generic;
using System.Linq;
namespace HeroesOfCodeAndLogicVII1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();
            //-	a hero can have a maximum of 100 HP and 200 MP
            heroes = FullFillTheHeroes(n, heroes);

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split(" - ");
                string command = cmdArgs[0];
                switch (command)
                {
                    case "CastSpell":
                        CastSpell(heroes, cmdArgs);
                        break;
                    case "TakeDamage":

                        TakeDamage(heroes, cmdArgs);
                        break;
                    case "Recharge":

                        Recharge(heroes, cmdArgs);
                        break;
                    case "Heal":
                        Heal(heroes, cmdArgs);
                        break;
                    default:
                        break;
                }
            }

            heroes = PrintResult(heroes);

        }

        private static Dictionary<string, List<int>> PrintResult(Dictionary<string, List<int>> heroes)
        {
            heroes = heroes.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in heroes)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine($"  HP: {kvp.Value[0]}");
                Console.WriteLine($"  MP: {kvp.Value[1]}");
            }

            return heroes;
        }

        private static void Heal(Dictionary<string, List<int>> heroes, string[] cmdArgs)
        {
            string hero = cmdArgs[1];
            int amount = int.Parse(cmdArgs[2]);
            if (amount + heroes[hero][0] > 100)
            {
                amount = 100 - heroes[hero][0];
            }
            heroes[hero][0] += amount;
            Console.WriteLine($"{hero} healed for {amount} HP!");
        }

        private static void Recharge(Dictionary<string, List<int>> heroes, string[] cmdArgs)
        {
            string hero = cmdArgs[1];
            int amount = int.Parse(cmdArgs[2]);
            if (amount + heroes[hero][1] > 200)
            {
                amount = (200 - heroes[hero][1]);
            }

            heroes[hero][1] += amount;
            Console.WriteLine($"{hero} recharged for {amount} MP!");
        }

        private static void TakeDamage(Dictionary<string, List<int>> heroes, string[] cmdArgs)
        {
            string hero = cmdArgs[1];
            int damage = int.Parse(cmdArgs[2]);
            string attacker = cmdArgs[3];
            heroes[hero][0] -= damage;
            if (heroes[hero][0] <= 0)
            {
                Console.WriteLine($"{hero} has been killed by {attacker}!");
                heroes.Remove(hero);
            }
            else
            {
                Console.WriteLine($"{hero} was hit for {damage} HP by {attacker} and now has {heroes[hero][0]} HP left!");
            }
        }

        private static void CastSpell(Dictionary<string, List<int>> heroes, string[] cmdArgs)
        {
            string hero = cmdArgs[1];
            int mp = int.Parse(cmdArgs[2]);
            string spellName = cmdArgs[3];
            if (heroes[hero][1] >= mp)
            {
                heroes[hero][1] -= mp;
                Console.WriteLine($"{hero} has successfully cast {spellName} and now has {heroes[hero][1]} MP!");
            }
            else
            {
                Console.WriteLine($"{hero} does not have enough MP to cast {spellName}!");
            }
        }

        private static Dictionary<string,List<int>> FullFillTheHeroes(int n, Dictionary<string, List<int>> heroes)
        {
            for (int i = 0; i < n; i++)
            {
                string[] heroArgs = Console.ReadLine().Split();
                string hero = heroArgs[0];
                int hp = int.Parse(heroArgs[1]);
                int mp = int.Parse(heroArgs[2]);
                heroes.Add(hero, new List<int>() { hp, mp });
            }
            return heroes;
        }
    }
}
