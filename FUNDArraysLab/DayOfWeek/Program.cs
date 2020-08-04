using System;
using System.Collections.Generic;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> num = new List<int>();
            //while (true)
            //{
            //    num.Add(int.Parse(Console.ReadLine()));
            //}
            string[] daysOfWeek = /*new string[]*/ { 
                "Monday",
                "Tuesday", 
                "Wednesday", 
                "Thursday", 
                "Friday", 
                "Saturday",
                "Sunday" 
            };
            //Console.WriteLine("Enter what day you want (1-7)");
            int daysAsNum = int.Parse(Console.ReadLine());
            if(daysAsNum>=1&& daysAsNum<=7)
            {
                Console.WriteLine($"{daysOfWeek[daysAsNum - 1]}");
            }
            else
            {
                Console.WriteLine("Invalid day!");
                
            }
           


        }
    }
}
