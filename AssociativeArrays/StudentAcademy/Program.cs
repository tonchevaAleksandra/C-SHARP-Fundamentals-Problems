using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(name))
                {
                    List<double> grades = new List<double>();
                    grades.Add(grade);
                    students[name] = grades;
                }
                else
                {
                    students[name].Add(grade);
                }
            }

            Dictionary<string, double> sorted = new Dictionary<string, double>();

            FindTheAverageGradeForEachStudent(students, sorted);

            sorted = sorted.OrderByDescending(kvp => kvp.Value).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            PrintStudentsWithHigherAvrgGrade(sorted);

        }

        private static void PrintStudentsWithHigherAvrgGrade(Dictionary<string, double> sorted)
        {
            foreach (var kvp in sorted)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
        }

        private static void FindTheAverageGradeForEachStudent(Dictionary<string, List<double>> students, Dictionary<string, double> sorted)
        {
            foreach (var item in students)
            {
                if (item.Value.Average() >= 4.50)
                {
                    sorted.Add(item.Key, item.Value.Average());
                }
            }
        }
    }
}
