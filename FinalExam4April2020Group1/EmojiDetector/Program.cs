using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(:{2}|\*{2})(?<name>[A-Z][a-z]{2,})\1";
            string input = Console.ReadLine();
            BigInteger threshold = 1;
            string digits = @"[0-9]";
            MatchCollection numbers = Regex.Matches(input, digits);
            threshold = FindTheThreshold(threshold, numbers);
            Console.WriteLine($"Cool threshold: { threshold}");
            MatchCollection emojis = Regex.Matches(input, pattern);
            List<string> coolOnes = new List<string>();

            FindTheCoolOnes(threshold, emojis, coolOnes);

            Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");
            Console.WriteLine(string.Join(Environment.NewLine, coolOnes));

        }

        private static BigInteger FindTheThreshold(BigInteger threshold, MatchCollection numbers)
        {
            foreach (Match match in numbers)
            {
                threshold *= int.Parse(match.Value);
            }

            return threshold;
        }

        private static void FindTheCoolOnes(BigInteger threshold, MatchCollection emojis, List<string> coolOnes)
        {
            foreach (Match match in emojis)
            {
                BigInteger coolness = 0;
                foreach (char item in match.Groups["name"].Value)
                {
                    coolness += (int)item;
                }
                if (coolness >= threshold)
                {
                    coolOnes.Add(match.Value);
                }
            }
        }
    }
}
