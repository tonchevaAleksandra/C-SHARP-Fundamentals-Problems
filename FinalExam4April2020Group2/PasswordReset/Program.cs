using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder oldPass = new StringBuilder(Console.ReadLine());
           //StringBuilder password = new StringBuilder();
            string input;
            while ((input=Console.ReadLine())!="Done")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                switch (command)
                {
                    case "TakeOdd":
                       oldPass= TakeCharsOnOddPositions(oldPass);
                        break;
                    case "Cut":
                        oldPass = CurTheGivenSubstring(oldPass, cmdArgs);
                        break;
                    case "Substitute":
                        oldPass = ReplaceTheGivenSubstring(oldPass, cmdArgs);
                        break;

                }
            }

            Console.WriteLine($"Your password is: {oldPass}");
        }

        private static StringBuilder ReplaceTheGivenSubstring(StringBuilder oldPass, string[] cmdArgs)
        {
            string substring = cmdArgs[1];
            string substitute = cmdArgs[2];
            if (oldPass.ToString().Contains(substring))
            {
                oldPass = oldPass.Replace(substring, substitute);
                Console.WriteLine(oldPass);
            }
            else
            {
                Console.WriteLine("Nothing to replace!");
            }

            return oldPass;
        }

        private static StringBuilder CurTheGivenSubstring(StringBuilder oldPass, string[] cmdArgs)
        {
            int index = int.Parse(cmdArgs[1]);
            int length = int.Parse(cmdArgs[2]);

            oldPass = oldPass.Remove(index, length);
            Console.WriteLine(oldPass);
            return oldPass;
        }

        private static StringBuilder TakeCharsOnOddPositions(StringBuilder oldPass)
        {
            StringBuilder current = new StringBuilder();
            for (int i = 0; i < oldPass.Length; i++)
            {
                if (i % 2 != 0)
                {
                    current.Append(oldPass[i]);
                }
            }
            Console.WriteLine(current);
            return current;
        }
    }
}
