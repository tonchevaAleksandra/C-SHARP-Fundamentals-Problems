using System;
using System.Text.RegularExpressions;

namespace EmojiDetector1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(::|\*\*)(?<emoji>[A-Z][a-z]{2,})\1";
            string text = Console.ReadLine();
            MatchCollection matches = Regex.Matches(text, pattern);
            int threshold = 1;
            string patternDigits = @"[0-9]";
            threshold = FindTheThreshold(text, threshold, patternDigits);
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            foreach (Match match in matches)
            {
                FindCoolOnesEmojis(threshold, match);
            }
        }

        private static int FindTheThreshold(string text, int threshold, string patternDigits)
        {
            MatchCollection digits = Regex.Matches(text, patternDigits);
            foreach (Match digit in digits)
            {
                threshold *= int.Parse(digit.Value);
            }
            Console.WriteLine($"Cool threshold: { threshold}");
            return threshold;
        }

        private static void FindCoolOnesEmojis(int threshold, Match match)
        {
            string emoji = match.Groups["emoji"].Value;
            int coolness = 0;
            foreach (char item in emoji)
            {
                coolness += item;
            }
            if (coolness > threshold)
            {
                Console.WriteLine($"{match.Value}");
            }
        }
    }
}
