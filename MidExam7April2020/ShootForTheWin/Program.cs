using System;
using System.Linq;

namespace ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command = string.Empty;
            int countShots = 0;

            while ((command = Console.ReadLine()) != "End")
            {
                int indexTarget = int.Parse(command);

                if (indexTarget >= 0 && indexTarget < targets.Length)
                {
                    if (targets[indexTarget] != -1) 
                    {
                        for (int i = 0; i < targets.Length; i++)
                        {
                            if (targets[i] == -1)
                            {
                                continue;
                            }
                            else if (targets[i] > targets[indexTarget] && i!=indexTarget)
                            {
                                targets[i] -= targets[indexTarget];
                            }
                            else if (targets[i] <= targets[indexTarget] && i != indexTarget)
                            {
                                targets[i] += targets[indexTarget];
                            }
                        }
                        targets[indexTarget] = -1;
                        countShots++;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }
            }

            if (command == "End")
            {
                Console.WriteLine($"Shot targets: {countShots} -> {string.Join(" ", targets)}");
            }
        }
    }
}
