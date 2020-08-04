using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> register = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = input.Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string course = cmdArgs[0];
                string student = cmdArgs[1];
                if (!register.ContainsKey(course))
                {
                    List<string> names = new List<string>();
                    names.Add(student);
                    register.Add(course, names);
                }
                else
                {
                    register[course].Add(student);
                }
            }

            register = register.OrderByDescending(k => k.Value.Count).ToDictionary(a => a.Key.Trim(), b => b.Value.OrderBy(b => b).ToList());

            PrintRegister(register);
        }

        private static void PrintRegister(Dictionary<string, List<string>> register)
        {
            foreach (var kvp in register)
            {
                int sum = kvp.Value.Count();
                Console.WriteLine($"{kvp.Key}: {sum}");
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"--{item}");
                }
            }
        }
    }
}
