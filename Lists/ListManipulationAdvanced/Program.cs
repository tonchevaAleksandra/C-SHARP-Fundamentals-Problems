using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> numbersCopy = numbers;
            while (true)
            {
                string line = Console.ReadLine();
                string[] command = line.Split();
                if (line == "end")
                {
                    if (numbers!=numbersCopy)
                    {
                        Console.WriteLine(string.Join(" ",numbers));
                    }
                    return;
                }
                
                switch (command[0])
                {
                    case "Add":
                        int numberAdd = int.Parse(command[1]);
                        numbers = Add(numbers, numberAdd);
                        break;

                    case "Remove":
                        int numberRemove = int.Parse(command[1]);
                        numbers = Remove(numbers, numberRemove);
                        break;

                    case "RemoveAt":
                        int indexRemoveAt = int.Parse(command[1]);
                        numbers = RemoveAt(numbers, indexRemoveAt);
                        break;

                    case "Insert":
                        int numberInsert = int.Parse(command[1]);
                        int indexInsert = int.Parse(command[2]);
                        numbers = Insert(numbers, indexInsert, numberInsert);
                        break;

                    case "Contains":
                        int containsNum = int.Parse(command[1]);
                        Contains(numbers, containsNum);
                        break;
                    case "PrintEven":
                        PrintEvenNumbers(numbers);
                        break;
                    case "PrintOdd":
                        PrintOddNumbers(numbers);
                        break;
                    case "GetSum":
                        int sum = numbers.Sum();
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        FilterNumbersByOperator(numbers, command);
                        break;

                }
            }

            
            
        }

        static List<int> RemoveAt(List<int> numbers, int indexRemoveAt)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                result.Add(numbers[i]);
            }
            result.RemoveAt(indexRemoveAt);
            return result;
        }

        static List<int> Insert(List<int> numbers, int indexInsert, int numberInsert)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                result.Add(numbers[i]);
            }
            result.Insert(indexInsert, numberInsert);
            return result;

        }
        static List<int> Remove(List<int> numbers, int numberRemove)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                result.Add(numbers[i]);
            }
            result.Remove(numberRemove);
            return result;
        }
        static List<int> Add(List<int> numbers, int numberAdd)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                result.Add(numbers[i]);
            }
            result.Add(numberAdd);
            return result;
        }

        private static void FilterNumbersByOperator(List<int> numbers,string[] command)
        {
            string operators = command[1];
            int filterNum = int.Parse(command[2]);
            List<int> result = new List<int>();
            switch (operators)
            {
                case ">":
                    FilterByBiggerThan(numbers, filterNum, result);
                    break;
                case ">=":
                    FilterByBiggerOrEqual(numbers, filterNum, result);
                    break;
                case "<":
                    FilterBySmallerThan(numbers, filterNum, result);
                    break;
                case "<=":
                    FilterBySmallerOrEqual(numbers, filterNum, result);
                    break;
            }
        }

        private static void FilterBySmallerOrEqual(List<int> numbers, int filterNum, List<int> result)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= filterNum)
                {
                    result.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }

        private static void FilterBySmallerThan(List<int> numbers, int filterNum, List<int> result)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < filterNum)
                {
                    result.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }

        private static void FilterByBiggerOrEqual(List<int> numbers, int filterNum, List<int> result)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= filterNum)
                {
                    result.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }

        private static void FilterByBiggerThan(List<int> numbers, int filterNum, List<int> result)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > filterNum)
                {
                    result.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }

        private static void PrintOddNumbers(List<int> numbers)
        {
            List<int> resultOdd = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    resultOdd.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", resultOdd));
        }

        private static void PrintEvenNumbers(List<int> numbers)
        {
            List<int> resultEven = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    resultEven.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", resultEven));
        }

        private static void Contains(List<int> numbers, int containsNum)
        {
            bool IsContains = numbers.Contains(containsNum);
            if (IsContains)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
        
    }
}
