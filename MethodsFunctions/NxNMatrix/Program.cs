using System;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintNxNMatrix(n);
        }

        static void PrintNxNMatrix(int n)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(n +" ");
                }
                Console.WriteLine();
            }
        }
    }
}
