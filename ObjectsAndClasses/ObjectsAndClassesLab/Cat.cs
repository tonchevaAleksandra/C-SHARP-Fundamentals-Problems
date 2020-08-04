using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Practice
{
    public class Cat
    {
        public Cat(string name, int age)
        {
            Name = name;
            Age = age;
            if(name.Length<2)
            {
                throw new Exception("Cat name cannot be less then 2 symbols.");
            }
            if(age<0)
            {
                throw new Exception("Cat age is required");
            }
            
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string SayHello()
        {
            return "Hello from " + Name;
       

        }
        public Cat(string name)
        {
            Name = name;
        }
    }
}
