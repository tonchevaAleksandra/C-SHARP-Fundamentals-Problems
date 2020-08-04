using System;
using System.Collections.Generic;
using System.Linq;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<string> names = new List<string>();
            // names.Add("Peter");
            // string[] namesStudents = { "Alex", "Ivan" };
            // names.AddRange(namesStudents);
            //int counterSt= names.Count;
            // // remove  just one element
            // names.Remove("Peter"); // true false
            // bool isRemoved = names.Remove("Iva");
            // Console.WriteLine(isRemoved);
            // names.RemoveAt(1);// remove element from the given index 1
            // names.RemoveRange(1, 10);
            // List.Insert(0, 5);


            List<int> numbers = new List<int>
            { 10, 20, 30};

            int n = int.Parse(Console.ReadLine());

            ReadNumbersForList(numbers, n);
            PrintListOfNumbers(numbers);
            List<int> secondNums=ReadList(n);

            for (int i = 0; i <secondNums.Count ; i++)
            {
                Console.WriteLine(secondNums[i]);
            }

            //string[] array = "pesho niki gosho".Split();
            //List<string> list = array.ToList();
            //list[0] = "5";

            List<int> integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


        }

        static void ReadNumbersForList(List<int> numbers,int n)
        {
            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            
        }

        static void PrintListOfNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        static List<int> ReadList(int n)
        {
            List<int> secondNums = new List<int>();
            for (int i = 0; i < n; i++)
            {
                secondNums.Add(int.Parse(Console.ReadLine()));
            }
            return secondNums;
        }

       
    }
}
