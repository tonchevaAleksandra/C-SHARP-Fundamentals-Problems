using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> dwarfs = new Dictionary<string, Dictionary<string, long>>();


            string input;
            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] cmdArgs = input.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = cmdArgs[0];
                string color = cmdArgs[1];
                long physics = long.Parse(cmdArgs[2]);

                if (!dwarfs.ContainsKey(color))
                {
                    dwarfs[color] = new Dictionary<string, long>();
                    dwarfs[color].Add(name, physics);
                  
                }
                else 
                {
                    if (!dwarfs[color].ContainsKey(name))
                    {
                        dwarfs[color].Add(name, physics);
                      
                    }
                    else if (dwarfs[color].ContainsKey(name) && physics > dwarfs[color][name])
                    {
                        dwarfs[color][name] = physics;
                       
                    }
                
                }
            }

            dwarfs = dwarfs.OrderByDescending(kvp => kvp.Value.Values.Sum()).ToDictionary(a => a.Key, a => a.Value);

            foreach (var kvp in dwarfs)
            {
                var current = kvp.Value.OrderByDescending(x => x.Key.Count()).ToDictionary(a => a.Key, a => a.Value);
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"({kvp.Key.Trim()}) {item.Key.Trim()} <-> {item.Value}");
                }
            }
        }

    }
}
