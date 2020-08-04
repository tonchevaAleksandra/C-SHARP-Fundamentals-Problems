using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BigNumberDrinof
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigNumber = Console.ReadLine().TrimStart();
            var singleNumber = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            var toCarry = 0;
            var toAppend = string.Empty;


            if (singleNumber == 0)

            {
                Console.WriteLine("0");
                System.Environment.Exit(0);
            }
            else
            {

                while (bigNumber.Length > 0)
                {
                    var lastChar = bigNumber.TakeLast(1).ToArray();
                    var lastDigit = int.Parse(lastChar);
                    bigNumber = bigNumber.Remove(bigNumber.Length - 1);

                    var result = (lastDigit * singleNumber) + toCarry;
                    toAppend = (result % 10).ToString();
                    toCarry = result / 10;
                    if (bigNumber.Length == 0)
                    {

                        toAppend = result.ToString();
                        var toAppend2 = toAppend.ToCharArray().Reverse();
                        var toAppend3 = string.Join("", toAppend2);

                        toCarry = 0;
                        sb.Append(toAppend3);
                        break;
                    }
                    sb.Append(toAppend);


                }
                var endResult = sb.ToString();
                var endResult2 = endResult.ToCharArray().Reverse().ToList();

                //for (int i = 0; i < endResult2.Count; i++)
                //{


                //    if (endResult2[0] == '0')
                //    {
                //        endResult2.RemoveAt(0);
                //        i--;
                //    }
                //    else
                //    {
                //        break;
                //    }
                //}
                var finalResult = string.Join("", endResult2);
                Console.WriteLine(finalResult);

            }
        }
    }
}