using System;

namespace LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
           
            if(a>=65 && a<=95)
            {
                Console.WriteLine("upper-case");
            }
            else if(a>=97 && a<=122)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
