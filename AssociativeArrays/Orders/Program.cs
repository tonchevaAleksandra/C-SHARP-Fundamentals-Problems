using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> productPrices = new Dictionary<string, decimal>();

            Dictionary<string, long> productQuantity = new Dictionary<string, long>();

            // if we hade to take the price for every quantity=>
            //Dictionary<string, Dictionary<decimal, long>> repo = new Dictionary<string, Dictionary<decimal, long>>();
            //repo["Beer"].Sum(kvp => kvp.Key * kvp.Value);

            string input;

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] productArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = productArgs[0];
                decimal price = decimal.Parse(productArgs[1]);
                int quantity = int.Parse(productArgs[2]);

                if (!productQuantity.ContainsKey(name))
                {
                    productPrices[name] = 0;
                    productQuantity[name] = 0;
                }

                productQuantity[name] += quantity;
                productPrices[name] = price;
            }

            PrintOutput(productPrices, productQuantity);
        }

        private static void PrintOutput(Dictionary<string, decimal> productPrices, Dictionary<string, long> productQuantity)
        {
            foreach (var kvp in productPrices)
            {
                string name = kvp.Key;
                decimal price = kvp.Value;
                long quantity = productQuantity[name];
                decimal totalPrice = price * quantity;
                Console.WriteLine($"{name} -> {totalPrice:f2}");

            }
        }
    }
}
