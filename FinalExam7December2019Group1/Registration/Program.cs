using System;
using System.Text.RegularExpressions;

namespace Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"([U]\$)(?<username>[A-Z]{1}[a-z]{2,})([U]\$)([P]\@\$)(?<password>[0-9]*[A-Za-z]{5,}[0-9]+)([P]\@\$)";
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                string registration = Console.ReadLine();
                Match reg = Regex.Match(registration, pattern);
                if(reg.Success)
                {
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {reg.Groups["username"].Value}, Password: {reg.Groups["password"].Value}");
                    count++;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }

            Console.WriteLine($"Successful registrations: {count}");
        }
    }
}
