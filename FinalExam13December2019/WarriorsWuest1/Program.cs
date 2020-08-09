using System;

namespace WarriorsQuest1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input;
            while ((input=Console.ReadLine())!="For Azeroth")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                switch (command)
                {
                    case "GladiatorStance":
                        text = text.ToUpper();
                        Console.WriteLine(text);
                        break;
                    case "DefensiveStance":
                        text = text.ToLower();
                        Console.WriteLine(text);
                        break;
                    case "Dispel":
                        text = Dispel(text, cmdArgs);
                        break;
                    case "Target":
                        switch (cmdArgs[1])
                        {
                            case "Change":
                                text = Change(text, cmdArgs);
                                break;
                            case "Remove":
                                text = Remove(text, cmdArgs);
                                break;
                            default:
                                Console.WriteLine("Command doesn't exist!");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Command doesn't exist!");
                        break;
                }
            }
        }

        private static string Remove(string text, string[] cmdArgs)
        {
            string substring = cmdArgs[2];
            text = text.Remove(text.IndexOf(substring), substring.Length);
            Console.WriteLine(text);
            return text;
        }

        private static string Change(string text, string[] cmdArgs)
        {
            string substring = cmdArgs[2];
            string second = cmdArgs[3];
            text = text.Replace(substring, second);
            Console.WriteLine(text);
            return text;
        }

        private static string Dispel(string text, string[] cmdArgs)
        {
            int index = int.Parse(cmdArgs[1]);
            char letter = char.Parse(cmdArgs[2]);
            if (index >= 0 && index < text.Length)
            {
                text = text.Remove(index,1);
                text = text.Insert(index, letter.ToString());
                Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine("Dispel too weak.");
            }

            return text;
        }
    }
}
