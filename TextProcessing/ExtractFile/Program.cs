using System;
using System.Linq;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] path = Console.ReadLine()
           .Split("\\")
           .ToArray();
            string name;
            string type;
            string[] last = path[path.Length - 1].Split(".");
            name = last[0];
            type = last[1];
            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {type}");
        }
    }
}
