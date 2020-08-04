using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList1
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

            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split().ToArray();
                if (commands[0] == "Delete")
                {
                    int element = int.Parse(commands[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {                       
                        numbers.Remove(element);                      
                    }
                }
                else if (commands[0] == "Insert")
                {
                    int element = int.Parse(commands[1]);
                    int position = int.Parse(commands[2]);
                    numbers.Insert(position, element);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
