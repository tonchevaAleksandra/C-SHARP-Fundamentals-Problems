using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> register = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split().ToArray();
                string command = cmdArgs[0];
                string name = cmdArgs[1];
                switch (command)
                {
                    case "register":

                        RegisterUsers(register, cmdArgs, name);

                        break;
                    case "unregister":
                        UnregisterUsers(register, name);
                        break;

                }
            }

            PrintRegister(register);
        }

        private static void PrintRegister(Dictionary<string, string> register)
        {
            foreach (var kvp in register)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }

        private static void UnregisterUsers(Dictionary<string, string> register, string name)
        {
            if (register.ContainsKey(name))
            {
                Console.WriteLine($"{name} unregistered successfully");
                register.Remove(name, out string value);
            }
            else
            {
                Console.WriteLine($"ERROR: user {name} not found");
            }
        }

        private static void RegisterUsers(Dictionary<string, string> register, string[] cmdArgs, string name)
        {
            string license = cmdArgs[2];
            if (!register.ContainsKey(name))
            {
                register[name] = license;
                Console.WriteLine($"{name} registered {license} successfully");
            }
            else
            {
                Console.WriteLine($"ERROR: already registered with plate number {license}");
            }
        }
    }
}
