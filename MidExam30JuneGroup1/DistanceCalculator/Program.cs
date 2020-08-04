using System;

namespace DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsMade = int.Parse(Console.ReadLine());
            double lengthStep = double.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            double totalDistance = 0;

            totalDistance = CalculateTheDistance(stepsMade, lengthStep, totalDistance);

            double percentage = totalDistance / distance ;

            Console.WriteLine($"You travelled { percentage:f2}% of the distance!");
        }

        private static double CalculateTheDistance(int stepsMade, double lengthStep, double totalDistance)
        {
            for (int i = 1; i <= stepsMade; i++)
            {
                if (i % 5 == 0)
                {
                    totalDistance += lengthStep * 0.7;
                }
                else
                {
                    totalDistance += lengthStep;
                }
            }

            return totalDistance;
        }
    }
}
