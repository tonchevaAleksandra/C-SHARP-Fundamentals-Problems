using System;
using System.Globalization;
using System.Text;

namespace PracticeHacked
{
    class Program
    {
        static void Main(string[] args)
        {
            // //int num = int.MaxValue; //in this case there is overflow exception,
            // ////to check the code we can use checked->
            // //checked
            // //{
            // //    num += 1; //now the compilator says that there is overflow exception-> in judge this is the test with * that crash

            // //}
            // ////if there is no checked the test will be xxx
            // //Console.WriteLine(num);
            // //// another way to hack 
            // //try
            // //{
            // //    checked
            // //    {
            // //        num += 1;
            // //       // this can catch the error but not the error-> throw new StackOverflowException(); yhis exception is made by using more then space you have for the program, (a while loop without break or etc.)
            // //       //

            // //    }
            // //}
            // //catch (Exception)
            // //{
            // //    Console.WriteLine("Error");
            // //    throw;
            // //}

            // DateTime date = new DateTime();
            // //Console.WriteLine(date); // result ->  1/1/0001 12:00:00 AM
            // DateTime maxdate = DateTime.MaxValue;
            // //Console.WriteLine(maxdate); // 12/31/9999 11:59:59 PM
            // CultureInfo.CurrentCulture = new CultureInfo("bg-BG", false);
            //// Console.WriteLine(date.ToString(),CultureInfo.CurrentCulture.Name); //1.1.0001 г. 0:00:00 or max value
            // CultureInfo.CurrentCulture = new CultureInfo("bg-BG", false);
            // Console.WriteLine(maxdate.ToString(), CultureInfo.CurrentCulture.Name); //31.12.9999 г. 23:59:59
            // //click on cultereInfo and then F1 and here are the options /*https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo?f1url=https%3A%2F%2Fmsdn.microsoft.com%2Fquery%2Fdev16.query%3FappId%3DDev16IDEF1%26l%3DEN-US%26k%3Dk(System.Globalization.CultureInfo);k(DevLang-csharp)%26rd%3Dtrue&view=netcore-3.1*/

            // DateTime date1 = new DateTime(2020, 5, 9);
            // Console.WriteLine(date1); // 9.5.2020 г. 0:00:00

            string text = "Hello";  //string -> immutability - непроменяем неизменим е стирнга
            text += ", World!"; //when we add a word in existing string the memory save the original value of a string and make another storage in memory for the same string with the added word
            for (int i = 0; i < 10; i++)
            {
                text += ", World!";
                //all the strings printed are used the memory, everithing is in the memory
            }
            Console.WriteLine(text);
            //for not doing this we have to search string muttable in c#
           // StringBuilder id muttable -> that is optimised variation os a string for add another text to  string without use so much memory 




        }
    }
}
