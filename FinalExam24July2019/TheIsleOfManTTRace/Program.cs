using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace TheIsleOfManTTRace
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\#|\$|\%|\*|\&)(?<name>[A-Za-z]+)\1=(?<length>[0-9]+)!!(?<goehash>(.)+)";
            while (true)
            {
                string code = Console.ReadLine();
                Match match = Regex.Match(code, pattern);
                if(match.Success)
                {
                    string geohash = match.Groups["goehash"].Value;
                    int length = int.Parse(match.Groups["length"].Value);
                    if(geohash.Length==length)
                    {
                        string currentCode = string.Empty;
                        for (int i = 0; i < geohash.Length; i++)
                        {
                            char curr = (char)((int)geohash[i] + length);
                            currentCode+=curr.ToString();
                        }
                        Console.WriteLine($"Coordinates found! {match.Groups["name"].Value} -> {currentCode}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                    continue;
                }
            }
        }
    }
}
