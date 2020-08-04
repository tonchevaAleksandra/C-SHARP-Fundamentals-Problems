using System;
using System.Linq;

namespace KaminoFactory2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command!="Clone them!")
            {
                int[] currentDNA = command
                .Split("!")
                .Select(int.Parse)
                .ToArray();
                int searchedNum = 1;
                int currentCount = 1;
                int maxCount = 1;
                int number = currentDNA[0];

                for (int i = 1; i < currentDNA.Length; i++)
                {
                    int previousNum = currentDNA[i - 1];
                    int currentNum = currentDNA[i];

                    if (previousNum == searchedNum && currentNum == searchedNum)
                    {
                        currentCount++;

                        if (currentCount > maxCount)
                        {
                            maxCount = currentCount;

                        }

                    }

                    else
                    {
                        currentCount = 1;
                    }

                }

                command = Console.ReadLine();
            }
            
        }
    }
}
