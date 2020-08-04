using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            double firstTime = 0;
            double secondTime = 0;
            firstTime = FindTheTimeOfLeftRacer(numbers, firstTime);
            secondTime = FindTheTimeOfRightRacer(numbers, secondTime);
            string winner = string.Empty;
            double winnersTime = 0;
            CheckWhoWon(firstTime, secondTime, out winner, out winnersTime);

            Console.WriteLine($"The winner is {winner} with total time: {winnersTime}");

        }

        private static void CheckWhoWon(double firstTime, double secondTime, out string winner, out double winnersTime)
        {
            if (firstTime <= secondTime)
            {
                winner = "left";
                winnersTime = firstTime;
            }
            else
            {
                winner = "right";
                winnersTime = secondTime;
            }
        }

        private static double FindTheTimeOfRightRacer(List<double> numbers, double secondTime)
        {
            for (int i = numbers.Count - 1; i > numbers.Count / 2; i--)
            {
                if (numbers[i] == 0)
                {
                    secondTime *= 0.8;
                }
                else
                {
                    secondTime += numbers[i];
                }
            }

            return secondTime;
        }

        private static double FindTheTimeOfLeftRacer(List<double> numbers, double firstTime)
        {
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                if (numbers[i] == 0)
                {
                    firstTime *= 0.8;
                }
                else 
                {
                    firstTime += numbers[i];
                }
            }

            return firstTime;
        }
    }
}
