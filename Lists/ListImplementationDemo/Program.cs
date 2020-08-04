using System;
using System.Collections.Generic;
using System.Linq;

namespace ListImplementationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine(list.Capacity);
            list.Add(5);
            list.Add(5);
            list.Add(5);
            list.Add(5);
            list.AddRange(Enumerable.Range(0, 20));
            Console.WriteLine(list.Capacity);
            list.AddRange(Enumerable.Range(0, 20));
            Console.WriteLine(list.Capacity);
            list.AddRange(Enumerable.Range(0, 20));
            Console.WriteLine(list.Capacity);

        }

    }
}
    
    

