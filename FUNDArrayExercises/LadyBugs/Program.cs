using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladyBugsIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] field = new int[fieldSize];
            for (int i = 0; i < fieldSize; i++)
            {
                if (ladyBugsIndexes.Contains(i))
                {
                    field[i] = 1;
                }
                else
                {
                    field[i] = 0;
                }
            }


            string[] currentMove = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

            while (currentMove[0] != "end")
            {
                
                int startIndex = int.Parse(currentMove[0]);
                string direction = currentMove[1];
                int flyLength = int.Parse(currentMove[2]);
                if(startIndex<0 || startIndex>field.Length)
                {
                    currentMove = Console.ReadLine()
                    .Split(" ")
                    .ToArray();
                    continue;
                }

                else if(field[startIndex]==0)
                {
                    currentMove = Console.ReadLine()
                    .Split(" ")
                    .ToArray();
                    continue;
                }
                else if(field[startIndex]==1)
                {
                    for (int i = 0; i < field.Length; i++)
                    {


                        if (startIndex <= field.Length - 1 && startIndex >= 0)
                        {
                            if (direction == "right" && field[i + flyLength] == 0 && field[i + flyLength] <= field.Length - 1)
                            {
                                field[i + flyLength] = 1;
                                field[i] = 0;
                            }
                            else if (direction == "left" && field[i - flyLength] == 0 && field[i - flyLength] >= 0)
                            {
                                field[i - flyLength] = 1;
                                field[i] = 0;

                            }


                            else if (direction == "right" && field[i + flyLength] == 1 && field[i + flyLength + 1] <= field.Length - 1)
                            {
                                field[i + flyLength + 1] = 1;
                                field[i] = 0;
                            }
                            else if (direction == "left" && field[i - flyLength] == 1 && field[i - (flyLength + 1)] >= 0)
                            {
                                field[i - (flyLength + 1)] = 1;
                                field[i] = 0;

                            }
                            else
                            {
                                field[i] = 0;
                            }

                        }

                    }

                }



                currentMove = Console.ReadLine()
                    .Split(" ")
                    .ToArray();
            }

            for (int i = 0; i < field.Length; i++)
            {
                Console.WriteLine($"{field[i]} ");
            }


            
        }
    }
}
