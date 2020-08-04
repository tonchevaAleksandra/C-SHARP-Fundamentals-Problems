using System;
using System.Collections.Generic;
using System.Linq;

namespace SnowWhite1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dwarfs = new Dictionary<string, int>();

            string input;

            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] inputArgs = input.Split(new string[] { " <:> " }, StringSplitOptions.None);
                string name = inputArgs[0];
                string color = inputArgs[1];
                string nameColor = name + ":" + color;
                int physics = int.Parse(inputArgs[2]);

                if (!dwarfs.ContainsKey(nameColor))
                {
                    dwarfs.Add(nameColor, physics);
                    continue;
                }
                else
                {
                    if (dwarfs[nameColor] < physics)
                    {
                        dwarfs[nameColor] = physics;
                        continue;
                    }
                }

            }
            

            foreach (var item in dwarfs.OrderByDescending(a => a.Value).ThenByDescending(x => dwarfs.Where(y => y.Key.Split(':')[1] == x.Key.Split(':')[1]).Count()))
            {
                Console.WriteLine($"({item.Key.Split(':')[1]}) {item.Key.Split(':')[0]} <-> {item.Value}");
            }
        }
    }
}
