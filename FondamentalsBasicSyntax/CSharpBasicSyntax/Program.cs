using System;

namespace CSharpBasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool isMale = true;
            //int muscules = isMale ? 200 : 10;
            //Console.WriteLine(muscules);

            int n;
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine(n);
               
        }
    }
}
