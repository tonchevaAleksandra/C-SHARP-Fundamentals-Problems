using System;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine().TrimStart('0');

            int power = int.Parse(Console.ReadLine());
            if( power==0)
            {
                Console.WriteLine(0);
                return;
            }
            //if(power==1)
            //{
            //    Console.WriteLine(number);
            //    return;
            //}
            var result = string.Empty;
            char rest = new char();
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int value = int.Parse(number[i].ToString()) * power;

                if (Char.IsDigit(rest))
                {
                    value += (int)rest - 48;
                }
                string curr = value.ToString();
                if (value <= 9)
                {
                    result+=(curr.ToString());
                    rest = new char();
                }
                else
                {

                    result+=(((int)curr[1] - 48).ToString());
                    rest = (char)curr[0];
                }

            }
            if (char.IsDigit(rest))
            {
                result+=((int)rest - 48).ToString();
            }
            //for (int i = result.Length - 1; i >= 0; i--)
            //{
            //    if (result[i] == '0')
            //    {
            //        result = result.Remove(i, 1);
                   
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            for (int i = result.Length - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }
        }
    }
}
