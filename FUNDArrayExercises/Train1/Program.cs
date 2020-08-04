using System;
using System.Globalization;
using System.Linq;

namespace Train1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
 
            int[] newArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                int people = int.Parse(Console.ReadLine());
                newArray[i] = people;
            }

            int sumOfPeople = newArray.Sum();
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write($"{newArray[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine(sumOfPeople);

        }

       
    }
}
