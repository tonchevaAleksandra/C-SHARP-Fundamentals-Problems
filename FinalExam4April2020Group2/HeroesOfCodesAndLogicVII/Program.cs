using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesOfCodesAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> manaHeroes = new Dictionary<string, int>();
            Dictionary<string, int> hpHeroes = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                //max 100 HP & 200 MP 
                string[] heroesArgs = Console.ReadLine()
                    .Split();
                string name = heroesArgs[0];
                int hitPoints = int.Parse(heroesArgs[1]);
                int manaPoints = int.Parse(heroesArgs[2]);
                manaHeroes.Add(name, manaPoints);
                hpHeroes.Add(name, hitPoints);
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                switch (command)
                {
                    case "CastSpell":
                        CastSpell(manaHeroes, cmdArgs);
                        break;
                    case "TakeDamage":

                        TakeDamage(manaHeroes, hpHeroes, cmdArgs);
                        break;
                    case "Recharge":

                        Recharge(manaHeroes, cmdArgs);
                        break;
                    case "Heal":

                        Heal(hpHeroes, cmdArgs);
                        break;
                }
            }

            hpHeroes = PrintStatistics(manaHeroes, hpHeroes);
        }

        private static Dictionary<string, int> PrintStatistics(Dictionary<string, int> manaHeroes, Dictionary<string, int> hpHeroes)
        {
            hpHeroes = hpHeroes.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var hero in hpHeroes)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value}");
                Console.WriteLine($"  MP: {manaHeroes[hero.Key]}");
            }

            return hpHeroes;
        }

        private static void Heal(Dictionary<string, int> hpHeroes, string[] cmdArgs)
        {
            string heroName = cmdArgs[1];
            int amount = int.Parse(cmdArgs[2]);
            if (hpHeroes[heroName] + amount > 100)
            {
                amount = 100 - hpHeroes[heroName];
            }
            hpHeroes[heroName] += amount;
            Console.WriteLine($"{heroName} healed for {amount} HP!");
        }

        private static void Recharge(Dictionary<string, int> manaHeroes, string[] cmdArgs)
        {
            string heroName = cmdArgs[1];
            int amount = int.Parse(cmdArgs[2]);
            if (manaHeroes[heroName] + amount > 200)
            {
                amount = 200 - manaHeroes[heroName];
            }
            manaHeroes[heroName] += amount;
            Console.WriteLine($"{heroName} recharged for {amount} MP!");
        }

        private static void TakeDamage(Dictionary<string, int> manaHeroes, Dictionary<string, int> hpHeroes, string[] cmdArgs)
        {
            string heroName = cmdArgs[1];
            int damage = int.Parse(cmdArgs[2]);
            string attacker = cmdArgs[3];
            hpHeroes[heroName] -= damage;
            if (hpHeroes[heroName] <= 0)
            {
                Console.WriteLine($"{heroName} has been killed by {attacker}!");
                hpHeroes.Remove(heroName);
                manaHeroes.Remove(heroName);
            }
            else
            {
                Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {hpHeroes[heroName]} HP left!");
            }
        }

        private static void CastSpell(Dictionary<string, int> manaHeroes, string[] cmdArgs)
        {
            string heroName = cmdArgs[1];
            int neededMP = int.Parse(cmdArgs[2]);
            string spellName = cmdArgs[3];
            if (manaHeroes.ContainsKey(heroName) && manaHeroes[heroName] >= neededMP)
            {
                manaHeroes[heroName] -= neededMP;
                Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {manaHeroes[heroName]} MP!");
            }
            else
            {
                Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
            }
        }
    }
}
