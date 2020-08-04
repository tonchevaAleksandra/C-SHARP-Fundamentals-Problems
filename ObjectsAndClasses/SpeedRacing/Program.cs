using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                Car car = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]));
                cars.Add(car);
            }

            string command = string.Empty;

            while ((command=Console.ReadLine())!="End")
            {
                var cmdArgs = command.Split();
                string model = cmdArgs[1];
                int km = int.Parse(cmdArgs[2]);
                Car.CalculateKM(cars, model,km);
            }

            Console.WriteLine(string.Join(Environment.NewLine, cars));

        }
    }

    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double AmountOf1Km { get; set; }
        public int TraveledDistance { get; set; }
        public Car(string model, double fuelAmount, double amountOf1Km)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.AmountOf1Km = amountOf1Km;
        }

        public static void CalculateKM(List<Car> cars,string model,double km)
        {
            Car currModel = cars.Find(c => c.Model == model);
            double valueKm = (currModel.FuelAmount*1.00 / currModel.AmountOf1Km);
            
            if(km<=valueKm)
            {
                currModel.FuelAmount -= km * (currModel.AmountOf1Km);
                currModel.TraveledDistance += (int)km;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

        }

        public override string ToString()
        {
            return $"{Model} {FuelAmount:f2} {TraveledDistance}"; 
        }
    }
}
