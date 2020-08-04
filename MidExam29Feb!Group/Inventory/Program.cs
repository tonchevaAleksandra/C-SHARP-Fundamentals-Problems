using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split(", ")
                .ToList();

            string input = string.Empty;

            while ((input=Console.ReadLine())!="Craft!")
            {
                string[] cmdArgs = input.Split(" - ");
                string command = cmdArgs[0];

                if(command=="Collect")
                {
                    string product = cmdArgs[1];
                    if(items.Contains(product))
                    {
                        continue;
                    }
                    else
                    {
                        items.Add(product);
                    }
                }
                else if(command=="Drop")
                {
                    string product = cmdArgs[1];
                    if (items.Contains(product))
                    {
                        items.Remove(product);
                    }
                    else
                    {                      
                        continue;
                    }
                }
                else if(command=="Combine Items")
                {
                    string[] oldAndNewProducts = cmdArgs[1].Split(":");
                    string oldProduct = oldAndNewProducts[0];
                    string newProduct = oldAndNewProducts[1];
                    if(items.Contains(oldProduct))
                    {
                        int index = items.IndexOf(oldProduct);
                        if(index+1<items.Count)
                        {
                            items.Insert(index + 1, newProduct);
                        }
                        else
                        {
                            items.Add(newProduct);
                        }
                    }
                }
                else if(command=="Renew")
                {
                    string product = cmdArgs[1];
                    if(items.Contains(product))
                    {
                        items.Remove(product);
                        items.Add(product);
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine(string.Join(", ",items));
        }
    }
}
