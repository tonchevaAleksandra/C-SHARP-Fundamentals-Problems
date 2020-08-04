using System;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalIncome = 0.0m;
            string pattern = @"^%(?<customer>[A-Z]{1}[a-z]+)%[^|$%\.]*?<(?<product>\w+)>[^|$%\.]*?\|(?<count>\d+)\|[^|$%\.]*?(?<price>\d+\.?\d*)\$$";

            string input;
            while ((input=Console.ReadLine())!="end of shift")
            {
                Match match = Regex.Match(input, pattern);
                if(match.Success)
                {
                    string customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    long count = long.Parse(match.Groups["count"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    if(count!=0)
                    {
                       decimal totalPrice= price * count;
                        totalIncome += totalPrice;
                        Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
                    }
                }
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
            //string pattern = @"[0-9]{1}";
            //Regex regex = new Regex(pattern);
            //string text = Console.ReadLine();
            //while (true)
            //{
            //    Match match = Regex.Match(text, pattern);
            //    if(!match.Success)
            //    {
            //        break;
            //    }
            //}
        }
    }
}
