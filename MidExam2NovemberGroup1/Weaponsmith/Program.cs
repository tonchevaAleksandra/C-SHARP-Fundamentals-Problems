using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Weaponsmith
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> particles = Console.ReadLine()
                .Split("|")
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Done")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                string command1 = cmdArgs[1];

                if (command == "Move")
                {
                    if (command1 == "Left")
                    {
                        int index = int.Parse(cmdArgs[2]);
                        if (index > 0 && index < particles.Count)
                        {
                            string temp = particles[index];
                            particles[index] = particles[index - 1];
                            particles[index - 1] = temp;

                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        int index = int.Parse(cmdArgs[2]);
                        if (index >= 0 && index < particles.Count - 1)
                        {
                            string temp = particles[index];
                            particles[index] = particles[index + 1];
                            particles[index + 1] = temp;

                        }
                        else
                        {
                            continue;
                        }
                    }
                }

                else
                {
                    if(command1 == "Even")
                    {
                        for (int i = 0; i < particles.Count; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.Write($"{particles[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (command1 == "Odd")
                    {
                        for (int i = 0; i < particles.Count; i++)
                        {
                            if (i % 2 != 0)
                            {
                                Console.Write($"{particles[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine($"You crafted {string.Join(null, particles)}!");
        }
    }
}
