using System;
using System.Linq;

namespace DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] =int.Parse( Console.ReadLine());                                                                                    
            }
                
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]:d4} ");
            }                   
        }
    }
}
