using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> passengersOnWagon = Console.ReadLine()
                .Split()
            .Select(int.Parse)
                .ToList();

            int capacityOfWagon = int.Parse(Console.ReadLine());

            string command = string.Empty;
            command = FitWagonsAndPassengers(passengersOnWagon, capacityOfWagon);

            Console.WriteLine(string.Join(" ", passengersOnWagon));
        }

        private static string FitWagonsAndPassengers(List<int> passengersOnWagon, int capacityOfWagon)
        {
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] currCommand = command.Split().ToArray();
                if (currCommand[0] == "Add")
                {
                    int passengerAdd = int.Parse(currCommand[1]);
                    passengersOnWagon.Add(passengerAdd);
                }

                else
                {
                    FitPassengersToExictingWagons(passengersOnWagon, capacityOfWagon, currCommand);

                }
            }

            return command;
        }

        private static void FitPassengersToExictingWagons(List<int> passengersOnWagon, int capacityOfWagon, string[] currCommand)
        {
            int passengers = int.Parse(currCommand[0]);
            for (int i = 0; i < passengersOnWagon.Count; i++)
            {
                if (passengersOnWagon[i] + passengers <= capacityOfWagon)
                {
                    passengersOnWagon[i] += passengers;
                    break;
                }
            }
        }
    }
}
