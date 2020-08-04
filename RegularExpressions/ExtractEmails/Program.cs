using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=\s|^)(?<user>[A-Za-z0-9]+[A-Za-z0-9-.,_]*)@(?<host>[A-Za-z][A-Za-z-.]*\.[A-Za-z]+)";
            //string pattern = @"(?<=\s|^)(?<user>[A-Za-z0-9]([-._]?[A-Za-z0-9])*)@(?<host>[A-Za-z](\-?[A-Za-z])*(\.[A-Za-z](\-?[A-Za-z])*)+)";
            string text = Console.ReadLine();
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value);
            }
          
        }
    }
}
