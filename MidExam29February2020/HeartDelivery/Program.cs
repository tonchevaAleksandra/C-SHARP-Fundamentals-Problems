using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine()
                 .Split("@")
                 .Select(int.Parse)
                 .ToList();

            string input = string.Empty;
            int startIndex = 0;
            while ((input = Console.ReadLine()) != "Love!")
            {
                string[] cmdArgs = input.Split().ToArray();
                int length = int.Parse(cmdArgs[1]);
                if (length+startIndex > houses.Count - 1)
                {
                    startIndex = 0;
                }
                else
                {
                    startIndex = length + startIndex;
                }

                if (houses[startIndex] <= 0)
                {
                    Console.WriteLine($"Place {startIndex} already had Valentine's day.");
                }
                else
                {
                    houses[startIndex] -= 2;
                    if (houses[startIndex] <= 0)
                    {
                        Console.WriteLine($"Place {startIndex} has Valentine's day.");
                    }
                }


            }

            Console.WriteLine($"Cupid's last position was {startIndex}.");
            int count = 0;
            for (int i = 0; i < houses.Count; i++)
            {
                if(houses[i]==0)
                {
                    count++;
                }
            }
            if(count==houses.Count)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {houses.Count-count} places.");
            }
        }
    }
}
