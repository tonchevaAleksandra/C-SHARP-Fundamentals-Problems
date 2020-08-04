using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int countOpenBracelet = 0;
            int countCloseBracelet = 0;
            int countStrings = 0;

            for (int i = 0; i < lines; i++)
            {
                
                string current = Console.ReadLine();
                if(current=="(")
                {
                    countOpenBracelet++;
                }
                else if(current==")")
                {
                    countCloseBracelet++;
                    if(countOpenBracelet-countCloseBracelet!=0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
               
                

            }
            if(countOpenBracelet==countCloseBracelet)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
