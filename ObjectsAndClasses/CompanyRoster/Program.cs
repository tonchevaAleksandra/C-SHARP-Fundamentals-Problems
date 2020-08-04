using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            int n = int.Parse(Console.ReadLine());

            List<string> departments = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Employee employee = new Employee(input[0], double.Parse(input[1]), input[2]);
                employees.Add(employee);
                departments.Add(input[2]);
            }

            //remove duplicates departments
            departments = departments.Distinct().ToList();
            string departmentHighestSalary = string.Empty;
            double highestAvSalary = double.MinValue;

            foreach (string item in departments)
            {
                double avrSalary = employees.Where(e =>e.Department == item).Select(e=>e.Salary).Average() ;

                if(avrSalary>highestAvSalary)
                {
                    departmentHighestSalary = item;
                    highestAvSalary = avrSalary;
                }
            }

            Console.WriteLine($"Highest Average Salary: {departmentHighestSalary}");

            foreach (var employee in employees.Where(e=>e.Department==departmentHighestSalary).OrderByDescending(e=>e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }
    }

    class Employee
    {
        public string Name { get; set; }

        public double Salary { get; set; }

        public string Department { get; set; }

        public Employee(string name, double salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }
    }   
}
