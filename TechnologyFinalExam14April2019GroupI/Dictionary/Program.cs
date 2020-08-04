using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            string[] inputArgs = Console.ReadLine()
                  .Split(" | ");
            FullfillTheDictionary(dict, inputArgs);

            string[] cmdArgs = Console.ReadLine().Split(" | ");
            PrintCurrentWordAndDefinitions(dict, cmdArgs);

            string command = Console.ReadLine();
            PrintResult(ref dict, command);

        }

        private static void PrintResult(ref Dictionary<string, List<string>> dict, string command)
        {
            switch (command)
            {
                case "End":
                    return;
                case "List":
                    dict = dict.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
                    string result = new string(string.Join(" ", dict.Keys));
                    Console.WriteLine(result);
                    break;
                default:
                    break;
            }
        }

        private static void FullfillTheDictionary(Dictionary<string, List<string>> dict, string[] inputArgs)
        {
            foreach (var item in inputArgs)
            {
                string[] currentArgs = item.Split(": ");
                string word = currentArgs[0];
                string definition = currentArgs[1];
                if (!dict.ContainsKey(word))
                {
                    dict.Add(word, new List<string>());
                }
                dict[word].Add(definition);
            }
        }

        private static void PrintCurrentWordAndDefinitions(Dictionary<string, List<string>> dict, string[] cmdArgs)
        {
            foreach (var item in cmdArgs)
            {
                if (dict.ContainsKey(item))
                {
                    Console.WriteLine($"{item}");
                    foreach (var def in dict[item].OrderByDescending(x => x.Length))
                    {
                        Console.WriteLine($" -{def}");
                    }
                }
            }
        }
    }
}
