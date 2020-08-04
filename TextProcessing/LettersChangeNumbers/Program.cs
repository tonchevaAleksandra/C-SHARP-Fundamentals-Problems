using System;
using System.Linq;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] splited = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            for (int i = 0; i < splited.Length; i++)
            {
                string current = splited[i];
                double currNum = OPerateWithNumber(current);

                sum += currNum;
            }

            Console.WriteLine($"{sum:f2}");
        }

        private static double OPerateWithNumber(string current)
        {
            char first = current.First();
            char last = current.Last();
            string num = current.Substring(1, current.Length - 2);
            double currNum = double.Parse(num);
            if (first >= 65 && first <= 90)
            {
                currNum /= (double)(first) - 64;
            }
            else
            {
                currNum *= (double)(first) - 96;
            }
            if (last >= 65 && last <= 90)
            {
                currNum -= (double)(last) - 64;
            }
            else
            {
                currNum += (double)(last) - 96;
            }

            return currNum;
        }
    }
}
