using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	IP = (IP.Address)message = (A & sample & message) user = (username)

            SortedDictionary<string, Dictionary<string, int>> users = new SortedDictionary<string, Dictionary<string, int>>();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] data = input.Split();
                var ip = data[0].Split('=')[1];
                var user = data[2].Split('=')[1];
                if (!users.ContainsKey(user))
                {
                    users[user] = new Dictionary<string, int>();

                }
                if (!users[user].ContainsKey(ip))
                {
                    users[user].Add(ip, 0);
                }

                users[user][ip]++;
            }

            PrintOutput(users);
        }

        private static void PrintOutput(SortedDictionary<string, Dictionary<string, int>> users)
        {
            foreach (var item in users.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key + ":");
                Console.WriteLine(string.Join(", ", item.Value.Select(x => $"{x.Key} => {x.Value}")) + ".");
            }       
        }
    }
}
