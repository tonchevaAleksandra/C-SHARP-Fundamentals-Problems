using System;
using System.Text.RegularExpressions;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"(.+?)>(?<numbers>[0-9]{3})\|(?<lowerCase>[a-z]{3})\|(?<upperCase>[A-Z]{3})\|(?<symbols>[^<>]{3})<\1";
            for (int i = 0; i < n; i++)
            {
                string password = Console.ReadLine();
                Match pass = Regex.Match(password, pattern);
                if(pass.Success)
                {
                    string first = pass.Groups["numbers"].Value;
                    string second = pass.Groups["lowerCase"].Value;
                    string third = pass.Groups["upperCase"].Value;
                    string fourth = pass.Groups["symbols"].Value;
                    string concat = string.Concat(first, second, third, fourth);
                    Console.WriteLine($"Password: { concat}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
