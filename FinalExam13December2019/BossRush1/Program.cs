using System;
using System.Text.RegularExpressions;

namespace BossRush1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\|(?<boss>[A-Z]{4,})\|:\#(?<title>[A-Za-z]+ [A-Za-z]+)\#";
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);
                if(match.Success)
                {
                    string name = match.Groups["boss"].Value;
                    string title = match.Groups["title"].Value;

                    Console.WriteLine($"{name}, The {title}");
                    Console.WriteLine($">> Strength: {name.Length}");
                    Console.WriteLine($">> Armour: {title.Length}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
