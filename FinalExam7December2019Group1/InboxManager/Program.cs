using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace InboxManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> userBook = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] cmdArgs = input.Split("->");
                string command = cmdArgs[0];
                switch (command)
                {
                    case "Add":
                        userBook = AddUsers(userBook, cmdArgs);
                        break;
                    case "Send":
                        userBook = SendEmails(userBook, cmdArgs);
                        break;
                    case "Delete":
                        DeleteUsers(userBook, cmdArgs);
                        break;
                    default:
                        break;
                }
            }

            userBook = Printstatistics(userBook);
        }

        private static Dictionary<string, List<string>> Printstatistics(Dictionary<string, List<string>> userBook)
        {
            userBook = userBook.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            int count = userBook.Keys.Count();
            Console.WriteLine($"Users count: { count}");

            foreach (var kvp in userBook)
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"- {item}");
                }
            }

            return userBook;
        }

        private static void DeleteUsers(Dictionary<string, List<string>> userBook, string[] cmdArgs)
        {
            string user = cmdArgs[1];
            if (userBook.ContainsKey(user))
            {
                userBook.Remove(user);
            }
            else
            {
                Console.WriteLine($"{user} not found!");
            }
        }

        private static Dictionary<string,List<string>> SendEmails(Dictionary<string, List<string>> userBook, string[] cmdArgs)
        {
            string user = cmdArgs[1];
            string email = cmdArgs[2];
            if (userBook.ContainsKey(user))
            {
                userBook[user].Add(email);
            }
            return userBook;
        }

        private static Dictionary<string,List<string>> AddUsers(Dictionary<string, List<string>> userBook, string[] cmdArgs)
        {
            string user = cmdArgs[1];
            if (!userBook.ContainsKey(user))
            {
                userBook.Add(user, new List<string>());
            }
            else
            {
                Console.WriteLine($"{user} is already registered");
            }
            return userBook;
        }
    }
}
