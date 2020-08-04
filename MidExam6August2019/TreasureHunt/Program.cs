using System;
using System.Collections.Generic;
using System.Linq;

namespace TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> loot = Console.ReadLine()
                 .Split("|",StringSplitOptions.RemoveEmptyEntries)
                 .ToList();
          
            string input = string.Empty;

            while ((input=Console.ReadLine())!= "Yohoho!")
            {
                string[] cmdArgs = input.Split(' ').ToArray();
                string command = cmdArgs[0];
                if(command=="Loot")
                {
                   
                    for (int i = 1; i < cmdArgs.Length; i++)
                    {
                        if(loot.Contains(cmdArgs[i]))
                        {
                            continue;
                        }
                        else
                        {
                            loot.Insert(0, cmdArgs[i]);
                        }
                    }
                }

                else if(command=="Drop")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if(index>=0 && index<loot.Count)
                    {
                        loot.Add(loot[index]);
                        loot.RemoveAt(index);
                    }

                }
                else if(command=="Steal")
                {
                    int count = int.Parse(cmdArgs[1]);
                    List<string> stolen = new List<string>();

                    
                    if(count>loot.Count)
                    {
                        Console.WriteLine(string.Join(", ", loot));
                       
                        loot.RemoveRange(0,loot.Count);

                    }
                    else
                    {
                        for (int i = loot.Count - count; i < loot.Count; i++)
                        {
                            stolen.Add(loot[i]);
                        }
                        loot.RemoveRange(loot.Count - count, count);
                        Console.WriteLine(string.Join(", ", stolen));
                    }
                   
                }
            }
            if(loot.Count==0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double sum = 0;
                foreach (var item in loot)
                {
                    sum += item.Length;
                }
                double gained = (double)sum/ loot.Count;
                Console.WriteLine($"Average treasure gain: { gained:f2} pirate credits.");
            }
        }
    }
}
