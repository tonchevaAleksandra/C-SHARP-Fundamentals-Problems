using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace BitWise
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(global::System.Console.ReadLine());
            int digit = int.Parse(Console.ReadLine());
            string binaryString ;

            List<int> binarySeq = new List<int>();
            int count = 0;
            while (number != 0)
            {
                int reminder = number % 2;
                if (reminder == digit)
                {
                    count++;
                }
                number /= 2;
                binarySeq.Add(reminder);
            }

            Console.WriteLine(count);
           
        }
    }
}
