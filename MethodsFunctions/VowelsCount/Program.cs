using System;

namespace VowelsCount
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    string a = Console.ReadLine();
        //    Console.WriteLine(CountVowels(a));
        //}

        //static int CountVowels(string a)
        //{
        //    int counter = 0;
        //    foreach (char ch in a)
        //    {
        //        if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' ||
        //            ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U'|| 
        //            ch == 'y' || ch == 'Y')
        //        {
        //            counter++;
        //        }

        //    }
        //    return counter;

        //}

        static void Main()
        {
            string word = Console.ReadLine().ToLower();
           
            //char[] vowels = { 'a', 'e', 'i', 'u', 'o' };
           int result = GetVowelsCount(word);
            Console.WriteLine(result);
        }

        private static int GetVowelsCount(string word)
        {
            string vowels = "aioue";
            int counter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                char currentSymbol = word[i];
                if (vowels.Contains(currentSymbol.ToString()))
                {
                    counter++;
                }

                //for (int j = 0; j < vowels.Length; j++)
                //{
                //    if(currentSymbol==vowels[j])
                //    {
                //        counter++;
                //    }
            }

            return counter;
        }
    }
}

