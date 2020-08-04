using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {

          

            string winningSymbols = @"(\@{6,}|\${6,}|\^{6,}|\#{6,})";
            Regex reg = new Regex(winningSymbols);
            List<string> tickets = Console.ReadLine()
                .Split(new[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries)
                //.Select(x => x.Trim())
                .ToList();

            foreach (string ticket in tickets)
            {

                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                else
                {
                    var leftMatch = reg.Match(ticket.Substring(0, 10));
                    var rightMatch = reg.Match(ticket.Substring(10));
                    var minLenght = Math.Min(leftMatch.Length, rightMatch.Length);

                    PrintResult(ticket, leftMatch, rightMatch, minLenght);
                }
            }

        }

        private static void PrintResult(string ticket, Match leftMatch, Match rightMatch, int minLenght)
        {
            if (!leftMatch.Success || !rightMatch.Success)
            {
                Console.WriteLine($"ticket \"{ticket}\" - no match");
            }
            else
            {
                var leftPart = leftMatch.Value.Substring(0, minLenght);
                var rightPart = rightMatch.Value.Substring(0, minLenght);
                if (leftPart.Equals(rightPart))
                {
                    if (leftPart.Length == 10)
                    {

                        Console.WriteLine($"ticket \"{ticket}\" - {leftPart.Length}{leftPart.Substring(0, 1)} Jackpot!");


                    }

                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {leftPart.Length}{leftPart.Substring(0, 1)} ");
                    }


                }
            }
        }
    }
}
