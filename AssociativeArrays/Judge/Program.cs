using System;
using System.Collections.Generic;
using System.Linq;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();

            string input;
            while ((input = Console.ReadLine()) != "no more time")
            {
              
                string[] inputArgs = input.Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string user = inputArgs[0];
                string contest = inputArgs[1];
                int points = int.Parse(inputArgs[2]);
                if (!contests.ContainsKey(contest))
                {
                    contests[contest] = new Dictionary<string, int>();
                    contests[contest].Add(user, points);
                }
                else
                {
                    if (contests[contest].ContainsKey(user))
                    {
                        if (points > contests[contest][user])
                        {
                            contests[contest][user] = points;
                        }
                       
                    }
                    else
                    {
                        contests[contest].Add(user, points);
                    }
                }

            }

            Dictionary<string, int> statistics = new Dictionary<string, int>();

            statistics = FillStatistics(contests, statistics);
            contests = contests.ToDictionary(x => x.Key, x => x.Value.OrderByDescending(y => y.Value).ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value));
            PrintContests(contests);
            PrintIndividualStanding(statistics);
        }

        private static void PrintIndividualStanding(Dictionary<string, int> statistics)
        {
            Console.WriteLine("Individual standings:");
            int rank = 1;
            foreach (var kvp in statistics)
            {
                Console.WriteLine($"{rank}. {kvp.Key.Trim()} -> {kvp.Value}");
                rank++;
            }
        }

        private static void PrintContests(Dictionary<string, Dictionary<string, int>> contests)
        {
            
            foreach (var kvp in contests)
            {
                Console.WriteLine($"{kvp.Key.Trim()}: {kvp.Value.Count} participants");
                int position = 1;
                //var current = kvp.Value.OrderByDescending(a => a.Value).ThenBy(a => a.Key).ToDictionary(a => a.Key, b => b.Value);
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"{position}. {item.Key.Trim()} <::> {item.Value}");
                    position++;
                }
            }
        }

        private static Dictionary<string, int> FillStatistics(Dictionary<string, Dictionary<string, int>> contests, Dictionary<string, int> statistics)
        {
            foreach (var kvp in contests)
            {
                foreach (var item in kvp.Value)
                {
                    if (!statistics.ContainsKey(item.Key))
                    {
                        statistics.Add(item.Key, item.Value);
                    }
                    else
                    {
                        statistics[item.Key] += item.Value;
                    }
                }
            }
            statistics = statistics.OrderByDescending(a => a.Value).ThenBy(a => a.Key).ToDictionary(a => a.Key, b => b.Value);
            return statistics;
        }
    }
}
