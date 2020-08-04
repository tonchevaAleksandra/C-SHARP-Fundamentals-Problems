using System;
using System.Collections.Generic;
using System.Linq;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rooms = Console.ReadLine()
                .Split("|")
                .ToList();
            int health = 100;
            int bitcoins = 0;

            bool isDeath = false;

            for (int i = 0; i < rooms.Count; i++)
            {
                string[] cmdArgs = rooms[i].Split().ToArray();
                string command = cmdArgs[0];
                if (command == "potion")
                {
                    int currHealth = int.Parse(cmdArgs[1]);

                    if (health == 100)
                    {
                        continue;
                    }
                    else
                    {
                        if (currHealth + health > 100)
                        {
                            currHealth = 100 - health;
                        }

                        health += currHealth;
                        Console.WriteLine($"You healed for {currHealth} hp.");
                        Console.WriteLine($"Current health: {health} hp.");

                    }
               }

                else if (command == "chest")
                {
                    int coins = int.Parse(cmdArgs[1]);
                    bitcoins += coins;
                    Console.WriteLine($"You found {coins} bitcoins.");

                }

                else
                {
                    int attack = int.Parse(cmdArgs[1]);
                    health -= attack;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {command}.");

                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        isDeath = true;
                        break;
                    }
                }
            }

            if (!isDeath)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
