using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string current;
            while ((current=Console.ReadLine())!="end")
            {
                string reversed = "";
                for (int i = current.Length-1; i >= 0; i--)
                {
                    reversed += current[i];
                }
                string result = string.Join(" = ", current, reversed.ToString());
                Console.WriteLine(result);
            }           
        }
    }
}
