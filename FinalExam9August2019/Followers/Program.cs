using System;
using System.Collections.Generic;
using System.Linq;

namespace Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> usernames = new Dictionary<string, List<int>>();

            string input;
            while ((input = Console.ReadLine()) != "Log out")
            {
                string[] cmdArgs = input.Split(": ");
                string command = cmdArgs[0];
                switch (command)
                {
                    case "New follower":
                        usernames = AddFollowers(usernames, cmdArgs);
                        break;
                    case "Like":
                        Like(usernames, cmdArgs);
                        break;
                    case "Comment":
                        usernames = Comment(usernames, cmdArgs);
                        break;
                    case "Blocked":
                        string user = cmdArgs[1];
                        if (usernames.ContainsKey(user))
                        {
                            usernames.Remove(user);
                        }
                        else
                        {
                            Console.WriteLine($"{user} doesn't exist.");
                        }
                        break;
                    default:
                        break;
                }
            }
            usernames = PrintResults(usernames);
        }

        private static Dictionary<string, List<int>> PrintResults(Dictionary<string, List<int>> usernames)
        {
            usernames = usernames.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine($"{usernames.Keys.Count()} followers");
            foreach (var kvp in usernames)
            {
                Console.WriteLine($"{ kvp.Key}: {kvp.Value[0] + kvp.Value[1]}");
            }

            return usernames;
        }

        private static Dictionary<string, List<int>> Comment(Dictionary<string, List<int>> usernames, string[] cmdArgs)
        {
            string user = cmdArgs[1];
            if (!usernames.ContainsKey(user))
            {
                usernames = AddFollowers(usernames, cmdArgs);
            }
            usernames[user][1] += 1;
            return usernames;
        }

        private static Dictionary<string,List<int>> Like(Dictionary<string, List<int>> usernames, string[] cmdArgs)
        {
            string user = cmdArgs[1];
            int count = int.Parse(cmdArgs[2]);
            if (!usernames.ContainsKey(user))
            {
                usernames= AddFollowers(usernames, cmdArgs);

            }
            usernames[user][0] += count;
            return usernames;
        }

        private static Dictionary<string, List<int>> AddFollowers(Dictionary<string, List<int>> usernames, string[] cmdArgs)
        {

            string user = cmdArgs[1];
            if (!usernames.ContainsKey(user))
            {
                List<int> current = new List<int>();
                current.Add(0);
                current.Add(0);
                usernames.Add(user, current);
            }
            return usernames;
        }
    }
}
