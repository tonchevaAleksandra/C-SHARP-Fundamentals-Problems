using System;
using System.Collections.Generic;

namespace AddRange
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            List<int> list2 = new List<int>() { 1, 2, 3, 4 };
            list.AddRange(list2);
            list.Add(0);
            list.AddRange(list2);
            Console.WriteLine(string.Join( " ",list));
        }
    }
}
