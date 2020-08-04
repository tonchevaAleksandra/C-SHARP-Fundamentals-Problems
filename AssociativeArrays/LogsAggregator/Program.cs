using System;
using System.Collections.Generic;
using System.Linq;

namespace LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<User>> users = new Dictionary<string, List<User>>();
            //< IP > < user > < duration >.
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                string ip = data[0];
                string name = data[1];
                int time = int.Parse(data[2]);

                User current = new User(time, ip);

                if (!users.ContainsKey(name))
                {
                    List<User> currentList = new List<User>();
                    currentList.Add(current);
                    users.Add(name, currentList);
                }
                else
                {
                    bool isSameIP = false;
                    isSameIP = CheckTheIPAdress(users, ip, name, current, isSameIP);
                    if (!isSameIP)
                    {
                        users[name].Add(current);
                    }
                }
            }

           PrintResult(users);
        }

        private static bool CheckTheIPAdress(Dictionary<string, List<User>> users, string ip, string name, User current, bool isSameIP)
        {
            foreach (var item in users[name])
            {
                if (item.IP == ip)
                {
                    int currTime = item.Time;
                    current.Time += currTime;
                    users[name].Remove(item);
                    users[name].Add(current);
                    isSameIP = true;
                    break;
                }
            }

            return isSameIP;
        }

        private static void PrintResult(Dictionary<string, List<User>> users)
        {
            users = users.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in users)
            {
                var current = kvp.Value.OrderBy(x => x.IP);
                var totalTime = kvp.Value.Select(x => x.Time).Sum();
                List<string> build = new List<string>();

                foreach (var item in current)
                {
                    build.Add(item.IP);
                }

                Console.WriteLine($"{kvp.Key}: {totalTime} [" + string.Join(", ", build) + "]");

            }       
        }
    }

    class User
    {
        public int Time { get; set; }
        public string IP { get; set; }

        public User(int time, string ip)
        {
            this.Time = time;
            this.IP = ip;
        }
    }
}
