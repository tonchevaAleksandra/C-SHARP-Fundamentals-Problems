using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLenght = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] dna = new int[dnaLenght];
            int lenght = 0;
            int index = 0;
            int sum = 0;
            int currRow = 0;
            int row = 0;

            while (input!="Clone them!")
            {
                int[] currentDNA = input.Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                currRow++;

                int currentSum = 0;
                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i]==1)
                    {
                        currentSum++;
                    }
                }

                int currentLenght = 0;
                int currentIndex = 0;

                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if(currentDNA[i]==1)
                    {
                        currentLenght++;

                        if(currentLenght==1)
                        {
                            currentIndex = 1;
                        }
                        if (currentLenght > lenght || currentLenght ==lenght && (currentIndex<index || currentSum>sum))
                        {
                            lenght = currentLenght;
                            index = currentIndex;
                            row = currRow;
                            dna = currentDNA;
                            sum = currentSum;

                        }
                    }

                    else
                    {
                        currentIndex = 0;
                        currentLenght = 0;
                    }
                }

                input = Console.ReadLine();
            }

            if(row==0)
            {
                row = 1;
            }

            Console.WriteLine($"Best DNA sample {row} with {sum}.");
            Console.WriteLine(string.Join(" ", dna));
        }
    }
}
