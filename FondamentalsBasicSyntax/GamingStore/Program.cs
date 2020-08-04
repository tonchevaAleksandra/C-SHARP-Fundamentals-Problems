using System;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal ballance = decimal.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            decimal price = 0;
            decimal totalSpent = 0;

            while (command != "Game Time")
            {
                bool isExisting = true;
                string game = command;
                switch (game)
                {
                    case "OutFall 4":
                        price = 39.99M;
                        break;
                    case "CS: OG":
                        price = 15.99M;
                        break;
                    case "Zplinter Zell":
                        price = 19.99M;
                        break;
                    case "Honored 2":
                        price = 59.99M;
                        break;
                    case "RoverWatch":
                        price = 29.99M;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99M;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        isExisting = false;
                        break;
                }
                ballance -= price;
                if (ballance == 0)
                {
                    Console.WriteLine($"Bought {game}");
                    Console.WriteLine("Out of money!");
                    totalSpent += price;
                    return;
                }

                else if (isExisting && ballance > 0)
                {
                    Console.WriteLine($"Bought {game}");
                    totalSpent += price;
                }
                else if (ballance < 0)
                {
                    Console.WriteLine("Too Expensive");
                    ballance += price;
                    
                }
                command = Console.ReadLine();
            }

            if (command == "Game Time")
            {
                Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${ballance}");
            }
        }
    }
}
