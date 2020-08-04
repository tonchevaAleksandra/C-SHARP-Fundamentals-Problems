using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<Dragon>> dragons = new Dictionary<string, List<Dragon>>();

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();
                string type = inputArgs[0];
                string name = inputArgs[1];
                int damage = 0;
                int health = 0;
                int armor = 0;

                CheckForNullParameters(inputArgs, out damage, out health, out armor);

                Dragon current = new Dragon(name, damage, health, armor);

                if (!dragons.ContainsKey(type))
                {
                    List<Dragon> curr = new List<Dragon>();
                    curr.Add(current);
                    dragons.Add(type, curr);
                }
                else
                {
                    bool isFound = false;
                    isFound = CheckNameInTheList(dragons, type, name, current, isFound);

                    if (!isFound)
                    {
                        dragons[type].Add(current);
                    }
                }
            }

            PrintStatisticsDragons(dragons);

        }

        private static void CheckForNullParameters(string[] inputArgs, out int damage, out int health, out int armor)
        {
            if (inputArgs[2] == "null")
            {
                damage = 45;
            }
            else
            {
                damage = int.Parse(inputArgs[2]);
            }
            if (inputArgs[3] == "null")
            {
                health = 250;
            }
            else
            {
                health = int.Parse(inputArgs[3]);
            }
            if (inputArgs[4] == "null")
            {
                armor = 10;
            }
            else
            {
                armor = int.Parse(inputArgs[4]);
            }
        }

        private static bool CheckNameInTheList(Dictionary<string, List<Dragon>> dragons, string type, string name, Dragon current, bool isFound)
        {
            foreach (var item in dragons[type])
            {
                if (item.Name == name)
                {
                    dragons[type].Remove(item);
                    dragons[type].Add(current);
                    isFound = true;
                    break;
                }
            }

            return isFound;
        }

        private static void PrintStatisticsDragons(Dictionary<string, List<Dragon>> dragons)
        {
            foreach (var kvp in dragons)
            {
                var current = kvp.Value.OrderBy(x => x.Name);
                var avrgDamage = kvp.Value.Select(x => x.Damage).Average();
                var avrgHealth = kvp.Value.Select(x => x.Health).Average();
                var avrgArmor = kvp.Value.Select(x => x.Armor).Average();

                Console.WriteLine($"{kvp.Key}::({avrgDamage:f2}/{avrgHealth:f2}/{avrgArmor:f2})");

                foreach (var item in current)
                {
                    Console.WriteLine($"-{item.Name} -> damage: {item.Damage}, health: {item.Health}, armor: {item.Armor}");
                }
            }
        }
    }

    class Dragon
    {
        public string Name { get; set; }

        public int Damage { get; set; }

        public int Health { get; set; }

        public int Armor { get; set; }

        public Dragon(string name, int damage, int health, int armor)
        {
            this.Name = name;
            this.Damage = damage;
            this.Health = health;
            this.Armor = armor;
        }
    }
}
