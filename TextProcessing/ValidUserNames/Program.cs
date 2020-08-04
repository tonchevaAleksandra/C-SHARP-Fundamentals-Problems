using System;
using System.Collections.Generic;

namespace ValidUserNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] users = Console.ReadLine().Split(", ");
            List<string> valids = new List<string>();
            bool isValid = false;
            foreach (var item in users)
            {
                if(item.Length<3 || item.Length>16)
                {
                    continue;
                }
                foreach (var c in item)
                {
                    
                    if(Char.IsDigit(c) || Char.IsLetter(c) || c=='-' || c=='_')
                    {
                        isValid = true;
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                }
                if(isValid)
                {
                    valids.Add(item);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, valids));
        }
    }
}
