using System;
using System.Collections.Generic;
using System.Linq;

namespace TanksCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tanks = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                if (command == "Add")
                {
                    string tankName = cmdArgs[1];
                    if (tanks.Contains(tankName))
                    {
                        Console.WriteLine($"Tank is already bought");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Tank successfully bought");
                        tanks.Add(tankName);
                        continue;
                    }
                }
                else if (command == "Remove")
                {
                    string tankName = cmdArgs[1];
                    if (tanks.Contains(tankName))
                    {
                        Console.WriteLine($"Tank successfully sold");
                        tanks.Remove(tankName);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Tank not found");
                        continue;

                    }
                }
                else if (command == "Remove At")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index < 0 || index > tanks.Count - 1)
                    {
                        Console.WriteLine("Index out of range");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Tank successfully sold");
                        tanks.RemoveAt(index);
                        continue;
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string tankName = cmdArgs[2];
                    if (index >= 0 && index <= tanks.Count - 1)
                    {
                        if (tanks.Contains(tankName))
                        {
                            Console.WriteLine("Tank is already bought");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Tank successfully bought");
                            tanks.Insert(index, tankName);
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                        continue;
                    }
                }

            }

            Console.WriteLine(string.Join(", ", tanks));
        }
    }
}
