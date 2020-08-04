using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> groceries = Console.ReadLine()
                .Split("!")
                .ToList();

            string input = string.Empty;

            while((input=Console.ReadLine())!= "Go Shopping!")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                switch (command)
                {
                    case "Urgent":
                        string urgent = cmdArgs[1];
                        if(!groceries.Contains(urgent))
                        {
                            groceries.Insert(0, urgent);
                        }
                        break;
                    case "Unnecessary":
                        string itemToRemove = cmdArgs[1];
                        if (groceries.Contains(itemToRemove))
                        {
                            groceries.Remove(itemToRemove);
                        }
                        break;
                    case "Correct":
                        string oldItem = cmdArgs[1];
                        string newItem = cmdArgs[2];
                        if(groceries.Contains(oldItem))
                        {
                            int indexOld = groceries.IndexOf(oldItem);
                            groceries[indexOld] = newItem;
                        }
                        break;
                    case "Rearrange":
                        string item = cmdArgs[1];
                        if(groceries.Contains(item))
                        {
                            groceries.Remove(item);
                            groceries.Add(item);
                        }
                        break;
                   
                }
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
