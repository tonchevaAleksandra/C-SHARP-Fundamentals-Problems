using System;
using System.Data;

namespace EmailValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string input;
            while ((input=Console.ReadLine())!="Complete")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];

                switch (command)
                {
                    case "Make":
                        email = Make(email, cmdArgs);
                        break;
                    case "GetDomain":
                       email= GetDomain(email, cmdArgs);
                        break;
                    case "GetUsername":
                        GetUserName(email);
                        break;
                    case "Replace":
                        email = Replace(email, cmdArgs);
                        break;
                    case "Encrypt":
                        Encrypt(email);
                        break;
                    default:
                        break;
                }
            }
        }

        private static void Encrypt(string email)
        {
            foreach (var item in email)
            {
                int num = (int)item;
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }

        private static string Replace(string email, string[] cmdArgs)
        {
            char current = char.Parse(cmdArgs[1]);
            email = email.Replace(current, '-');
            Console.WriteLine(email);
            return email;
        }

        private static void GetUserName(string email)
        {
            if (email.Contains("@"))
            {
                int index = email.IndexOf("@");
                string substring = email.Substring(0, index);
                Console.WriteLine(substring);
            }
            else
            {
                Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
            }
        }

        private static string Make(string email, string[] cmdArgs)
        {
            switch (cmdArgs[1])
            {
                case "Upper":
                    email = email.ToUpper();
                    Console.WriteLine(email);
                    break;
                case "Lower":
                    email = email.ToLower();
                    Console.WriteLine(email);
                    break;
                default:
                    break;
            }

            return email;
        }

        private static string GetDomain(string email, string[] cmdArgs)
        {
            int count = int.Parse(cmdArgs[1]);
            string substring = email.Substring(email.Length - count);
            Console.WriteLine(substring);
            return email;
        }
    }
}
