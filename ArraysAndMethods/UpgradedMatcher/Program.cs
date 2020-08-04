using System;
using System.Linq;

namespace UpgradedMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine()
                .Split()
                .ToArray();

            long[] quantity= Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();

            decimal[] prices = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToArray();

            string input = string.Empty;

            while ((input=Console.ReadLine())!="done")
            {
                string currProduct;
                long count;
                SplitTheCommandInput(input, out currProduct, out count);
                int i = Array.IndexOf(products, currProduct);
                CheckTheQuantity(products, quantity, prices, count, i);
            }
        }

        private static void SplitTheCommandInput(string input, out string currProduct, out long count)
        {
            string[] cmdArgs = input.Split()
                .ToArray();
            currProduct = cmdArgs[0];
            count = long.Parse(cmdArgs[1]);
        }

        private static void CheckTheQuantity(string[] products, long[] quantity, decimal[] prices, long count, int i)
        {
            if (quantity.Length > i && i >= 0)
            {
                PrintWhenEnoughOrNotQuantity(products, quantity, prices, count, i);
            }
            else
            {
                Console.WriteLine($"We do not have enough {products[i]}");
            }
        }

        private static void PrintWhenEnoughOrNotQuantity(string[] products, long[] quantity, decimal[] prices, long count, int i)
        {
            if (quantity[i] >= count)
            {
                Console.WriteLine($"{products[i]} x {count} costs {count * prices[i]:f2}");
                quantity[i] -= count;
            }
            else
            {
                Console.WriteLine($"We do not have enough {products[i]}");
            }
        }
    }
}
