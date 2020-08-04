using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine().ToLower();
            string second = Console.ReadLine();
            int index = second.IndexOf(first);
            while (index != -1)
            {

                second = second.Remove(index, first.Length);
                index = second.IndexOf(first);
            }
            Console.WriteLine(second);

        }
    }
}
