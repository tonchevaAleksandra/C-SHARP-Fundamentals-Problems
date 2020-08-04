using System;

namespace GiftboxCoverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double sizeOfSide = double.Parse(Console.ReadLine());
            int sheets = int.Parse(Console.ReadLine());
            double areaOfSheet = double.Parse(Console.ReadLine());

            double areaBox = sizeOfSide * sizeOfSide * 6;
            double areaOfSheets = 0;
            areaOfSheets = CalcuLateTheCoveredArea(sheets, areaOfSheet, areaOfSheets);

            double percentageCovered = areaOfSheets / areaBox * 100;

            Console.WriteLine($"You can cover {percentageCovered:f2}% of the box.");
        }

        private static double CalcuLateTheCoveredArea(int sheets, double areaOfSheet, double areaOfSheets)
        {
            for (int i = 1; i <= sheets; i++)
            {
                if (i % 3 == 0)
                {

                    areaOfSheets += areaOfSheet * 0.25;
                }
                else
                {
                    areaOfSheets += areaOfSheet;
                }
            }

            return areaOfSheets;
        }
    }
}
