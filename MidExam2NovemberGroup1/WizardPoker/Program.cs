using System;
using System.Collections.Generic;
using System.Linq;

namespace WizardPoker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine()
                 .Split(":")
                 .ToList();
            List<string> deck = new List<string>();
            string input = string.Empty;
            while ((input=Console.ReadLine())!="Ready")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                if(command=="Add")
                {
                    string cardName = cmdArgs[1];
                    if(cards.Contains(cardName))
                    {
                        
                        deck.Add(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }

                else if(command=="Insert")
                {
                    string cardName = cmdArgs[1];
                    int index = int.Parse(cmdArgs[2]);
                    if(index<0 || index> deck.Count-1 || cards.Contains(cardName)==false)
                    {
                        Console.WriteLine("Error!");
                    }
                    else
                    {
                        cards.Remove(cardName);
                        deck.Insert(index, cardName);
                    }
                }

                else if(command=="Remove")
                {
                    string cardName = cmdArgs[1];
                    if(deck.Contains(cardName))
                    {
                        deck.Remove(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }

                else if(command=="Swap")
                {
                    string cardName1 = cmdArgs[1];
                    string cardName2 = cmdArgs[2];
                    string temp = cardName1;
                    int index1 = deck.IndexOf(cardName1);
                    int index2 = deck.IndexOf(cardName2);
                    deck.Remove(cardName1);
                    deck.Insert(index1, cardName2);
                    deck.RemoveAt(index2);
                    deck.Insert(index2, temp);
                }

                else if(command=="Shuffle" && cmdArgs[1]=="deck")
                {
                    string[] current = deck.ToArray();
                  Array.Reverse(current);
                    deck = current.ToList();
                   
                }
            }

            Console.WriteLine(string.Join(" ", deck));
        }
    }
}
