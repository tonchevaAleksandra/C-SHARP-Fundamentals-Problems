using System;
using System.Linq;

namespace InventoryMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = ReadProducts();
            long[] quantities = ReadQuantity();
            decimal[] prices = ReadPrices();

            string command = Console.ReadLine();

            while (command != "done")
            {
                int i = Array.IndexOf(products, command);

                PrintOutPuts(products, quantities, prices, i);

                command = Console.ReadLine();
            }

        }

        private static void PrintOutPuts(string[] products, long[] quantities, decimal[] prices, int i)
        {
            Console.WriteLine($"{products[i]} costs: {prices[i]}; Available quantity: {quantities[i]}");
        }

        private static decimal[] ReadPrices()
        {
            return Console.ReadLine()
                            .Split()
                            .Select(decimal.Parse)
                            .ToArray();
        }

        private static long[] ReadQuantity()
        {
            return Console.ReadLine()
                            .Split()
                            .Select(long.Parse)
                            .ToArray();
        }

        private static string[] ReadProducts()
        {
            return Console.ReadLine()
                             .Split()
                             .ToArray();
        }
    }
}
