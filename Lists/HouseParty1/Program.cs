using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < n; i++)
            {
                List<string> command = Console.ReadLine()
                    .Split()
                    .ToList();

                string name = command[0];
                bool isInTheList = CheckIfGuestIsInTheList(guests, name);
                if (isInTheList)
                {
                    if (command[2] == "going!")
                    {
                        Console.WriteLine($"{name} is already in the list!");

                    }
                    else
                    {
                        guests.Remove(name);

                    }
                }
                else
                {
                    if (command[2] == "going!")
                    {
                        guests.Add(name);

                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");

                    }
                }
            }

            PrintListOfGuests(guests);
        }

        private static void PrintListOfGuests(List<string> guests)
        {
            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }
        }

        private static bool CheckIfGuestIsInTheList(List<string> guests, string name)
        {
            bool isInTheList = false;
            if(guests.Contains(name))
            {
                isInTheList = true;
            }

            return isInTheList;
        }
    }
}
