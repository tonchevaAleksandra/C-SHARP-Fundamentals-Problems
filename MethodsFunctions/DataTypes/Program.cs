using System;
using System.Diagnostics;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            switch (dataType)
            {
                case "int":
                    int number = int.Parse(Console.ReadLine());
                    FindTheResult(number);
                    break;
                case "real":
                    double num = double.Parse(Console.ReadLine());
                    FindTheResult(num);
                    break;
                case "string":
                    string word = Console.ReadLine();
                    FindTheResult(word);
                    break;
               
            }
        }

        static void FindTheResult(int number)
        {
            Console.WriteLine($"{number*2}");
        }

        static void FindTheResult(double num)
        {
            Console.WriteLine($"{(num*1.5):f2}");
        }

        static void FindTheResult(string word)
        {
            Console.WriteLine($"${word}$");
        }
    }
}
