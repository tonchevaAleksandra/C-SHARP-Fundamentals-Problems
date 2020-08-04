using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<chars>[\D\S]+?)(?<digits>\d+)";
            string word = Console.ReadLine();
            
            List<char> uniqueChars = new List<char>();
            MatchCollection matches = Regex.Matches(word, pattern);
            StringBuilder rage = new StringBuilder();
            foreach (Match match in matches)
            {
               
                if(match.Success)
                {
                    string currChars = match.Groups["chars"].Value.ToUpper().ToString();
                    string curr = currChars.ToString();
                    
                    int repeat = int.Parse(match.Groups["digits"].Value);
                   
                    foreach (var item in currChars)
                    {
                        if (!uniqueChars.Contains(item)&& repeat>0)
                            uniqueChars.Add(item);
                        
                    }
                    for (int i = 0; i < repeat; i++)
                    {
                        rage.Append(curr);
                    }


                 
                 
                }
            }

            Console.WriteLine($"Unique symbols used: {uniqueChars.Count}");
            Console.WriteLine(rage.ToString());
        }
    }
}
