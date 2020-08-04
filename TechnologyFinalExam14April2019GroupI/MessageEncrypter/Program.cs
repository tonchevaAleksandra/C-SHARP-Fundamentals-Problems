using System;
using System.Text.RegularExpressions;

namespace MessageEncrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"(\*|@)(?<tag>[A-Z][a-z]{2,})\1: \[(?<first>[A-Za-z]{1})\]\|\[(?<second>[A-Za-z]{1})\]\|\[(?<third>[A-Za-z]{1})\]\|$";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string tag = match.Groups["tag"].Value;
                    char first = char.Parse(match.Groups["first"].Value);
                    char second = char.Parse(match.Groups["second"].Value);
                    char third = char.Parse(match.Groups["third"].Value);

                    Console.WriteLine($"{tag}: {(int)first} {(int)second} {(int)third}");
                    //take all letters and turn them into ASCII numbers

                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }

            }
        }
    }
}
