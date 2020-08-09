using System;
using System.Collections.Generic;
using System.Linq;

namespace NeedForSpeed1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>();
            cars = AddCarsToRegister(n, cars);
            string input;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] cmdArgs = input.Split(" : ");
                string command = cmdArgs[0];
                switch (command)
                {
                    case "Drive":
                        cars = Drive(cars, cmdArgs);
                        break;
                    case "Refuel":
                        Refuel(cars, cmdArgs);
                        break;
                    case "Revert":
                        Revert(cars, cmdArgs);
                        break;
                    default:
                        break;
                }
            }

            cars = PrintResult(cars);

        }

        private static Dictionary<string, List<int>> PrintResult(Dictionary<string, List<int>> cars)
        {
            cars = cars.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }

            return cars;
        }

        private static void Revert(Dictionary<string, List<int>> cars, string[] cmdArgs)
        {
            string car = cmdArgs[1];
            int km = int.Parse(cmdArgs[2]);
            if (cars[car][0] - km < 10000)
            {
                cars[car][0] = 10000;
            }
            else
            {
                Console.WriteLine($"{car} mileage decreased by {km} kilometers");
                cars[car][0] -= km;
            }
        }

        private static void Refuel(Dictionary<string, List<int>> cars, string[] cmdArgs)
        {
            string car = cmdArgs[1];
            int fuel = int.Parse(cmdArgs[2]);
            if (fuel + cars[car][1] > 75)
            {
                fuel = (75 - cars[car][1]);
            }
            cars[car][1] += fuel;
            Console.WriteLine($"{car} refueled with {fuel} liters");
        }

        private static Dictionary<string,List<int>> Drive(Dictionary<string, List<int>> cars, string[] cmdArgs)
        {
            string car = cmdArgs[1];
            int distance = int.Parse(cmdArgs[2]);
            int fuel = int.Parse(cmdArgs[3]);
            if (cars[car][1] >= fuel)
            {
                cars[car][1] -= fuel;
                cars[car][0] += distance;
                Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                if (cars[car][0] >= 100000)
                {
                    Console.WriteLine($"Time to sell the {car}!");
                    cars.Remove(car);
                }

            }
            else
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
            return cars;
        }

        private static Dictionary<string,List<int>> AddCarsToRegister(int n, Dictionary<string, List<int>> cars)
        {
            for (int i = 0; i < n; i++)
            {
                //{ car}|{ mileage}|{ fuel}
                string[] carArgs = Console.ReadLine().Split("|");
                string car = carArgs[0];
                int mileage = int.Parse(carArgs[1]);
                int fuel = int.Parse(carArgs[2]);
                if (!cars.ContainsKey(car))
                {
                    cars.Add(car, new List<int>());
                }
                cars[car].Add(mileage);
                cars[car].Add(fuel);
            }
            return cars;
        }
    }
    
}
