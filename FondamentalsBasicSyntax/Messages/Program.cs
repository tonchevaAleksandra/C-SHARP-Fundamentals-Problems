using System;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string digits = Console.ReadLine();
                int digitLength = digits.Length;
                char oneDigit = digits[0];
                int mainDigit = (int)oneDigit - 48;
                int offset = (mainDigit - 2) * 3;

                if(mainDigit==8 || mainDigit==9)
                {
                    offset = (mainDigit - 2) * 3 + 1;
                }

                int letterIndex = offset + digitLength - 1;
                int letterCode = letterIndex + 97; //Ascii

                char letter = (char)letterCode;
                if(mainDigit==0)
                {
                    letter = ' ';
                }

                message += letter;
                
            }

            Console.WriteLine(message);
        }
    }
}
