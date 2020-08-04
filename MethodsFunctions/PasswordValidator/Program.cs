using System;
using System.Diagnostics.SymbolStore;
using System.Diagnostics.Tracing;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();


            bool areSymbolsValid = true;
            bool isContainsAtleastTwoDigits = false;
            bool isLengthValid = CheckLengthValid(password);

            int counter = 0;

            areSymbolsValid = NewMethod(password, areSymbolsValid);

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    counter++;
                }
            }

            if (counter >= 2)
            {
                isContainsAtleastTwoDigits = true;
            }

            if (!isLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!areSymbolsValid)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!isContainsAtleastTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isLengthValid && isContainsAtleastTwoDigits && areSymbolsValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool NewMethod(string password, bool areSymbolsValid)
        {
            for (int i = 0; i < password.Length; i++)
            {

                if (!char.IsLetterOrDigit(password[i]))
                {
                    areSymbolsValid = false;
                    break;
                }
            }

            return areSymbolsValid;
        }

        private static bool CheckLengthValid(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
               return true;
            }

            return false;
        }
    }
}
