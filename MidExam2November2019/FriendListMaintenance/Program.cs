using System;
using System.Collections.Generic;
using System.Linq;

namespace FriendListMaintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(", ")
                .ToList();

            string input = string.Empty;
            int blackListCoun = 0;
            int lostCount = 0;

            while ((input=Console.ReadLine())!="Report")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                bool isBlackListed = false;
                bool isLost = false;
                if(command=="Blacklist")
                {
                    string currName = cmdArgs[1];
                    if(names.Contains(currName))
                    {

                        Console.WriteLine($"{currName} was blacklisted.");
                        int index = names.IndexOf(currName);
                        names.Remove(currName);
                        names.Insert(index, "Blacklisted");
                        blackListCoun++;
                    }
                    else
                    {
                        Console.WriteLine($"{currName} was not found.");
                    }
                }
                else if(command=="Error")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if(names[index]!="Blacklisted" && names[index]!="Lost")
                    {
                        Console.WriteLine($"{names[index]} was lost due to an error.");
                        lostCount++;
                        names[index] = "Lost";
                    }
                    else
                    {
                        continue;
                    }
                }
                else if(command=="Change")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string newName = cmdArgs[2];
                    if(index>=0 && index<names.Count)
                    {
                        Console.WriteLine($"{names[index]} changed his username to {newName}.");
                        names[index] = newName;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine($"Blacklisted names: {blackListCoun}");
            Console.WriteLine($"Lost names: {lostCount}");
            Console.WriteLine(string.Join(" ",names));
        }
    }
}
