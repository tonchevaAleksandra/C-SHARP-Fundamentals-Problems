using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);
                Student currStudent = new Student(firstName, lastName, grade);
                students.Add(currStudent);
            }

            students = students.OrderByDescending(s => s.Grade).ToList();
           
            Console.WriteLine(String.Join(Environment.NewLine,students));

        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName,double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";     
        }
    }
}
