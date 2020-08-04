using System;
using System.Linq;

namespace LadyBugSanyaSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] initialIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] field = new int[fieldSize];

            for (int i = 0; i < initialIndexes.Length; i++)
            {
                int currIndex = initialIndexes[i];
                if (currIndex >= 0 && currIndex < field.Length)
                {
                    field[currIndex] = 1; 
                }
            }

            string command = String.Empty;

            while ((command=Console.ReadLine()) !="end")
            {
                string[] elements = command.Split();
                int ladyBugIndex = int.Parse(elements[0]);
                string direction = elements[1];
                int flyLegth = int.Parse(elements[2]);

                if(ladyBugIndex<0 || ladyBugIndex>field.Length-1 || field[ladyBugIndex]==0)
                {
                    continue;
                }

                field[ladyBugIndex] = 0;
                if(direction=="right")
                {
                    int landIndex = ladyBugIndex + flyLegth;

                    if(landIndex>field.Length-1)
                    {
                        continue;
                    }
                    if(field[landIndex]==1)
                    {
                        while(field[landIndex]==1)
                        {
                            landIndex += flyLegth;
                            if(landIndex>field.Length-1)
                            {
                                break;
                            }
                        }
                    }
                    if(landIndex>=0 && landIndex<field.Length)
                    {
                        field[landIndex] = 1;
                    }

                    
                }
                else if(direction=="left")
                {
                   int landIndex = ladyBugIndex - flyLegth;

                    if (landIndex<0)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= flyLegth;
                            if (landIndex <0)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >= 0 && landIndex < field.Length )
                    {
                        field[landIndex] = 1;
                    }
                }
            }

            Console.WriteLine(string.Join(" ",field));
        }
    }
}
