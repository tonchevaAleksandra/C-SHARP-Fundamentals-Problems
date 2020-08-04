using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberArray
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine()
           .Split()
           .Select(int.Parse)
           .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                switch (command)
                {
                    case "Switch":
                        int index = int.Parse(cmdArgs[1]);
                        if (index >= 0 && index < numbers.Count)
                        {
                            SwitchTheSignOfNumber(numbers, index);
                        }
                        else
                        {
                            continue;
                        }
                        break;

                    case "Change":
                        int indexChange = int.Parse(cmdArgs[1]);
                        int value = int.Parse(cmdArgs[2]);
                        if (indexChange >= 0 && indexChange < numbers.Count)
                        {
                            numbers[indexChange] = value;
                        }

                        else
                        {
                            continue;
                        }

                        break;

                    case "Sum":
                        int sumNegative = 0;
                        int sumPositive = 0;
                         
                        int sumAll = numbers.Sum();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < 0)
                            {
                                sumNegative += numbers[i];
                            }
                            else
                            {
                                sumPositive += numbers[i];
                            }
                        }
                        if (cmdArgs[1] == "Negative")
                        {
                            Console.WriteLine(sumNegative);
                        }
                        else if (cmdArgs[1] == "Positive")
                        {
                            Console.WriteLine(sumPositive);
                        }
                        else
                        {
                            Console.WriteLine(sumAll);
                        }
                        break;

                }
            }

            List<int> positiveNums = new List<int>();
            positiveNums=AddPositiveNumsToList(numbers, positiveNums);

            Console.WriteLine(string.Join(" ",positiveNums));

        }

        private static List<int> AddPositiveNumsToList(List<int> numbers, List<int> positiveNums)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 0)
                {
                    positiveNums.Add(numbers[i]);
                }
            }
            return positiveNums;
        }

        private static void SwitchTheSignOfNumber(List<int> numbers, int index)
        {
            if (numbers[index] < 0)
            {
                numbers[index] = Math.Abs(numbers[index]);
            }
            else if (numbers[index] > 0)
            {
                numbers[index] *= -1;
            }
        }
    }
}
