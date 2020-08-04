using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {

            //int n = int.Parse(Console.ReadLine());
            //int[] people = new int[n];
            //int sum = 0;

            //for (int i = 0; i < people.Length; i++)
            //{
            //    people[i] = int.Parse(Console.ReadLine());
            //    sum += people[i];


            //}

            //foreach (var current in people)
            //{
            //    Console.Write($"{current} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine(sum);

            int wagonCount = int.Parse(Console.ReadLine());
            int[] train = new int[wagonCount];
           
            for (int i = 0; i < wagonCount; i++)
            {
                int peopleInWagon = int.Parse(Console.ReadLine());
                 
                train[i] = peopleInWagon;
            }
            int sum = train.Sum();
            for (int i = 0; i < train.Length; i++)
            {
                Console.Write(train[i] +" ");
            }
            //or without " " at the end
            //for (int i = 0; i < train.Length-1; i++)
            //{
            //    Console.Write(train[i] + " ");
            //}
            //Console.WriteLine(train[train.Length-1]);
            Console.WriteLine(string.Join(" ",train));
            Console.WriteLine(sum);

        }
    }
}
