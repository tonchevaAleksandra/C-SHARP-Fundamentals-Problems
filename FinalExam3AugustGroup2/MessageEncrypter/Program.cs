using System;
using System.Text.RegularExpressions;

namespace MessageEncrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\*|@)(?<tag>[A-Z][a-z]{2,})\1: \[(?<first>[A-Za-z]{1})\]\|\[(?<second>[A-Za-z]{1})\]\|\[(?<third>[A-Za-z]{1})\]\|$";
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                Match reg = Regex.Match(text, pattern);
                if(reg.Success)
                {
                    string tag = reg.Groups["tag"].Value;
                   string first = reg.Groups["first"].Value;
                    string second = reg.Groups["second"].Value;
                    string third = reg.Groups["third"].Value;
                    int one =(int)first[0];
                    int two = (int)second[0];
                    int three = (int)third[0];
                    Console.WriteLine($"{tag}: {one} {two} {three}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
