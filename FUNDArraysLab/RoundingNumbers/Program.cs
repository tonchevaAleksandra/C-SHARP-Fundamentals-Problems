using System;
using System.Linq;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //string values = Console.ReadLine();
            //string[] items = values.Split();
            //var arr = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
            //double[] numbers = new double[items.Length];
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
             
                   int round= (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers[i]} => {round}");
            }


        }
    }
}
