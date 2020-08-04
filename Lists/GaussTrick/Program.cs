using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> numbers= ReadList();
            for (int i = 0; i < numbers.Count/2; i++)
            {
                Console.Write(numbers[i]+ numbers[numbers.Count-1-i]+" ");
            }

            if(numbers.Count%2==1)
            {
                Console.WriteLine(numbers[numbers.Count/2]);
            }
        }

        static List<int> ReadList()
        {
            List<int> numbers = new List<int>();
            //var line = Console.ReadLine();
            //numbers = line.Split().Select(int.Parse).ToList();
            string[] elements = Console.ReadLine().Split();

            for (int i = 0; i < elements.Length; i++)
            {
                numbers.Add(int.Parse(elements[i]));
            }

            return numbers;
        }
    }
}
