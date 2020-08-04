using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;

            while ((input=Console.ReadLine())!="End")
            {
                string[] cmdArgs = input.Split().ToArray();
                string command = cmdArgs[0];

                if(command=="Shoot")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int power = int.Parse(cmdArgs[2]);
                    if(index>=0 && index<targets.Count)
                    {
                        targets[index] -= power;
                        if(targets[index]<=0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else if(command=="Add")
                {
                    int addIndex = int.Parse(cmdArgs[1]);
                    int value = int.Parse(cmdArgs[2]);
                    if(addIndex >= 0 && addIndex < targets.Count)
                    {
                        targets.Insert(addIndex, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if(command=="Strike")
                {
                    int strikeIndex = int.Parse(cmdArgs[1]);
                    int strikeRadius = int.Parse(cmdArgs[2]);
                    if(strikeRadius+strikeIndex<targets.Count && strikeIndex-strikeRadius>=0)
                    {
                        int startIndex = strikeIndex - strikeRadius;
                        int count = (strikeRadius + strikeIndex+1) - startIndex;
                        targets.RemoveRange(startIndex, count);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                        continue;
                    }
                }
            }

            Console.WriteLine(string.Join("|",targets));
        }
    }
}
