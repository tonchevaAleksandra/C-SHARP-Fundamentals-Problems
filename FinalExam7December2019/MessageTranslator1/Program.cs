using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MessageTranslator1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"!(?<command>[A-Z][a-z]{2,})!:\[(?<message>[A-Za-z]{8,})\]";
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);
                if(match.Success)
                {
                    FindNewMessage(match);
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }

        private static void FindNewMessage(Match match)
        {
            string command = match.Groups["command"].Value;
            string message = match.Groups["message"].Value;
            List<int> arr = new List<int>();
            foreach (var item in message)
            {
                arr.Add(item);
            }
            string result = string.Join(" ", arr);
            Console.WriteLine($"{command}: {result}");
        }
    }
}
