using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingTarget1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> targets = Console.ReadLine()
           .Split()
           .Select(int.Parse)
           .ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                int index = int.Parse(cmdArgs[1]);

                switch (command)
                {
                    case "Shoot":
                        if (index >= 0 && index < targets.Count)
                        {
                            int power = int.Parse(cmdArgs[2]);
                            targets[index] -= power;
                            if (targets[index] <= 0)
                            {
                                targets.RemoveAt(index);
                            }
                        }
                        break;
                    case "Add":
                        if (index >= 0 && index <= targets.Count)
                        {
                            int value = int.Parse(cmdArgs[2]);
                            targets.Insert(index, value);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;
                    case "Strike":
                        if (index >= 0 && index <= targets.Count)
                        {
                            int radius = int.Parse(cmdArgs[2]);
                            if(index+radius+1 >= 0 && index+radius+1 < targets.Count
                                && index-radius>=0 && index-radius<targets.Count)
                            {
                                int count = (index + radius + 1) - (index - radius);
                                targets.RemoveRange(index - radius, count);
                            }
                            else
                            {
                                Console.WriteLine("Strike missed!");
                            }
                        }
                        break;
                    
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|",targets));
        }
    }
}
