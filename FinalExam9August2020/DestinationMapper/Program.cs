using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(=|\/)(?<destination>[A-Z][A-Za-z]{2,})\1";
            MatchCollection matches = Regex.Matches(input, pattern);
            int points = 0;
            List<string> destinations = new List<string>();
            foreach (Match item in matches)
            {
                string current = item.Groups["destination"].Value;
                points += current.Length;
                destinations.Add(current);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
