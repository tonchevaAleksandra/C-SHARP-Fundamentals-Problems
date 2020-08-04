using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> book = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                string[] cmdArgs = input
                    .Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (input.Contains("|"))
                {
                    string side = cmdArgs[0];
                    string user = cmdArgs[1];

                    AddUserToSide(book, side, user);

                }
                else if (input.Contains("->"))
                {
                    string user = cmdArgs[0];
                    string side = cmdArgs[1];
                    MoveUsers(book, user, side);
                }
            }

            PrintOrderedDictionary(book);
        }

        private static void PrintOrderedDictionary(Dictionary<string, List<string>> book)
        {
            Dictionary<string, List<string>> orderedBook = book.Where(kvp => kvp.Value.Count > 0)
                             .OrderByDescending(kvp => kvp.Value.Count)
                             .ThenBy(kvp => kvp.Key)
                             .ToDictionary(a => a.Key, b => b.Value);

            foreach (var svp in orderedBook)
            {
                string currentSide = svp.Key;
                List<string> currentUsers = svp.Value.OrderBy(a => a).ToList();
                Console.WriteLine($"Side: {currentSide}, Members: {currentUsers.Count}");
                foreach (var user in currentUsers)
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }

        private static void MoveUsers(Dictionary<string, List<string>> book, string user, string side)
        {
            foreach (var kvp in book)
            {
                if (kvp.Value.Contains(user))
                {
                    kvp.Value.Remove(user);

                }
               
            }
            if (!book.ContainsKey(side))
            {
                book[side] = new List<string>();
            }

            book[side].Add(user);
            Console.WriteLine($"{user} joins the {side} side!");
        }

        private static void AddUserToSide(Dictionary<string, List<string>> book, string side, string user)
        {
            if (!book.ContainsKey(side))
            {
                book[side] = new List<string>();
            }
            if (!book.Values.Any(l => l.Contains(user)))
            {
                book[side].Add(user);
            }
        }
    }
}
