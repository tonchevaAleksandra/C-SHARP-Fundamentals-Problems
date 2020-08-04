using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RepeatString());
        }
        static string RepeatString()
        {
            string a = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                result += a;
            }
            return result;
        }
    }
}
