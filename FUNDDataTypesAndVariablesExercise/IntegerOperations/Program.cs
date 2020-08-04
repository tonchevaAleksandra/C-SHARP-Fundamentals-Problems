using System;

namespace IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            long first  = long.Parse(Console.ReadLine());
            long second = long.Parse(Console.ReadLine());
            long third  = long.Parse(Console.ReadLine());
            long fourth = long.Parse(Console.ReadLine());
            Console.WriteLine((first+second)/third*fourth);
        }
    }
}
