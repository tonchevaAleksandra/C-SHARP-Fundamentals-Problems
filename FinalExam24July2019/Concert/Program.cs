using System;
using System.Collections.Generic;
using System.Linq;

namespace Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> bandMembers = new Dictionary<string, List<string>>();
            Dictionary<string, int> bandTime = new Dictionary<string, int>();
            string input;
            while ((input = Console.ReadLine()) != "start of concert")
            {
                string[] cmdArgs = input.Split("; ");
                string command = cmdArgs[0];

                switch (command)
                {
                    case "Add":
                        Add(bandMembers, bandTime, cmdArgs);
                        break;
                    case "Play":
                        Play(bandMembers, bandTime, cmdArgs);
                        break;
                    default:
                        break;
                }
            }
            bandTime = PrintResult(bandMembers, bandTime);

        }

        private static Dictionary<string, int> PrintResult(Dictionary<string, List<string>> bandMembers, Dictionary<string, int> bandTime)
        {
            bandTime = bandTime.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);


            Console.WriteLine($"Total time: {bandTime.Values.Sum()}");
            foreach (var kvp in bandTime)
            {
                Console.WriteLine($"{ kvp.Key} -> { kvp.Value}");
            }
            string bandname = Console.ReadLine();
            Console.WriteLine(bandname);
            foreach (var item in bandMembers[bandname])
            {
                Console.WriteLine($"=> {item}");
            }

            return bandTime;
        }

        private static void Play(Dictionary<string, List<string>> bandMembers, Dictionary<string, int> bandTime, string[] cmdArgs)
        {
            string bandName = cmdArgs[1];
            int time = int.Parse(cmdArgs[2]);
            if (!bandTime.ContainsKey(bandName))
            {
                bandTime.Add(bandName, 0);
                bandMembers.Add(bandName, new List<string>());
            }
            bandTime[bandName] += time;
        }

        private static void Add(Dictionary<string, List<string>> bandMembers, Dictionary<string, int> bandTime,string[] cmdArgs)
        {
            string name = cmdArgs[1];
            string[] members = cmdArgs[2].Split(", ");
            if (!bandMembers.ContainsKey(name))
            {
                bandMembers.Add(name, new List<string>());
                bandTime.Add(name, 0);
                for (int i = 0; i < members.Length; i++)
                {
                    string currentMember = members[i];
                    if (!bandMembers[name].Contains(currentMember))
                    {
                        bandMembers[name].Add(currentMember);
                    }
                }
            }
            else
            {
                
                for (int i = 0; i < members.Length; i++)
                {
                    string currentMember = members[i];
                    if (!bandMembers[name].Contains(currentMember))
                    {
                        bandMembers[name].Add(currentMember);
                    }
                }
            }
        }
    }
}
