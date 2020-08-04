using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, List<string>> ages = new Dictionary<int, List<string>>();
            ages[28] = new List<string>();
            ages[28].Add("Pesho");
            ages[28].Add("Pesho");



            Dictionary<string, double> fruits = new Dictionary<string, double>();
            fruits["banana"] = 2.20;
            fruits["apple"] = 1.40;
            fruits["kiwi"] = 3.20;
            Console.WriteLine(string.Join(" ",fruits.Keys));
            Console.WriteLine(string.Join(" ", fruits.Values));
            var fruit = new SortedDictionary<string, double>();
            fruit["kiwi"] = 4.50;
            fruit["orange"] = 2.50;
            fruit["banana"] = 2.20;
            Console.WriteLine(string.Join(" ", fruit.Keys));
            Console.WriteLine(string.Join(" ", fruits.Values));
            var airplanes = new Dictionary<string, int>();
            airplanes.Add("Boeing 737", 130);
            airplanes.Add("Airbus A320", 150);
            airplanes.Remove("Boeing 737");
            if(airplanes.ContainsKey("Airbus A320"))
            {
                Console.WriteLine($"Airbus A320 key exists");

            }
            airplanes.Add("Boeing 737", 130);
            Console.WriteLine(airplanes.ContainsValue(130));
            Console.WriteLine(airplanes.ContainsValue(180));


            Dictionary<string, int> students = new Dictionary<string, int>();

            Console.WriteLine(students.Count);
            students.Add("Dimitrichko", 55);
            Console.WriteLine(students.Count);
            Console.WriteLine(students["Dimitrichko"]);
            students.Add("Pesho", 17);
            //can not add a cell with the same key name, the key is unique


        }
    }

}
