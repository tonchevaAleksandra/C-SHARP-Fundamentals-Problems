using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;

namespace MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            //Dictionary<string, string> pairs = new Dictionary<string, string>();
            string pattern = @"([#|@])(?<word>[A-Za-z]{3,})\1\1(?<word2>[A-Za-z]{3,})\1";
            MatchCollection matches = Regex.Matches(text, pattern);
            int count = matches.Count;
            bool founded = false;
            List<string> result = new List<string>();
            if (count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{count} word pairs found!");
                founded = FindMatches(matches, founded, result);
            }

            PrintResult(founded, result);
        }

        private static bool FindMatches(MatchCollection matches, bool founded, List<string> result)
        {
            foreach (Match match in matches)
            {
                string firstWord = match.Groups["word"].Value;
                string scd = match.Groups["word2"].Value;
                char[] reversed = scd.ToCharArray();
                Array.Reverse(reversed);
                string second = new string(reversed);
                if (firstWord.Equals(second))
                {
                    result.Add($"{firstWord} <=> {scd}");
                    founded = true;
                }
            }

            return founded;
        }

        private static void PrintResult(bool founded, List<string> result)
        {
            if (!founded)
            {
                Console.WriteLine("No mirror words!");
                ;
            }
            else
            {

                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", result));
            }
        }
    }
}
