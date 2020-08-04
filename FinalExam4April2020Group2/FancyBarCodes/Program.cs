using System;
using System.Text.RegularExpressions;

namespace FancyBarCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternValidation = @"@#+([A-Z][a-zA-Z0-9]{4,}[A-Z])@#+";
            int n = int.Parse(Console.ReadLine());
            string productPattern = @"[0-9]";
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match valid = Regex.Match(input, patternValidation);
                if (valid.Success)
                {
                    MatchCollection digits = Regex.Matches(input, productPattern);
                    string productType = string.Empty;
                    if (digits.Count == 0)
                    {
                        productType = "00";

                    }
                    else
                    {
                        foreach (Match match in digits)
                        {
                            productType += match;
                        }
                    }
                    Console.WriteLine($"Product group: {productType}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
