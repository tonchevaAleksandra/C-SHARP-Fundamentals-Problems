using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();

            string input;
            contests = FillTheContestsAndPass(contests);

            Dictionary<string, Dictionary<string, int>> ranking = new Dictionary<string, Dictionary<string, int>>();

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] cmdArgs = input.Split("=>", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string contest = cmdArgs[0];
                string pass = cmdArgs[1];
                string user = cmdArgs[2];
                int points = int.Parse(cmdArgs[3]);
                if (contests.ContainsKey(contest) && contests[contest] == pass)
                {
                    FillTheUsersResult(ranking, contest, user, points);
                }
            }

            FindTheBestTotalResult(ranking);
            ranking = PrintResults(ranking);

        }

        private static void FillTheUsersResult(Dictionary<string, Dictionary<string, int>> ranking, string contest, string user, int points)
        {
            if (!ranking.ContainsKey(user))
            {
                ranking[user] = new Dictionary<string, int>();

                ranking[user].Add(contest, points);
            }
            else
            {
                if (ranking[user].ContainsKey(contest))
                {
                    if (ranking[user][contest] < points)
                    {
                        ranking[user][contest] = points;
                    }
                }
                else if (!ranking[user].ContainsKey(contest))
                {
                    ranking[user].Add(contest, points);
                }
            }
        }

        private static Dictionary<string, string> FillTheContestsAndPass(Dictionary<string, string> contests)
        {
            string input;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] cmdArgs = input.Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string contest = cmdArgs[0];
                string pass = cmdArgs[1];
                contests[contest] = pass;
            }

            return contests;
        }

        private static Dictionary<string, Dictionary<string, int>> PrintResults(Dictionary<string, Dictionary<string, int>> ranking)
        {
            ranking = ranking.OrderBy(kvp => kvp.Key).ToDictionary(a => a.Key, b => b.Value);
            Console.WriteLine("Ranking: ");
            foreach (var kvp in ranking)
            {
                Console.WriteLine(kvp.Key);
                var dict = kvp.Value.OrderByDescending(a => a.Value).ToDictionary(a => a.Key, b => b.Value);
                foreach (var item in dict)
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }

            return ranking;
        }

        private static void FindTheBestTotalResult(Dictionary<string, Dictionary<string, int>> ranking)
        {
            string bestCandidat = string.Empty;
            int bestPoints = 0;

            foreach (var kvp in ranking)
            {
                int totalPoints = 0;
                foreach (var item in kvp.Value)
                {
                    totalPoints += item.Value;

                }
                if (totalPoints > bestPoints)
                {
                    bestCandidat = kvp.Key;
                    bestPoints = totalPoints;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidat} with total {bestPoints} points.");
        }
    }
}
