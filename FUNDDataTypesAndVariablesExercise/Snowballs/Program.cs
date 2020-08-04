using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger snowballs = int.Parse(Console.ReadLine()); //number of snowballs made by toni and andi
            BigInteger maxValue = int.MinValue;
            BigInteger bestSnowballSnow = 0;
            BigInteger bestSnowballTime = 0;
            BigInteger bestSnowballQuality = 0;
            

            for (BigInteger i = 0; i < snowballs; i++)
            {
                 BigInteger snowballSnow = BigInteger.Parse(Console.ReadLine());
                BigInteger snowballTime = BigInteger.Parse(Console.ReadLine());
                BigInteger snowballQuality = BigInteger.Parse(Console.ReadLine());
                BigInteger snowballValue =(BigInteger) BigInteger.Pow((snowballSnow /snowballTime), (int)snowballQuality);
                if(snowballValue>maxValue)
                {
                    maxValue = snowballValue;
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                }

            }
            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {maxValue} ({bestSnowballQuality})");
        }
    }
}
