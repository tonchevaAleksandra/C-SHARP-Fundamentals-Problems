using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            
            while ((input=Console.ReadLine())!="end")
            {
                string[] data = input.Split("/");
                string type = data[0];
                string brand = data[1];
                string model = data[2];
                int horsePOrWeight = int.Parse(data[3]);
                Car currCar = new Car();
                Truck currTruck = new Truck();
                if(type=="Car")
                {
                    currCar.Brand = brand;
                    currCar.Model = model;
                    currCar.HorsePower = horsePOrWeight;
                    cars.Add(currCar);
                }
                else
                {
                    currTruck.Brand = brand;
                    currTruck.Model = model;
                    currTruck.Weight = horsePOrWeight;
                    trucks.Add(currTruck);
                }
            }

            List<Car> sortedCars = cars.OrderBy(c => c.Brand).ToList();
            List<Truck> sortedTruck = trucks.OrderBy(t => t.Brand).ToList();

            if (sortedCars.Count > 0)
            {
                Console.WriteLine("Cars:");
            }

            foreach (Car car in sortedCars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            if (sortedTruck.Count > 0)
            {
                Console.WriteLine("Trucks:");
            }

            foreach (Truck truck in sortedTruck)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Cataloque
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }

    
}
