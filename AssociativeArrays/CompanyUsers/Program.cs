using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> company = new SortedDictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArg = input.Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = cmdArg[0];
                string id = cmdArg[1];

                if (!company.ContainsKey(name))
                {
                    List<string> employees = new List<string>();
                    employees.Add(id);
                    company[name] = employees;
                }
                else
                {
                    if (!company[name].Contains(id))
                    {
                        company[name].Add(id);
                    }
                }
            }

            PrintCompanyNameAndIDs(company);
        }

        private static void PrintCompanyNameAndIDs(SortedDictionary<string, List<string>> company)
        {
            foreach (var kvp in company)
            {
                Console.WriteLine($"{kvp.Key.Trim()}");
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"--{item}");
                }
            }
        }
    }
}
