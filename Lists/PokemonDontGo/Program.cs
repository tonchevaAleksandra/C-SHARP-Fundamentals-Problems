using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemonPositions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int sumRemoved = 0;
            while (pokemonPositions.Count!=0)
            {
                int indexToRemove = int.Parse(Console.ReadLine());
                bool isException = false;
                int numberToCompare = 0;
                CheckForExceptionIndexes(pokemonPositions, ref sumRemoved, indexToRemove, ref isException, ref numberToCompare);

                sumRemoved = ManipulatePokemonPositions(pokemonPositions, sumRemoved, indexToRemove, isException, numberToCompare);
            }

            Console.WriteLine(sumRemoved);
        }

        private static void CheckForExceptionIndexes(List<int> pokemonPositions, ref int sumRemoved, int indexToRemove, ref bool isException, ref int numberToCompare)
        {
            if (indexToRemove < 0)
            {
                sumRemoved += pokemonPositions[0];
                numberToCompare = pokemonPositions[0];
                pokemonPositions.RemoveAt(0);
                pokemonPositions.Insert(0, pokemonPositions[pokemonPositions.Count - 1]);
                isException = true;

            }


            else if (indexToRemove > pokemonPositions.Count - 1)
            {
                sumRemoved += pokemonPositions[pokemonPositions.Count - 1];
                numberToCompare = pokemonPositions[pokemonPositions.Count - 1];
                pokemonPositions.RemoveAt(pokemonPositions.Count - 1);
                pokemonPositions.Add(pokemonPositions[0]);
                isException = true;

            }

            if (!isException)
            {
                numberToCompare = pokemonPositions[indexToRemove];
            }
        }

        private static int ManipulatePokemonPositions(List<int> pokemonPositions, int sumRemoved, int indexToRemove, bool isException, int numberToCompare)
        {
            for (int i = 0; i < pokemonPositions.Count; i++)
            {
                if (i == indexToRemove && !isException)
                {
                    sumRemoved += pokemonPositions[indexToRemove];
                    pokemonPositions.RemoveAt(indexToRemove);
                    if (pokemonPositions.Count == 0 || i > pokemonPositions.Count - 1)
                    {
                        break;
                    }
                }

                if (pokemonPositions[i] <= numberToCompare)
                {
                    pokemonPositions[i] += numberToCompare;
                }

                else if (pokemonPositions[i] > numberToCompare)
                {
                    pokemonPositions[i] -= numberToCompare;
                }
            }

            return sumRemoved;
        }
    }
}
