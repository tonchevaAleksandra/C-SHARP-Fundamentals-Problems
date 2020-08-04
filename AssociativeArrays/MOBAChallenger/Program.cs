using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {


            Dictionary<string, Dictionary<string, int>> pool = new Dictionary<string, Dictionary<string, int>>();

            string input;
            while ((input = Console.ReadLine()) != "Season end")
            {

                if (input.Contains("->"))
                {
                    string[] inputArgs = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    pool = FillThePool(pool, inputArgs);
                }
                else if (input.Contains("vs"))
                {
                    string[] inputArgs = input.Split(" vs ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string firstPlayer = inputArgs[0];
                    string secondPlayer = inputArgs[1];
                    if (pool.ContainsKey(firstPlayer) && pool.ContainsKey(secondPlayer))
                    {
                        pool = TakeTheDuel(pool, firstPlayer, secondPlayer);
                    }

                }
            }

            PrintPlayersByPositionAndSkills(pool);

        }

        private static void PrintPlayersByPositionAndSkills(Dictionary<string, Dictionary<string, int>> pool)
        {
            pool = pool.OrderByDescending(kvp => kvp.Value.Values.Sum()).ThenBy(kvp => kvp.Key).ToDictionary(a => a.Key, a => a.Value);
            foreach (var kvp in pool)
            {
                Console.WriteLine($"{kvp.Key.Trim()}: {kvp.Value.Values.Sum()} skill");
                var currentPlayer = kvp.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(a => a.Key, a => a.Value);
                foreach (var pps in currentPlayer)
                {
                    Console.WriteLine($"- {pps.Key.Trim()} <::> {pps.Value}");
                }
            }


        }

        private static Dictionary<string, Dictionary<string, int>> FillThePool(Dictionary<string, Dictionary<string, int>> pool, string[] inputArgs)
        {
            string player = inputArgs[0];
            string position = inputArgs[1];
            int skill = int.Parse(inputArgs[2]);
            if (!pool.ContainsKey(player))
            {
               
                pool.Add(player, new Dictionary<string, int>());
                pool[player].Add(position, skill);
            }
            else
            {
                if (pool[player].ContainsKey(position) && pool[player][position] < skill)
                {
                    pool[player][position] = skill; 
                }
                else if(!pool[player].ContainsKey(position))
                {
                    pool[player].Add(position, skill);
                }
               

            }

            return pool;
        }

        private static Dictionary<string, Dictionary<string, int>> TakeTheDuel(Dictionary<string, Dictionary<string, int>> pool, string firstPlayer, string secondplayer)
        {
            foreach (var item in pool[firstPlayer])
            {
                if (pool[secondplayer].ContainsKey(item.Key))
                {
                    int totalPoints1 = pool[firstPlayer].Values.Sum();
                    int totalPoints2 = pool[secondplayer].Values.Sum();
                    if (totalPoints1 > totalPoints2)
                    {
                        pool.Remove(secondplayer);
                        break;
                    }
                    else if (totalPoints1 < totalPoints2)
                    {
                        pool.Remove(firstPlayer);
                        break;
                    }
                   
                }
            }

            return pool;
        }
    }
}
