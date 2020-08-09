using System;
using System.Text.RegularExpressions;

namespace FancyBarcodes1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@\#+(?<barcode>[A-Z][a-zA-Z0-9]{4,}[A-Z])@\#+";
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string code = Console.ReadLine();
                Match match = Regex.Match(code, pattern);
                FindMatches(match);
            }
        }

        private static void FindMatches(Match match)
        {
            if (match.Success)
            {
                string patternProduct = @"[0-9]";
                string barcode = match.Groups["barcode"].Value;
                MatchCollection productMatches = Regex.Matches(barcode, patternProduct);
                string product = FindProductGroup(productMatches);
                Console.WriteLine($"Product group: {product}");
            }
            else
            {
                Console.WriteLine("Invalid barcode");
            }
        }

        private static string FindProductGroup(MatchCollection productMatches)
        {
            string product = string.Empty;
            if (productMatches.Count == 0)
            {
                product = "00";
            }
            else
            {
                foreach (Match item in productMatches)
                {
                    product += item.Value;
                }
            }

            return product;
        }
    }
}
