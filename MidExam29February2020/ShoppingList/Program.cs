using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()
                .Split("!")
                .ToList();

            string input = string.Empty;

            while ((input=Console.ReadLine())!="Go Shopping!")
            {
                string[] cmdArgs = input.Split().ToArray();
                string command = cmdArgs[0];

                if (command=="Urgent")
                {
                    string product = cmdArgs[1];
                    if(groceries.Contains(product))
                    {
                        continue;
                    }
                    else
                    {
                        groceries.Insert(0,product);
                    }
                }
                else if(command== "Unnecessary")
                {
                    string product = cmdArgs[1];
                    if(groceries.Contains(product))
                    {
                        groceries.Remove(product);
                    }
                    else
                    {
                        continue;
                    }
                }

                else if(command== "Correct")
                {
                    string oldItem = cmdArgs[1];
                    string newItem = cmdArgs[2];
                    if(groceries.Contains(oldItem))
                    {
                        int index = groceries.IndexOf(oldItem);
                        groceries[index] = newItem;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if(command== "Rearrange")
                {
                    string product = cmdArgs[1];
                    if(groceries.Contains(product))
                    {
                        groceries.Remove(product);
                        groceries.Add(product);
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            if(input=="Go Shopping!")
            {
                Console.WriteLine(string.Join(", ",groceries));
            }
        }
    }
}
