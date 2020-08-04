using System;
using System.Linq;

namespace ArcheryTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] field = Console.ReadLine()
                .Split("|")
                .Select(int.Parse)
                .ToArray();

            string input = string.Empty;
            int points = 0;

            while ((input=Console.ReadLine())!="Game over")
            {
                string[] cmdArgs = input.Split("@");
                string command = cmdArgs[0];
                if (command == "Shoot Left")
                {
                    int leftIndex = int.Parse(cmdArgs[1]);
                    int length = int.Parse(cmdArgs[2]);
                    if (leftIndex>=0 && leftIndex<field.Length)
                    {
                        while (length != 0)
                        {

                            leftIndex--;
                            length--;
                            if (leftIndex < 0)
                            {
                                leftIndex = field.Length - 1;
                            }

                        }
                        if (field[leftIndex] >= 5)
                        {
                            field[leftIndex] -= 5;
                            points += 5;
                        }
                        else
                        {

                            points += field[leftIndex];
                            field[leftIndex] = 0;
                        } 
                    }

                }
                else if (command == "Shoot Right")
                {
                    int rightIndex = int.Parse(cmdArgs[1]);
                    int length = int.Parse(cmdArgs[2]);

                    if (rightIndex>=0 && rightIndex<field.Length)
                    {
                        while (length != 0)
                        {

                            rightIndex++;
                            length--;
                            if (rightIndex > field.Length - 1)
                            {
                                rightIndex = 0;
                            }

                        }
                        if (field[rightIndex] >= 5)
                        {
                            field[rightIndex] -= 5;
                            points += 5;
                        }
                        else
                        {

                            points += field[rightIndex];
                            field[rightIndex] = 0;
                        } 
                    }
                }
                else if (command == "Reverse")
                {
                    Array.Reverse(field);
                }
            }

            Console.WriteLine(string.Join(" - ",field));
            Console.WriteLine($"Iskren finished the archery tournament with {points} points!");
        }
    }
}
