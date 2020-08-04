using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ingredients = Console.ReadLine()
                .Split()
                .ToList();

            int n = int.Parse(Console.ReadLine());

            List<string> usedIngerdients = new List<string>();
            int counter = 0;

            counter = FindTheNeededIngredients(ingredients, n, usedIngerdients, counter);

            Console.WriteLine($"Made pizza with total of {counter} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", usedIngerdients)}.");
        }

        private static int FindTheNeededIngredients(List<string> ingredients, int n, List<string> usedIngerdients, int counter)
        {
            for (int i = 0; i < ingredients.Count; i++)
            {
                if (ingredients[i].Length == n)
                {
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    AddIngredients(ingredients, usedIngerdients, i);
                    counter++;
                    if (counter != 10)
                    {
                        continue;
                    }
                    break;
                }
            }

            return counter;
        }

        private static List<string> AddIngredients(List<string> ingredients, List<string> usedIngerdients, int i)
        {
            usedIngerdients.Add(ingredients[i]);
            return usedIngerdients;
        }
    }
}
