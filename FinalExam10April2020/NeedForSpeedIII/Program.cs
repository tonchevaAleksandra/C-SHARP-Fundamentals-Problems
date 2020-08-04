using System;
using System.Collections.Generic;
using System.Linq;

namespace NeedForSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> mileageCars = new Dictionary<string, int>();
            Dictionary<string, int> fuelSCars = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                //{ car}|{ mileage}|{ fuel}
                string[] carsArgs = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string car = carsArgs[0];
                int mileage = int.Parse(carsArgs[1]);
                int fuel = int.Parse(carsArgs[2]);
                mileageCars.Add(car, mileage);
                fuelSCars.Add(car, fuel);
            }

            string input;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] cmdArgs = input
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = cmdArgs[0];
                switch (command)
                {
                    case "Drive":
                        DriveTheCar(mileageCars, fuelSCars, cmdArgs);
                        break;
                    case "Refuel":
                        RefuelTheCar(fuelSCars, cmdArgs);
                        break;
                    case "Revert":
                        RevertKilometers(mileageCars, cmdArgs);
                        break;

                }
            }

            mileageCars = PrintCarsStatus(mileageCars, fuelSCars);
        }

        private static Dictionary<string, int> PrintCarsStatus(Dictionary<string, int> mileageCars, Dictionary<string, int> fuelSCars)
        {
            mileageCars = mileageCars.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in mileageCars)
            {
                int fuel = fuelSCars[kvp.Key];
                Console.WriteLine($"{kvp.Key} -> Mileage: {kvp.Value} kms, Fuel in the tank: {fuel} lt.");
            }

            return mileageCars;
        }

        private static void RevertKilometers(Dictionary<string, int> mileageCars, string[] cmdArgs)
        {
            string carName = cmdArgs[1];
            int km = int.Parse(cmdArgs[2]);
            if (mileageCars[carName] - km > 10000)
            {
                mileageCars[carName] -= km;
                Console.WriteLine($"{carName} mileage decreased by {km} kilometers");
            }
            else
            {
                mileageCars[carName] = 10000;
            }
        }

        private static void RefuelTheCar(Dictionary<string, int> fuelSCars, string[] cmdArgs)
        {
            string carName = cmdArgs[1];
            int fuel = int.Parse(cmdArgs[2]);

            if (fuelSCars[carName] + fuel > 75)
            {
                fuel = 75 - fuelSCars[carName];
            }
            fuelSCars[carName] += fuel;
            Console.WriteLine($"{carName} refueled with {fuel} liters");
        }

        private static void DriveTheCar(Dictionary<string, int> mileageCars, Dictionary<string, int> fuelSCars, string[] cmdArgs)
        {
            string carName = cmdArgs[1];
            int distance = int.Parse(cmdArgs[2]);
            int fuel = int.Parse(cmdArgs[3]);
            if (fuelSCars[carName] < fuel)
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
            else
            {
                mileageCars[carName] += distance;
                fuelSCars[carName] -= fuel;
                Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                if (mileageCars[carName] >= 100000)
                {
                    Console.WriteLine($"Time to sell the {carName}!");
                    fuelSCars.Remove(carName);
                    mileageCars.Remove(carName);
                }
            }
        }
    }
}
