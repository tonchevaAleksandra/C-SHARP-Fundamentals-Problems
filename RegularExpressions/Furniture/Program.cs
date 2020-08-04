using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @">>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";

            string input;
            decimal totalSum = 0.0m;
            List<string> furnitures = new List<string>();

            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match current = Regex.Match(input, regex);

                if (current.Success)
                {
                    var name = current.Groups["name"].Value;
                    decimal price = decimal.Parse(current.Groups["price"].Value);
                    long quantity = long.Parse(current.Groups["quantity"].Value);
                    furnitures.Add(name);
                    totalSum += price * quantity;

                }
            }
            Console.WriteLine("Bought furniture:");
            if (furnitures.Count > 0)
            {

                Console.WriteLine(string.Join(Environment.NewLine, furnitures));

            }
            Console.WriteLine($"Total money spend: {totalSum:f2}");
        }
    }
}
