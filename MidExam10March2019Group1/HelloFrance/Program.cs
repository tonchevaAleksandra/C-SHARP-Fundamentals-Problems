using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace HelloFrance
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> items = Console.ReadLine()
             .Split("|")
             .ToList();
            double budget = double.Parse(Console.ReadLine());
            List<double> maxPrices = new List<double> { 50.00, 35.00, 20.50 };
            List<string> products = new List<string> { "Clothes", "Shoes", "Accessories" };
            List<double> newPrices = new List<double>();
            double neededSum = 150.00;
            double totalBought = 0;

            for (int i = 0; i < items.Count; i++)
            {
                string[] cmArgs = items[i].Split("->");
                string product = cmArgs[0];
                double price = double.Parse(cmArgs[1]);
                for (int j = 0; j < products.Count; j++)
                {
                    if(product==products[j] && price<=maxPrices[j] && price<=budget)
                    {
                        budget -= price;
                        totalBought += price;
                        newPrices.Add(price*1.4);

                    }
                   
                }

            }

            foreach (var item in newPrices)
            {
                Console.Write($"{item:f2} ");
                
            }
            Console.WriteLine();
            Console.WriteLine($"Profit: {(newPrices.Sum()-totalBought):f2}");
            if (newPrices.Sum()+budget>=neededSum)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}
