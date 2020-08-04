using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var currCarInfo = Console.ReadLine().Split();
                Engine currEngine = new Engine(int.Parse(currCarInfo[1]), int.Parse(currCarInfo[2]));
                Cargo currCargo = new Cargo(int.Parse(currCarInfo[3]), currCarInfo[4]);
                Car car = new Car(currCarInfo[0], currEngine, currCargo);
                cars.Add(car);
            }

            string command = Console.ReadLine();
            switch (command)
            {
                case "fragile":
                    FindFragileType(cars);
                    break;

                case "flamable":
                    FindFlamableType(cars);
                    break;
            }
        }

        private static void FindFlamableType(List<Car> cars)
        {
            List<Car> flamableCargo = cars.Where(c => c.Cargo.CargoType == "flamable" && c.Engine.EnginePower > 250).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, flamableCargo));
        }

        private static void FindFragileType(List<Car> cars)
        {
            List<Car> fragileCargo = cars.Where(c => c.Cargo.CargoType == "fragile" && c.Cargo.CargoWeight < 1000).ToList();

            Console.WriteLine(string.Join(Environment.NewLine,fragileCargo));
        }
    }

    class Car
    {
        public string Model  { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

        public Car(string model, Engine engine,Cargo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
        }

        public override string ToString()
        {
            return $"{Model}";
        }
    }
    class Cargo
    {
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }

        public Cargo(int cargoWeight, string cargoType)
        {
            this.CargoWeight = cargoWeight;
            this.CargoType = cargoType;
        }
    }
    class Engine
    {
        public int EngineSpeed { get; set; }
        public int EnginePower{ get; set; }

        public Engine(int engineSpeed, int enginePower)
        {
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }
    }
}
