using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToList();
            string command = Console.ReadLine();
            while (command!="end")
            {
                string[] commands = new string(command).Split();
                string currCommand = commands[0];
                switch (currCommand)
                {
                    case "Add":
                        int numberAdd = int.Parse(commands[1]);
                        numbers=Add(numbers, numberAdd);
                        break;
                        
                    case "Remove":
                        int numberRemove = int.Parse(commands[1]);
                        numbers = Remove(numbers, numberRemove);
                        break;
                       
                    case "RemoveAt":
                        int indexRemoveAt = int.Parse(commands[1]);
                        numbers = RemoveAt(numbers, indexRemoveAt);
                        break;
                        
                    case "Insert":
                        int numberInsert= int.Parse(commands[1]);
                        int indexInsert= int.Parse(commands[2]);
                        numbers = Insert(numbers, indexInsert,numberInsert);
                        break;                       
                   
                }

                command = Console.ReadLine();

            }

            Console.WriteLine(string.Join(" ", numbers));

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
    }
}
