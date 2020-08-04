using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Dictionary<string, int> competition = new Dictionary<string, int>();
            foreach (var participant in participants)
            {
                competition.Add(participant, 0);
            }
            string patternName = @"[A-Za-z]";
            string patternDistance = @"[0-9]";

            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {

                MatchCollection nameArgs = Regex.Matches(input, patternName);
                MatchCollection distanceArgs = Regex.Matches(input, patternDistance);
                StringBuilder sbName = new StringBuilder();
                string name = ExtractName(nameArgs, sbName);
                int distance = ExtractDistance(distanceArgs);
                if (competition.ContainsKey(name))
                {
                    competition[name] += distance;
                }

            }
            competition = PrintResultOfRace(competition);
        }

        private static int ExtractDistance(MatchCollection distanceArgs)
        {
            int distance = 0;
            foreach (Match item in distanceArgs)
            {
                distance += int.Parse(item.Value);
            }

            return distance;
        }

        private static string ExtractName(MatchCollection nameArgs, StringBuilder sbName)
        {
            foreach (Match item in nameArgs)
            {
                sbName.Append(item);
            }
            string name = sbName.ToString();
            return name;
        }

        private static Dictionary<string, int> PrintResultOfRace(Dictionary<string, int> competition)
        {
            competition = competition.OrderByDescending(x => x.Value).Take(3).ToDictionary(a => a.Key, a => a.Value);
            int count = 1;
            foreach (var item in competition)
            {
                string place = count == 1 ? "st" : count == 2 ? "nd" : "rd";
                Console.WriteLine($"{count}{place} place: {item.Key}");
                count++;
            }

            return competition;
        }

    }
}
