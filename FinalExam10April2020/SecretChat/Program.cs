
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;

namespace SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string encrypted = Console.ReadLine();
            string input;
            StringBuilder decrypted = new StringBuilder();
            while ((input=Console.ReadLine())!="Reveal")
            {
                string[] commandArgs = input.Split(":|:",StringSplitOptions.RemoveEmptyEntries);

                string cmd = commandArgs[0];
                switch (cmd)
                {
                    case "InsertSpace":
                        encrypted = InsertSpaceAtGivenIndex(encrypted, commandArgs);
                        break;
                    case "Reverse":
                        encrypted = ReverseASubstring(encrypted, commandArgs);
                        break;
                    case "ChangeAll":
                        encrypted = ChangeAllSequencesOfGivenString(encrypted, commandArgs);

                        break;

                }
            }

            Console.WriteLine($"You have a new text message: {encrypted}");
        }

        private static string ChangeAllSequencesOfGivenString(string encrypted, string[] commandArgs)
        {
            string substr = commandArgs[1];
            string replacement = commandArgs[2];
            if (encrypted.Contains(substr))
            {
                while (encrypted.Contains(substr))
                {
                    encrypted = encrypted.Replace(substr, replacement);
                }
                Console.WriteLine(encrypted);
            }

            return encrypted;
        }

        private static string ReverseASubstring(string encrypted, string[] commandArgs)
        {
            string content = commandArgs[1];

            int lenght = content.Length;
            if (encrypted.Contains(content))
            {
                int indexOf = encrypted.IndexOf(content);
                string newStr = encrypted.Substring(indexOf, lenght);
                encrypted = encrypted.Remove(indexOf, lenght);
                char[] result = newStr.ToCharArray();
                Array.Reverse(result);
                string reversed = new string(result);
                encrypted = string.Concat(encrypted, reversed);
                Console.WriteLine(encrypted);
            }
            else
            {
                Console.WriteLine("error");
            }

            return encrypted;
        }

        private static string InsertSpaceAtGivenIndex(string encrypted, string[] commandArgs)
        {
            int index = int.Parse(commandArgs[1]);
            string space = " ";
            encrypted = encrypted.Insert(index, space);
            Console.WriteLine(encrypted);
            return encrypted;
        }
    }
}
