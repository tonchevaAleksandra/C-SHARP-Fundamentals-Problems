using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Username
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string input;
            while ((input=Console.ReadLine())!="Sign up")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                switch (command)
                {
                    case "Case":
                        username = Case(username, cmdArgs);
                        break;
                    case "Reverse":
                        ReverseSubstring(username, cmdArgs);
                        break;
                    case "Cut":
                        username = CutSubstring(username, cmdArgs);
                        break;
                    case "Replace":
                        username = ReplaceChar(username, cmdArgs);
                        break;
                    case "Check":
                        Check(username, cmdArgs);
                        break;
                    default:
                        break;
                }
            }
        }

        private static string ReplaceChar(string username, string[] cmdArgs)
        {
            char current = char.Parse(cmdArgs[1]);
            char replacement = '*';
            while (username.Contains(current))
            {
                username = username.Replace(current, replacement);
            }
           
            Console.WriteLine(username);
            return username;
        }

        private static void Check(string username, string[] cmdArgs)
        {
            char curr = char.Parse(cmdArgs[1]);
            if (username.Contains(curr))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine($"Your username must contain {curr}.");
            }
        }

        private static string CutSubstring(string username, string[] cmdArgs)
        {
            string substring = cmdArgs[1];
            if (username.Contains(substring))
            {
                username = username.Remove(username.IndexOf(substring), substring.Length);
                Console.WriteLine(username);
            }
            else
            {
                Console.WriteLine($"The word {username} doesn't contain {substring}.");
            }

            return username;
        }

        private static void ReverseSubstring(string username, string[] cmdArgs)
        {
            int startIndex = int.Parse(cmdArgs[1]);
            int endIndex = int.Parse(cmdArgs[2]);
            if (startIndex >= 0 && startIndex < username.Length && endIndex+1 < username.Length)
            {
               char[] current = username.Substring(startIndex, endIndex+1 - startIndex).ToCharArray();
                Array.Reverse(current);
                string curr = new string(current);
                Console.WriteLine(curr);
            }
        }

        private static string Case(string username, string[] cmdArgs)
        {
            switch (cmdArgs[1])
            {
                case "lower":
                    username = username.ToLower();
                    Console.WriteLine(username);
                    break;
                case "upper":
                    username = username.ToUpper();
                    Console.WriteLine(username);
                    break;
                default:
                    break;
            }

            return username;
        }
    }
}
