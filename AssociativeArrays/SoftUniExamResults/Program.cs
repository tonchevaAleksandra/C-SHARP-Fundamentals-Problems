using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            string input;
            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] cmdArgs = input.Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = cmdArgs[0];
                string language = cmdArgs[1];
                if (language == "banned")
                {
                    if (students.ContainsKey(name))
                    {
                        students.Remove(name);
                    }
                }
                else
                {
                    int points = int.Parse(cmdArgs[2]);
                    AddStudents(students, name, points);
                    AddSubmissions(submissions, language);
                }
            }

            PrintResults(ref students, ref submissions);
        }

        private static void AddSubmissions(Dictionary<string, int> submissions, string language)
        {
            if (!submissions.ContainsKey(language))
            {
                submissions[language] = 0;
            }
            submissions[language]++;
        }

        private static void AddStudents(Dictionary<string, int> students, string name, int points)
        {
            if (!students.ContainsKey(name))
            {
                students[name] = 0;
            }
            if (points > students[name])
            {
                students[name] = points;
            }
        }

        private static void PrintResults(ref Dictionary<string, int> students, ref Dictionary<string, int> submissions)
        {
            students = students.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key).ToDictionary(a => a.Key, b => b.Value);
            submissions = submissions.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key).ToDictionary(a => a.Key, b => b.Value);
            Console.WriteLine($"Results:");
            foreach (var kvp in students)
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }
            Console.WriteLine($"Submissions:");
            foreach (var kvp in submissions)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
