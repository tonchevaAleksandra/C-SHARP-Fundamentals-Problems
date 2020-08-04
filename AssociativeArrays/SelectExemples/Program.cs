using System;
using System.Linq;

namespace SelectExemples
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };

            int[] arrayBy5 = array.Select(x => x*5).ToArray(); //change all the elements in the array
            //also we can give  to Select(method) a method made by us



        }
    }
}
