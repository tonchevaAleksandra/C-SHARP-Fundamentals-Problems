using System;
using System.Collections.Generic;
using System.Linq;

namespace Students2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Students> students = new List<Students>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] currStudent = input.Split();
                string firstName = currStudent[0];
                string lastName = currStudent[1];
                int age = int.Parse(currStudent[2]);
                string homeTown = currStudent[3];

                Students student = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
                if(student==null)
                {
                    students.Add(new Students()
                    {
                        FirstName = firstName,
                        LastName=lastName,
                        Age=age,
                        Hometown=homeTown

                    });
                    
                }
                else
                {
                   
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.Hometown = homeTown;
                 
                }

                //if(IsExicting(students, firstName,lastName))
                //{
                //    student.Age = age;
                //}
                //else
                //{
                //    student.FirstName = firstName;
                //    student.LastName = lastName;
                //    student.Age = age;
                //    student.Hometown = homeTown;
                //    students.Add(student);
                //}


            }

            string city = Console.ReadLine();


            List<Students> filteredStudents = students.Where(student => student.Hometown == city).ToList();

            foreach (Students student in filteredStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " is " + student.Age + " years old.");
            }
        }

        public static bool IsExicting( List<Students> students,string firsName, string lasName)
        {
            foreach (Students student in students)
            {
                if(student.FirstName==firsName && student.LastName==lasName)
                {
                    return true;
                }
            }
            return false;
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


