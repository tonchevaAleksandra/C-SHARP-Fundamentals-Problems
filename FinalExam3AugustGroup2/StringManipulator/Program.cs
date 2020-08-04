using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace StringManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Done")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                switch (command)
                {
                    case "Change":
                        text = Change(text, cmdArgs);
                        break;
                    case "Includes":
                        Includes(text, cmdArgs);
                        break;
                    case "End":
                        End(text, cmdArgs);
                        break;
                    case "Uppercase":
                        text = text.ToUpper();
                        Console.WriteLine(text);
                        break;
                    case "FindIndex":
                        FindIndex(text, cmdArgs);
                        break;
                    case "Cut":
                        text = Cut(text, cmdArgs);
                        break;

                }
            }
        }

        private static void FindIndex(string text, string[] cmdArgs)
        {
            char curr = char.Parse(cmdArgs[1]);
            if (text.Contains(curr))
            {
                int index = text.IndexOf(curr);
                Console.WriteLine(index);
            }

        }

        private static string Cut(string text, string[] cmdArgs)
        {
            int startIndex = int.Parse(cmdArgs[1]);
            int length = int.Parse(cmdArgs[2]);
            if (startIndex >= 0 && startIndex < text.Length)
            {
                text = text.Substring(startIndex, length);

                Console.WriteLine(text);
            }
            return text;
        }

        private static void End(string text, string[] cmdArgs)
        {
            string current = cmdArgs[1];
            if (text.EndsWith(current))
            {           
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

            private static void Includes(string text, string[] cmdArgs)
            {
                string current = cmdArgs[1];
                bool isIncluding = text.Contains(current);
                Console.WriteLine(isIncluding);
            }

            private static string Change(string text, string[] cmdArgs)
            {
                char current = char.Parse(cmdArgs[1]);
                char replacement = char.Parse(cmdArgs[2]);
                if (text.Contains(current))
                {
                    text = text.Replace(current, replacement);
                    Console.WriteLine(text);
                }

                return text;
            }
        }
    }
