using System;
using System.Collections.Generic;
using System.Linq;

namespace ManipulateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split()
                .ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split().ToArray();
                string command = cmdArgs[0];
                CheckCommand(words, cmdArgs, command);
            }

            Console.WriteLine(string.Join(", ",words));
        }

        private static void CheckCommand(List<string> words, string[] cmdArgs, string command)
        {
            switch (command)
            {
                case "Reverse":
                    words.Reverse();
                    break;
                case "Distinct":

                    Distinct(words);
                    break;
                case "Replace":
                    int index = int.Parse(cmdArgs[1]);
                    string newWord = cmdArgs[2];
                    words.RemoveAt(index);
                    words.Insert(index, newWord);
                    break;
            }
        }

        private static void Distinct(List<string> words)
        {
            for (int j = 0; j < words.Count - 1; j++)
            {
                for (int k = j + 1; k < words.Count; k++)
                {
                    if (words[j] == words[k])
                    {
                        words.RemoveAt(k);
                        k--;
                    }
                }
            }
        }
    }
}
