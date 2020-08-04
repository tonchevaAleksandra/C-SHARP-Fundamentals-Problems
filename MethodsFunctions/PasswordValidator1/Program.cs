using System;


namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();


            bool areSymbolsValid = CheckSymbolsValid(password);
            bool isContainsAtleastTwoDigits = CheckIfAtLeastTwoDigits(password);
            bool isLengthValid = CheckLengthValid(password);

            PrintResult(isLengthValid, areSymbolsValid, isContainsAtleastTwoDigits);

        }

        static void PrintResult(bool isLengthValid, bool areSymbolsValid, bool isContainsAtleastTwoDigits)
        {
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

        static bool CheckSymbolsValid(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {

                if (!char.IsLetterOrDigit(password[i]))
                {
                    return false;

                }

            }

            return true;
        }

        static bool CheckLengthValid(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }

            return false;
        }

        static bool CheckIfAtLeastTwoDigits(string password)
        {
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    counter++;
                }
                if (counter == 2)
                {
                    return true;
                }
            }

            return false;
        }

    }
}

