using System;

namespace CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = RectangeArea(width, height);
            Console.WriteLine(area);
        }
        static double RectangeArea(double width, double height)
        {
            return width * height;
        }
    }
}
