using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();
            bool isWinning = false;
            string command;
            int moves = 0;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] currentArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    isWinning = true;
                    continue;
                }
                int firstIndex = int.Parse(currentArgs[0]);
                int second = int.Parse(currentArgs[1]);
                moves++;
                if (firstIndex >= 0 && firstIndex < elements.Count && second >= 0 && second < elements.Count && firstIndex != second)
                {
                    if (elements[firstIndex].Equals(elements[second]))
                    {
                        string elementMatch = elements[firstIndex];
                        Console.WriteLine($"Congrats! You have found matching elements - {elementMatch}!");

                        if (firstIndex > second)
                        {
                            elements.RemoveAt(second);
                            elements.RemoveAt(firstIndex - 1);
                        }
                        else
                        {
                            elements.RemoveAt(firstIndex);
                            elements.RemoveAt(second - 1);
                        }

                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                        moves--;
                    }
                }
                else
                {
                    
                    string currEl = string.Concat("-", moves.ToString(), "a");
                    string[] currElements = new string[] { currEl, currEl };
                    Console.WriteLine($"Invalid input! Adding additional elements to the board");
                    elements.InsertRange(elements.Count / 2, currElements);
                }
            }

            if (!isWinning)
            {
                Console.WriteLine($"Sorry you lose :(");
                Console.WriteLine(string.Join(" ", elements));
            }
        }
    }
}
