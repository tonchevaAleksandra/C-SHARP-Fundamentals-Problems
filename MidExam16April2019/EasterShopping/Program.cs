using System;
using System.Collections.Generic;
using System.Linq;

namespace EasterShopping
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> shops = Console.ReadLine()
            .Split()
            .ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                string command = cmdArgs[0];
                if (command == "Include")
                {
                    string shop = cmdArgs[1];
                    shops.Add(shop);
                }
                else if (command == "Visit")
                {
                    if (cmdArgs[1] == "first")
                    {
                        int count = int.Parse(cmdArgs[2]);
                        if (count > shops.Count)
                        {
                            continue;
                        }
                        else
                        {
                            shops.RemoveRange(0, count);
                        }
                    }
                    else
                    {
                        int count = int.Parse(cmdArgs[2]);
                        if (count > shops.Count)
                        {
                            continue;
                        }
                        else
                        {
                            shops.RemoveRange(shops.Count - count, count);
                        }
                    }
                }
                else if (command == "Prefer")
                {
                    int index1 = int.Parse(cmdArgs[1]);
                    int index2 = int.Parse(cmdArgs[2]);
                    if (index1 >= 0 && index1 < shops.Count && index2 >= 0 && index2 < shops.Count)
                    {
                        string temp = shops[index1];
                        shops[index1] = shops[index2];
                        shops[index2] = temp;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Place")
                {
                    string shop = cmdArgs[1];
                    int index = int.Parse(cmdArgs[2]);
                    if (index >= 0 && index < shops.Count)
                    { 
                        if(index==shops.Count-1)
                        {
                            shops.Add(shop);
                        }
                        else
                        {
                            shops.Insert(index + 1, shop);
                        }
                    }
                }
            }

            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ", shops));
        }
    }
}
