using System;
using System.Collections.Generic;
using System.Linq;

namespace ManOWar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> warShip = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int maxHealthBySection = int.Parse(Console.ReadLine());

            string input = string.Empty;

            while ((input=Console.ReadLine())!="Retire")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];

                if(command=="Fire")
                {
                    int index=int.Parse(cmdArgs[1]);
                    int damage= int.Parse(cmdArgs[2]);
                    if(index>=0 && index<warShip.Count)
                    {
                        warShip[index] -= damage;
                        if(warShip[index]<=0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }

                else if(command=="Defend")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    int damage = int.Parse(cmdArgs[3]);
                    if(startIndex>=0 && startIndex<pirateShip.Count && endIndex>=0 && endIndex<pirateShip.Count)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;
                            if(pirateShip[i]<=0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }

                else if(command=="Repair")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int health = int.Parse(cmdArgs[2]);
                    if(index>=0 && index<pirateShip.Count)
                    {
                        RepairShip(pirateShip, maxHealthBySection, index, health);
                    }
                    else
                    {
                        continue;
                    }
                }

                else if(command=="Status")
                {
                    int countToRepair = 0;
                    countToRepair = PrintStatusRepair(pirateShip, maxHealthBySection, countToRepair);
                }
            }

            int sumPirateShip = pirateShip.Sum();
            int sumWarShip = warShip.Sum();

            Console.WriteLine($"Pirate ship status: {sumPirateShip}");
            Console.WriteLine($"Warship status: {sumWarShip}");
        }

        private static void RepairShip(List<int> pirateShip, int maxHealthBySection, int index, int health)
        {
            pirateShip[index] += health;
            if (pirateShip[index] > maxHealthBySection)
            {
                pirateShip[index] = maxHealthBySection;
            }
        }

        private static int PrintStatusRepair(List<int> pirateShip, int maxHealthBySection, int countToRepair)
        {
            double percentage = 0.2 * maxHealthBySection;
            for (int i = 0; i < pirateShip.Count; i++)
            {
                if (pirateShip[i] < percentage)
                {
                    countToRepair++;
                }
            }
            Console.WriteLine($"{countToRepair} sections need repair.");
            return countToRepair;
        }
    }
}
