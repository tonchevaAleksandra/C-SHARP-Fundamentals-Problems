using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();



            while (firstPlayer.Count != 0 && secondPlayer.Count != 0)
            {
                int i = 0;
                if (firstPlayer[i] > secondPlayer[i])
                {
                    firstPlayer.Add(firstPlayer[i]);
                    firstPlayer.Add(secondPlayer[i]);
                    firstPlayer.RemoveAt(i);
                    secondPlayer.RemoveAt(i);

                }
                else if (firstPlayer[i] < secondPlayer[i])
                {

                    secondPlayer.Add(secondPlayer[i]);
                    secondPlayer.Add(firstPlayer[i]);
                    secondPlayer.RemoveAt(i);
                    firstPlayer.RemoveAt(i);

                }
                else
                {
                    firstPlayer.RemoveAt(i);
                    secondPlayer.RemoveAt(i);
                }


            }

            PrintTheWinner(firstPlayer, secondPlayer);

        }

        private static void PrintTheWinner(List<int> firstPlayer, List<int> secondPlayer)
        {
            if (firstPlayer.Count > secondPlayer.Count)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
            }
        }
    }
}