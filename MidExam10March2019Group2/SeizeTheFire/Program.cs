using System;
using System.Collections.Generic;
using System.Linq;

namespace SeizeTheFire
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fireCells = Console.ReadLine()
                .Split("#")
                .ToArray();

            int water = int.Parse(Console.ReadLine());
            
            double effort = 0;
            int totalFire = 0;
            List<int> result = new List<int>();

            for (int i = 0; i < fireCells.Length; i++)
            {
                string[] currCell = fireCells[i].Split(" = ");
                int power = int.Parse(currCell[1]);
                if(currCell[0]=="High" && power>=81&& power<=125)
                {
                    if(power>water)
                    {
                        continue;
                    }
                    else
                    {
                        water -= power;
                        totalFire += power;
                        effort += 0.25 * power;
                        result.Add(power);
                    }
                }
                else if(currCell[0] == "Medium" && power >= 51 && power <= 80)
                {
                    if (power > water)
                    {
                        continue;
                    }
                    else
                    {
                        water -= power;
                        totalFire += power;
                        effort += 0.25 * power;
                        result.Add(power);
                    }
                }
                else if (currCell[0] == "Low" && power >= 1 && power <= 50)
                {
                    if (power > water)
                    {
                        continue;
                    }
                    else
                    {
                        water -= power;
                        totalFire += power;
                        effort += 0.25 * power;
                        result.Add(power);
                    }
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("Cells:");
            foreach (var item in result)
            {
                Console.WriteLine($" - {item}");
            }
            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: {result.Sum()}");

        }
    }
}
