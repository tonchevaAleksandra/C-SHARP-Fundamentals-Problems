using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
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

            while ((input=Console.ReadLine())!="end")
            {
                string[] commands = input.Split().ToArray();
                NewMethod(numbers, commands);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void NewMethod(List<int> numbers, string[] commands)
        {
            if (commands[0] == "Delete")
            {
                int element = int.Parse(commands[1]);
                for (int i = 0; i < numbers.Count; i++)
                {
                    //if(numbers[i]==element)
                    //{
                    numbers.Remove(element);
                    //}
                }
            }
            else if (commands[0] == "Insert")
            {
                int element = int.Parse(commands[1]);
                int position = int.Parse(commands[2]);
                numbers.Insert(position, element);
            }
        }
    }
}
