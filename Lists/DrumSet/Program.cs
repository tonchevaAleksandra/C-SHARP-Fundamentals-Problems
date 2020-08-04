using System;
using System.Collections.Generic;
using System.Linq;

namespace DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());

            List<int> drumSet = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

            List<int> initialQuality = new List<int>();


            List<int> prices = new List<int>();

            AddInitialQualityAndPricesToLists(drumSet, initialQuality, prices);

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);

                savings = HitThePowerToDrumSet(savings, drumSet, initialQuality, prices, hitPower);
            }

            Console.WriteLine(string.Join(" ", initialQuality));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }

        private static double HitThePowerToDrumSet(double savings, List<int> drumSet, List<int> initialQuality, List<int> prices, int hitPower)
        {
            for (int i = 0; i < initialQuality.Count; i++)
            {
                initialQuality[i] -= hitPower;

                if (initialQuality[i] <= 0)
                {
                    CheckIfCanAffordIt(ref savings, drumSet, initialQuality, prices, ref i);
                }
            }

            return savings;
        }

        private static void CheckIfCanAffordIt(ref double savings, List<int> drumSet, List<int> initialQuality, List<int> prices, ref int i)
        {
            if (savings - prices[i] >= 0)
            {
                savings -= prices[i];
                initialQuality[i] = drumSet[i];
            }
            else
            {
                initialQuality.RemoveAt(i);
                drumSet.RemoveAt(i);
                prices.RemoveAt(i);
                i--;
            }
        }

        private static void AddInitialQualityAndPricesToLists(List<int> drumSet, List<int> initialQuality, List<int> prices)
        {
            for (int i = 0; i < drumSet.Count; i++)
            {
                int price = drumSet[i] * 3;
                prices.Add(price);
                initialQuality.Add(drumSet[i]);
            }
        }
    }
}
