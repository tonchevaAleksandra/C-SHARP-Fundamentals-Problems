using System;
using System.Collections.Generic;
using System.Linq;

namespace MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> first, second;
            ReadListsOfNumbers(out first, out second);
            List<double> result = new List<double>();
            List<double> remainingElements = new List<double>();
            int count = Math.Min(first.Count, second.Count);
            int counter = 0;
            MixNumbersFromTwoListsInOneResult(first, second, result, counter);

            FindTheRemainingElements(first, second, remainingElements);

            double start = Math.Min(remainingElements[0], remainingElements[1]);
            double end = Math.Max(remainingElements[0], remainingElements[1]);

            List<double> resultAfterCompare = new List<double>();
            FulfillTheConditionBetweenTwoNums(result, start, end, resultAfterCompare);

            resultAfterCompare.Sort();

            Console.WriteLine(string.Join(" ", resultAfterCompare));

        }

        private static void FulfillTheConditionBetweenTwoNums(List<double> result, double start, double end, List<double> resultAfterCompare)
        {
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] > start && result[i] < end)
                {
                    resultAfterCompare.Add(result[i]);
                }
            }
        }

        private static void FindTheRemainingElements(List<double> first, List<double> second, List<double> remainingElements)
        {
            if (first.Count.CompareTo(second.Count) > 0)
            {
                remainingElements.Add(first[first.Count - 2]);
                remainingElements.Add(first[first.Count - 1]);
            }
            else
            {
                remainingElements.Add(second[second.Count - 2]);
                remainingElements.Add(second[second.Count - 1]);
            }
        }

        private static void MixNumbersFromTwoListsInOneResult(List<double> first, List<double> second, List<double> result, int counter)
        {
            while (first.Count != 0 && second.Count != 0)
            {
                result.Add(first[counter]);
                result.Add(second[second.Count - counter - 1]);
                first.Remove(first[counter]);
                second.Remove(second[second.Count - counter - 1]);
            }
        }

        private static void ReadListsOfNumbers(out List<double> first, out List<double> second)
        {
            first = Console.ReadLine()
                            .Split()
                            .Select(double.Parse)
                            .ToList();
            second = Console.ReadLine()
.Split()
.Select(double.Parse)
.ToList();
        }
    }
}
