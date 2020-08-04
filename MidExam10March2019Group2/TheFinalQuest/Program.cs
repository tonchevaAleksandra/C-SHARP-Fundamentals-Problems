using System;
using System.Collections.Generic;
using System.Linq;

namespace TheFinalQuest
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> words = Console.ReadLine()
             .Split()
             .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                if (command == "Delete")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int newIndex = index + 1;
                    if (newIndex >= 0 && newIndex < words.Count )
                    {
                        words.RemoveAt(newIndex);
                    }

                    else
                    {
                        continue;
                    }
                }
                else if (command == "Swap")
                {
                    string word1 = cmdArgs[1];
                    string word2 = cmdArgs[2];
                    if (words.Contains(word1) && words.Contains(word2))
                    {
                       
                        int index1 = words.IndexOf(word1);
                        int index2 = words.IndexOf(word2);
                        words[index1] = word2;
                        words[index2] = word1;
                    }
                    else
                    {
                        continue;
                    }
                }

                else if (command == "Put")
                {
                    string word = cmdArgs[1];
                    int index = int.Parse(cmdArgs[2]);
                    int newIndex = index - 1;
                    if (newIndex >= 0 && newIndex <= words.Count)
                    {
                        words.Insert(newIndex, word);
                    }
                    
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Sort")
                {
                    words.Sort();
                    words.Reverse();
                }
                else if (command == "Replace")
                {
                    string word1 = cmdArgs[1];
                    string word2 = cmdArgs[2];
                    if (words.Contains(word2))
                    {
                        int index2 = words.IndexOf(word2);
                        words[index2] = word1;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", words));
        }
    }
}
