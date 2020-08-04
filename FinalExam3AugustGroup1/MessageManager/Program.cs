using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace MessageManager
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            Dictionary<string, int> sendMessages = new Dictionary<string, int>();
            Dictionary<string, int> receivedMessages = new Dictionary<string, int>();
            string input;
            while ((input=Console.ReadLine())!="Statistics")
            {
                string[] cmdArgs = input.Split("=");
                string command = cmdArgs[0];
                switch (command)
                {
                    case "Add":
                        Add(sendMessages, receivedMessages, cmdArgs);
                        break;
                    case "Message":
                        Message(capacity, sendMessages, receivedMessages, cmdArgs);
                        break;
                    case "Empty":
                        Empty(sendMessages, receivedMessages, cmdArgs);
                        break;
                    default:
                        break;
                }
            }

            receivedMessages = receivedMessages.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine($"Users count: { receivedMessages.Keys.Count()}");

            foreach (var kvp in receivedMessages)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value+sendMessages[kvp.Key]}");
            }
        }

        private static void Empty(Dictionary<string, int> sendMessages, Dictionary<string, int> receivedMessages, string[] cmdArgs)
        {
            string user = cmdArgs[1];
            if (user == "All")
            {
                sendMessages.Clear();
                receivedMessages.Clear();
            }
            else if (sendMessages.ContainsKey(user))
            {
                sendMessages.Remove(user);
                receivedMessages.Remove(user);
            }
        }

        private static void Message(int capacity, Dictionary<string, int> sendMessages, Dictionary<string, int> receivedMessages, string[] cmdArgs)
        {
            string sender = cmdArgs[1];
            string receiver = cmdArgs[2];
            if (sendMessages.ContainsKey(sender) && sendMessages.ContainsKey(receiver))
            {
                sendMessages[sender] += 1;
                if ((sendMessages[sender])+(receivedMessages[sender]) >= capacity)
                {
                    Console.WriteLine($"{sender} reached the capacity!");
                    sendMessages.Remove(sender);
                    receivedMessages.Remove(sender);
                }
                receivedMessages[receiver] += 1;
                if (receivedMessages[receiver]+sendMessages[receiver] >= capacity)
                {
                    Console.WriteLine($"{receiver} reached the capacity!");
                    sendMessages.Remove(receiver);
                    receivedMessages.Remove(receiver);
                }
            }
        }

        private static void Add(Dictionary<string, int> sendMessages, Dictionary<string, int> receivedMessages, string[] cmdArgs)
        {
            string user = cmdArgs[1];
            int send = int.Parse(cmdArgs[2]);
            int received = int.Parse(cmdArgs[3]);
            if (!sendMessages.ContainsKey(user))
            {
                sendMessages.Add(user, send);
                receivedMessages.Add(user, received);
            }
        }
    }
}
