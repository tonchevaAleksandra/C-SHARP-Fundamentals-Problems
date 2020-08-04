using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double budget = double.Parse(Console.ReadLine());
            int cntStudents = int.Parse(Console.ReadLine());
            double prLightsabers = double.Parse(Console.ReadLine());
            double prRobes = double.Parse(Console.ReadLine());
            double prBelts = double.Parse(Console.ReadLine());
           double cntLightabers = Math.Ceiling(1.1 * cntStudents);
            double cntBelts = cntStudents;
            int counterBelts = 0;
            for (int i = 1; i <= cntBelts; i++)
            {
                if(i%6==0)
                {
                    counterBelts++;
                }
            }
            cntBelts = cntStudents - counterBelts;
            double totalPrice = prLightsabers * cntLightabers + prRobes * cntStudents + prBelts * cntBelts;
            if(totalPrice<=budget)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalPrice-budget:f2}lv more.");
            }

        }
    }
}
