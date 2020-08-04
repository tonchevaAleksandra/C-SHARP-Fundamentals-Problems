using System;
using System.Linq;

namespace ShootForTheWin1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int countShots = 0;
            string input = Console.ReadLine();
            while (input!="End")
            {
                int index = int.Parse(input);
                if(index>=0 && index<targets.Length && targets[index] != -1)
                {
                    countShots++;
                    for (int i = 0; i < targets.Length; i++)
                    {
                        if(targets[i]>targets[index] && i!=index && targets[i]!=-1)
                        {
                            targets[i] -= targets[index];
                        }
                        else if(targets[i] <= targets[index] && i != index && targets[i] != -1)
                        {
                            targets[i] += targets[index];
                        }
                    }
                    targets[index] = -1;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {countShots} -> {string.Join(" ",targets)}");

        }
    }
}
