using System;
using System.Text.RegularExpressions;

namespace MessageDecrypter1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^(\$|%)(?<tag>[A-Z][a-z]{2,})\1: \[(?<firstnum>[0-9]+)\]\|\[(?<secondnum>[0-9]+)\]\|\[(?<thirdnum>[0-9]+)\]\|$";
            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
               
                Match message = Regex.Match(text, pattern);
                if(message.Success)
                {
                    char first = (char)(int.Parse(message.Groups["firstnum"].Value));
                    char second = (char)(int.Parse(message.Groups["secondnum"].Value));
                    char third = (char)(int.Parse(message.Groups["thirdnum"].Value));
                   string concat = string.Concat(first, second, third);
                    Console.WriteLine($"{message.Groups["tag"].Value}: {concat}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
