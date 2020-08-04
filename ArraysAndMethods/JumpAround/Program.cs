using System;
using System.Linq;

namespace JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

             int sum =0;
            int num = numbers[0];
            sum = num;
            int index = 0;

            while (true)
            {
                if((index+num)<numbers.Length)
                {
                    sum += numbers[index + num];
                    index += num;
                    num = numbers[index];
                }
                else if(index-num>=0)
                {
                    sum += numbers[index - num];
                    index -= num;
                    num = numbers[index];
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(sum);
           
        }
    }
}
