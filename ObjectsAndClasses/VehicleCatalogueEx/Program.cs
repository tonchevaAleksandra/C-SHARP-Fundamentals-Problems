using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;

namespace VehicleCatalogueEx
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            string input = string.Empty;

            while ((input=Console.ReadLine())!="End")
            {
                string[] data = input.Split();
                string type = data[0];
                string model = data[1];
                string color = data[2];
                double horsePower = double.Parse(data[3]);
                Car currCar = new Car();
                Truck currTruck = new Truck();
                if(type=="car")
                {
                    currCar.Type = type;
                    currCar.Model = model;
                    currCar.Color = color;
                    currCar.HorsePower = horsePower;
                    cars.Add(currCar);
                }
                else
                {
                    currTruck.Type = type;
                    currTruck.Model = model;
                    currTruck.Color = color;
                    currTruck.HorsePower = horsePower;
                    trucks.Add(currTruck);
                }
            }

            string cmd = Console.ReadLine();
            while (cmd!= "Close the Catalogue")
            {
                Car existing = cars.Find(c => c.Model == cmd);
                Truck existingTruck = trucks.Find(t => t.Model == cmd);
                if(existing!= null)
                {
                    Console.WriteLine(existing.ToString());
                }
                else
                {
                    Console.WriteLine(existingTruck.ToString());
                }
                cmd = Console.ReadLine();
              
            }

            List<double> powerCars = new List<double>();
            List<double> powerTrucks = new List<double>();
            foreach (Car item in cars)
            {
                powerCars.Add(item.HorsePower);
            }

            foreach (Truck item in trucks)
            {
                powerTrucks.Add(item.HorsePower);
            }
            double avrgHorsePCars = powerCars.Sum() / cars.Count;
            double avrgHorsePTrucks = powerTrucks.Sum() / trucks.Count;
            if (cars.Count==0)
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {avrgHorsePCars:f2}.");
            }
           
            if(trucks.Count==0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }

            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {avrgHorsePTrucks:f2}."); 
            }

           
        }
    }

    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }

        public List<Car> Cars { get; set; }

        public List<Truck> Trucks { get; set; }
        
    }

    class Car
    {
        public string Type { get; set; }
        public string  Model { get; set; }
        public string  Color { get; set; }
        public double HorsePower { get; set; }

        public override string ToString()
        {
            string output = $"Type: {Type.First().ToString().ToUpper()+Type.Substring(1)}\n";
            output += $"Model: {Model}\nColor: {Color}\nHorsepower: {HorsePower}";
            
            return output.Trim();
        }
    }

    class Truck
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }

        public override string ToString()
        {
            string output = $"Type: {Type.First().ToString().ToUpper()+Type.Substring(1)}\n";
            output += $"Model: {Model}\nColor: {Color}\nHorsepower: {HorsePower}";
            return output.Trim();
        }
    }
}
