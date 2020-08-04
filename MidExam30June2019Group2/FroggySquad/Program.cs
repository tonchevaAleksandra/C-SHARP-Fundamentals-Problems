using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FroggySquad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frogs = Console.ReadLine()
                .Split()
                .ToList();

            while (true)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split()
                    .ToArray();

                string command = cmdArgs[0];

                if (command == "Join")
                { 
                    string name = cmdArgs[1];
                    frogs.Add(name);
                }

                else if(command== "Jump")
                {
                    string name = cmdArgs[1];
                    int index = int.Parse(cmdArgs[2]);
                    if(index>=0 && index<frogs.Count)
                    {
                        frogs.Insert(index, name);
                    }
                    else
                    {
                        continue;
                    }
                }    
                   
                 else if(command=="Dive")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index >= 0 && index < frogs.Count)
                    {
                        frogs.RemoveAt(index);
                    }
                    else
                    {
                        continue;
                    }
                }

               else if(command=="First")
                {
                    int count = int.Parse(cmdArgs[1]);
                    if(count>frogs.Count)
                    {
                        count = frogs.Count;
                    }
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write(frogs[i]+" ");
                    }
                    Console.WriteLine();
                }

                else if (command == "Last")
                {
                    int count = int.Parse(cmdArgs[1]);
                    if (count > frogs.Count)
                    {
                        count = frogs.Count;
                    }
                    for (int i = frogs.Count-count; i < frogs.Count; i++)
                    {
                        Console.Write(frogs[i] + " ");
                    }
                    Console.WriteLine();
                }
                else if(command=="Print")
                {
                    switch (cmdArgs[1])
                    {
                        case "Normal":
                            Console.WriteLine($"Frogs: {string.Join(" ", frogs)}");
                            return;
                        case "Reversed":
                            frogs.Reverse();
                            Console.WriteLine($"Frogs: {string.Join(" ", frogs)}");
                            return;
                    }
                }
            }
        }
    }
}
