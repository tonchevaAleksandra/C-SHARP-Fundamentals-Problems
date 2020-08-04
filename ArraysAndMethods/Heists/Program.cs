using System;
using System.Linq;

namespace Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] prices = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();

            long priceJewels = prices[0];
            long priceGold = prices[1];

            string input = string.Empty;
            long totalEarning = 0;
            long totalExpenses = 0;

            while ((input = Console.ReadLine()) != "Jail Time")
            {
                string[] cmdArgs = input.Split().ToArray();
                string loot = cmdArgs[0];
                long expenses = long.Parse(cmdArgs[1]);
                totalExpenses += expenses;
                for (int i = 0; i < loot.Length; i++)
                {
                    char current = loot[i];
                    totalEarning = CheckForJewelsOrGold(priceJewels, priceGold, totalEarning, current);
                }
                
            }
            
            PrintTheOutput(totalEarning, totalExpenses);
        }

        private static void PrintTheOutput(long totalEarning, long totalExpenses)
        {
            if (totalEarning >= totalExpenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarning-totalExpenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {totalExpenses-totalEarning}.");
            }
        }

        private static long CheckForJewelsOrGold(long priceJewels, long priceGold, long totalEarning, char current)
        {
            if (current == '%')
            {
                totalEarning += priceJewels;
            }
           if (current == '$')
            {
                totalEarning += priceGold;
            }

            return totalEarning;
        }
    }
}
