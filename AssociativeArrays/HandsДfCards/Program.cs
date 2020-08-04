using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> decks = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "JOKER")
            {
                string[] inputArgs = input.Split(": ");
                string name = inputArgs[0];

                List<string> cards = FillTheCards(inputArgs);

                if (!decks.ContainsKey(name))
                {
                    decks.Add(name, cards.ToList());
                    continue;
                }
                foreach (var kvp in cards)
                {
                    if (decks[name].Contains(kvp))
                    {
                        continue;
                    }
                    else
                    {
                        decks[name].Add(kvp);
                    }
                }
            }

            Dictionary<string, int> players = new Dictionary<string, int>();

            players = FindTheResult(decks, players);

            foreach (var kvp in players)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

        }

        private static List<string> FillTheCards(string[] inputArgs)
        {
            List<string> list = inputArgs[1].Split(", ").ToList();
            List<string> cards = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                if (!cards.Contains(list[i]))
                {
                    cards.Add(list[i]);
                }
            }

            return cards;
        }

        private static Dictionary<string, int> FindTheResult(Dictionary<string, List<string>> decks, Dictionary<string, int> players)
        {
            foreach (var kvp in decks)
            {
                int power = 0;
                int type = 0;
                int value = 0;
                foreach (var item in kvp.Value)
                {
                    char[] curr = item.ToArray();
                    int indexType = 0;
                    ExtractPower(ref power, curr, ref indexType);
                    type = ExtractTypeCard(ref type, curr, indexType);
                    value += (power * type);
                }
                players.Add(kvp.Key, value);
            }
            return players;
        }

        private static int ExtractTypeCard(ref int type, char[] curr, int indexType)
        {
            switch (curr[indexType])
            {
                case 'S':
                    type = 4;
                    break;
                case 'H':
                    type = 3;
                    break;
                case 'D':
                    type = 2;
                    break;
                case 'C':
                    type = 1;
                    break;

            }

            return type;
        }

        private static void ExtractPower(ref int power, char[] curr, ref int indexType)
        {

            if (curr.Length == 3)
            {
                power = 10;
                indexType = 2;
            }
            else
            {
                indexType = 1;
                if (char.IsDigit(curr[0]))
                {
                    power = int.Parse(curr[0].ToString());
                }
                else
                {
                    switch (curr[0])
                    {
                        case 'J':
                            power = 11;
                            break;
                        case 'Q':
                            power = 12;
                            break;
                        case 'K':
                            power = 13;
                            break;
                        case 'A':
                            power = 14;
                            break;

                    }
                }
            }
        }
    }
}
