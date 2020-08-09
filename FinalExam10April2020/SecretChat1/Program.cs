using System;

namespace SecretChat1
{
    class Program
    {
        static void Main(string[] args)
        {
            string concealedMessage = Console.ReadLine();
            string input;
            while ((input=Console.ReadLine())!="Reveal")
            {
                string[] cmdArgs = input.Split(":|:");
                string command = cmdArgs[0];
                concealedMessage = SwitchCommand(concealedMessage, cmdArgs, command);
            }

            Console.WriteLine($"You have a new text message: {concealedMessage}");
        }

        private static string SwitchCommand(string concealedMessage, string[] cmdArgs, string command)
        {
            switch (command)
            {
                case "InsertSpace":
                    int index = int.Parse(cmdArgs[1]);
                    concealedMessage = concealedMessage.Insert(index, " ");
                    Console.WriteLine(concealedMessage);
                    break;
                case "Reverse":
                    concealedMessage = Reverse(concealedMessage, cmdArgs);
                   
                    break;
                case "ChangeAll":
                    string substring = cmdArgs[1];
                    string replacement = cmdArgs[2];
                    if (concealedMessage.Contains(substring))
                    {
                        concealedMessage = concealedMessage.Replace(substring, replacement);
                        Console.WriteLine(concealedMessage);
                    }
                    break;
                default:
                    break;
            }

            return concealedMessage;
        }

        private static string Reverse(string concealedMessage, string[] cmdArgs)
        {
            string substring = cmdArgs[1];
            if (concealedMessage.Contains(substring))
            {
                concealedMessage = concealedMessage.Remove(concealedMessage.IndexOf(substring), substring.Length);
                char[] arr = substring.ToCharArray();
                Array.Reverse(arr);
                string reversed = new string(arr);
                concealedMessage = string.Concat(concealedMessage, reversed);
                Console.WriteLine(concealedMessage);
            }
            else
            {
                Console.WriteLine("error");
            }

            return concealedMessage;
        }
    }
}
