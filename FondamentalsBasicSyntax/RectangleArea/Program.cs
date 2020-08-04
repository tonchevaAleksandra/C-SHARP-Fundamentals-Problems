using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width =  double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine($"{width*height:f2}");
        }
    }
}
