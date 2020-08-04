using System;
using System.Text.RegularExpressions;

namespace Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            string encrypted = Console.ReadLine();
            string pattern = @"(?<=^|\s)[d-z{}\|#]+$";
            string[] substrings = Console.ReadLine().Split();
            Match match = Regex.Match(encrypted, pattern);

           
            if (match.Success)
            {
                
                string decrypted = string.Empty;
                for (int i = 0; i < encrypted.Length; i++)
                {
                    char curr = (char)(encrypted[i] - 3);
                    decrypted += curr;
                }

                if (decrypted.Contains(substrings[0]))
                {
                    decrypted = decrypted.Replace(substrings[0], substrings[1]);
                }
                Console.WriteLine(decrypted);
            }
            else
            {
                Console.WriteLine("This is not the book you are looking for.");
                return;
            }
        }
    }
}
