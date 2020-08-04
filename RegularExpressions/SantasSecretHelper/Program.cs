using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SantasSecretHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            string input;
            List<string> names = new List<string>();
            while ((input=Console.ReadLine())!="end")
            {
                string encryptedMessage = input;
                StringBuilder decrypted = new StringBuilder();
                foreach (char item in encryptedMessage)
                {
                    
                    char current = (char)(item - key);
                    decrypted.Append(current);
                }

                string pattern = @"@(?<name>[A-Za-z]+)[^-@!:>]*\w*!(?<behavior>[A-Z])!";
                Match regex = Regex.Match(decrypted.ToString(), pattern);
                if(regex.Success)
                {
                    string name = regex.Groups["name"].Value;
                    string behavior = regex.Groups["behavior"].Value;
                    if(behavior=="G")
                    {
                      names.Add(name);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine,names));

        }
    }
}
