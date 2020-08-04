using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ArrivingInKathmandu
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(?<name>[A-Za-z0-9\!\@\#\$\?]+)=(?<length>[0-9]+)<<(?<goehash>(.)+)$";
            string input;
            while ((input=Console.ReadLine())!="Last note")
            {
                Match match = Regex.Match(input, pattern);
                string namePattern = @"[A-Za-z0-9]";
                if(match.Success)
                {
                    int length = int.Parse(match.Groups["length"].Value);
                    string geohash = match.Groups["goehash"].Value;
                    string name = match.Groups["name"].Value;
                    if (geohash.Length==length)
                    {
                        MatchCollection matches = Regex.Matches(name, namePattern);
                        StringBuilder mountain = new StringBuilder();
                        foreach (Match item in matches)
                        {
                            mountain.Append(item);
                        }
                     
                        Console.WriteLine($"Coordinates found! {mountain.ToString()} -> {geohash}");
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
            }
        }
    }
}
