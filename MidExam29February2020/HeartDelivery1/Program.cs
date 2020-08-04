using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace HeartDelivery1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine()
           .Split("@")
           .Select(int.Parse)
           .ToList();

            string input = string.Empty;
            int startIndex = 0;
            int countValentine = 0;
            while((input=Console.ReadLine())!= "Love!")
            {
                string[] cmdArgs = input.Split();
                int length = int.Parse(cmdArgs[1]);
                if(startIndex+length>numbers.Count-1)
                {
                    startIndex = 0;
                }
               else
                {

                    startIndex = startIndex + length;
                }
                if(numbers[startIndex]<=0)
                {
                    Console.WriteLine($"Place {startIndex} already had Valentine's day.");
                    
                }
                else
                {
                    numbers[startIndex] -= 2;
                    if(numbers[startIndex]<=0)
                    {
                        Console.WriteLine($"Place {startIndex} has Valentine's day.");
                        countValentine++;
                    }
                }
                
            }

            Console.WriteLine($"Cupid's last position was {startIndex}.");
            if(countValentine==numbers.Count)
            {
                Console.WriteLine($"Mission was successful.");
            }
            else
            {
                int count = numbers.Count - countValentine;
                Console.WriteLine($"Cupid has failed {count} places.");
            }
        }
    }
}
