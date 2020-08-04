using System;

namespace PrintingTriangle
{
    class Program
    {
        static void PrinLine(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write((col) + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintFigure(n);
        }

        static void PrintFigure(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                PrinLine(row);
            }

            for (int row = n - 1; row >= 1; row--)
            {
                PrinLine(row);
            }
        }
    }
}
