using System;
using System.Collections.Generic;

namespace Orders1WithClass
{
    class Program
    {
        static void Main(string[] args)
        {

            var products = new Dictionary<string, Product>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "buy")
                {
                    break;
                }

                string[] inputArgs = input.Split();

                string name = inputArgs[0];
                double price = double.Parse(inputArgs[1]);
                int quantity = int.Parse(inputArgs[2]);

                Product product = new Product(name, price, quantity);

                if (!products.ContainsKey(name))
                {
                    products.Add(name, product);
                }
                else
                {
                    products[name].Price = price;
                    products[name].Quantity += quantity;
                }

            }

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Price*item.Value.Quantity:f2}");
            }
        }

        class Product
        {
            public string Name { get; set; }

            public double Price { get; set; }

            public int Quantity { get; set; }

            public Product(string name, double price, int quantity)
            {
                this.Name = name;
                this.Price = price;
                this.Quantity = quantity;
            }
        }
    }
}
