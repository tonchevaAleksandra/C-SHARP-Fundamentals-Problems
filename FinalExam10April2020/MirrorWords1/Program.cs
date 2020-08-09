using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MirrorWords1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(\#|@)(?<first>[A-Za-z]{3,})\1\1(?<second>[A-Za-z]{3,})\1";
            MatchCollection matches = Regex.Matches(text, pattern);
            if(matches.Count>0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
                List<string> mirrorWords = new List<string>();
                mirrorWords= FindTheMirrorWords(matches, mirrorWords);
                if (mirrorWords.Count > 0)
                {
                    Console.WriteLine("The mirror words are:");
                    Console.WriteLine(string.Join(", ", mirrorWords));
                }
                else
                {
                    Console.WriteLine("No mirror words!");
                }


            }
            else
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
            
        }

        private static List<string> FindTheMirrorWords(MatchCollection matches, List<string> mirrorWords)
        {
            foreach (Match match in matches)
            {
                string first = match.Groups["first"].Value;
                string second = match.Groups["second"].Value;
                char[] scd = second.ToCharArray();
                Array.Reverse(scd);
                string mirror = new string(scd);
                if (first.Equals(mirror))
                {
                    mirrorWords.Add($"{first} <=> {second}");
                }
            }
            return mirrorWords;
        }
    }
}
