using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string passWord = string.Empty;

            char[] array = userName.ToCharArray();
            for (int i = userName.Length - 1; i >= 0; i--)
            {
          
                passWord +=userName[i];
            }

            bool isCorrect = false;
            int counterFalse = 0;
            while (!isCorrect)
            {
                string pass = Console.ReadLine();
               
                if(pass==passWord)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    
                    break;
                }
                else 
                {
                    counterFalse++;
                    if (counterFalse < 4)
                    { 
                        Console.WriteLine("Incorrect password. Try again.");
                       
                    }
           
                }

                if (counterFalse == 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }

            }
        }
    }
}
