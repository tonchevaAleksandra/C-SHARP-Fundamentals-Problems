using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulatorList
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

            while ((input = Console.ReadLine()) != "print")
            {
                string[] cmdArgs = input.Split().ToArray();

                string command = cmdArgs[0];

                numbers = CheckCommand(numbers, cmdArgs, command);
            }

            PrintResult(numbers);
        }

        private static void PrintResult(List<int> numbers)
        {
            Console.Write("[");
            Console.Write(string.Join(", ", numbers));
            Console.Write("]");
        }

        private static List<int> CheckCommand(List<int> numbers, string[] cmdArgs, string command)
        {
            switch (command)
            {
                case "add":
                    int addIndex = int.Parse(cmdArgs[1]);
                    int element = int.Parse(cmdArgs[2]);
                    numbers.Insert(addIndex, element);
                    break;
                case "addMany":
                    int addManyIndex = int.Parse(cmdArgs[1]);
                    AddMannyElementsInRange(numbers, cmdArgs, addManyIndex);
                    break;
                case "contains":
                    int containsElement = int.Parse(cmdArgs[1]);
                    CheckForContainingElement(numbers, containsElement);
                    break;
                case "remove":
                    int removeIndex = int.Parse(cmdArgs[1]);
                    numbers.RemoveAt(removeIndex);
                    break;
                case "shift":
                    int rotations = int.Parse(cmdArgs[1]);
                    ShiftNumbersInList(numbers, rotations);
                    break;
                case "sumPairs":
                    numbers = SumPairs(numbers);
                    break;

            }

            return numbers;
        }

        private static void AddMannyElementsInRange(List<int> numbers, string[] cmdArgs, int addManyIndex)
        {
            List<int> elements = new List<int>();
            for (int i = 2; i < cmdArgs.Length; i++)
            {
                elements.Add(int.Parse(cmdArgs[i]));
            }
            numbers.InsertRange(addManyIndex, elements);
        }

        private static void CheckForContainingElement(List<int> numbers, int containsElement)
        {
            if (numbers.Contains(containsElement))
            {
                int indexContains = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == containsElement)
                    {
                        indexContains = i;
                        Console.WriteLine(indexContains);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("-1");
            }
        }

        private static void ShiftNumbersInList(List<int> numbers, int rotations)
        {
            for (int i = 0; i < rotations; i++)
            {
                int firstElement = numbers[0];
                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }
                numbers[numbers.Count - 1] = firstElement;
            }
        }

        private static List<int> SumPairs(List<int> numbers)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count; i += 2)
            {
                if (i == numbers.Count - 1)
                {
                    result.Add(numbers[i]);
                    break;
                }
                result.Add(numbers[i] + numbers[i + 1]);
            }
            numbers = result.ToList();
            return numbers;
        }
    }
}
