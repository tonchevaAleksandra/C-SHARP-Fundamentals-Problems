using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = string.Empty;
            List<Students> students = new List<Students>();

            while ((input=Console.ReadLine())!="end")
            {
                string[] currStudent = input.Split();
                string firstName = currStudent[0];
                string lastName = currStudent[1];
                int age = int.Parse(currStudent[2]);
                string homeTown = currStudent[3];
                Students student = new Students();
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.Hometown = homeTown;
                students.Add(student);
            }

            string city = Console.ReadLine();
           

            List<Students> filteredStudents = students.Where(student => student.Hometown == city).ToList();

            foreach (Students student in filteredStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " is " + student.Age + " years old.");
            }
        }
    }
    public class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }

    }
}
