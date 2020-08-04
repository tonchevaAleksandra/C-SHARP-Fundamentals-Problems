using System;
using System.Linq;

namespace LadyBugs1
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] startIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] array = new int[fieldSize];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < startIndexes.Length; j++)
                {
                    if (startIndexes[j] == i)
                    {
                        array[i] = 1;
                        break;
                    }
                    else
                    {
                        array[i] = 0;
                    }

                }

            }

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] movements = command
                     .Split()
                     .ToArray();
                int ladybugIndex = int.Parse(movements[0]);
                string direction = movements[1];
                int flyLength = int.Parse(movements[2]);
                for (int i = 0; i < array.Length; i++)
                {
                    
                    if(ladybugIndex==i && flyLength!=0)
                    {
                        array[i] = 0;
                    }
                    if (direction == "right")
                    {
                        if (i == ladybugIndex + flyLength)
                        {
                            if (array[i] == 0)
                            {
                                array[i] = 1;
                            }
                            else
                            {
                                flyLength *= 2;
                                array[i] = 1;
                                break;
                            }
                        }
                        else
                        {
                            array[i] = array[i];
                        }
                    }

                    else
                    {
                        if (i == ladybugIndex - flyLength)
                        {
                            if (array[i] == 0)
                            {
                                array[i] = 1;
                            }
                            else
                            {
                                flyLength *= 2;
                                array[i] = 1;
                                break;
                            }
                        }
                        else
                        {
                            array[i] = array[i]; ;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            if (command == "end")
            {
                Console.WriteLine(string.Join(" ", array));
            }

        }
    }
}
