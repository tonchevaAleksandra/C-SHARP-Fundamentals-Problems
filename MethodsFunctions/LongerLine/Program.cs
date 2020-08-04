using System;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1First = double.Parse(Console.ReadLine());
            double y1First = double.Parse(Console.ReadLine());
            double x2First = double.Parse(Console.ReadLine());
            double y2First = double.Parse(Console.ReadLine());
            double x1Second = double.Parse(Console.ReadLine());
            double y1Second = double.Parse(Console.ReadLine());
            double x2Second = double.Parse(Console.ReadLine());
            double y2Second = double.Parse(Console.ReadLine());

            FindTheLongestLine(x1First, y1First, x2First, y2First, x1Second, y1Second, x2Second, y2Second);
        }

        static void FindTheLongestLine(double x1First, double y1First, double x2First, double y2First, double x1Second, double y1Second, double x2Second, double y2Second)
        {
            double result1 = Math.Abs(x1First) + Math.Abs(y1First) + Math.Abs(x2First) + Math.Abs(y2First);
            double result2 = Math.Abs(x1Second) + Math.Abs(y1Second) + Math.Abs(x2Second) + Math.Abs(y2Second);
            if(result1>=result2)
            {
                if(Math.Abs(x1First) + Math.Abs(y1First) <= Math.Abs(x2First) + Math.Abs(y2First))
                {
                    Console.WriteLine($"({x1First}, {y1First})({x2First}, {y2First})");
                }
                else
                {
                    Console.WriteLine($"({x2First}, {y2First})({x1First}, {y1First})");
                }
            }

            else
            {
                if (Math.Abs(x1Second) + Math.Abs(y1Second) <= Math.Abs(x2Second) + Math.Abs(y2Second))
                {
                    Console.WriteLine($"({x1Second}, {y1Second})({x2Second}, {y2Second})");
                }
                else
                {
                    Console.WriteLine($"({x2Second}, {y2Second})({x1Second}, {y1Second})");
                }
            }
        }
    }
}
