using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {

            int lostGames = int.Parse(Console.ReadLine());
            double priceHSet = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKBoard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());

            int cntMouse = 0;
            int cntHSet = 0;
            int cntKBoard = 0;
            int cntDisplay = 0;
            

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2==0)
                {
                    cntHSet++;
                }
                if(i%3==0)
                {
                    cntMouse++;
                }
                if(i%2==0 && i%3==0)
                {
                    cntKBoard++;
                    if(cntKBoard%2==0)
                    {
                        cntDisplay++;
                    }
                }
            }

            double totalPrice = priceDisplay * cntDisplay + priceHSet * cntHSet + priceKBoard * cntKBoard + priceMouse * cntMouse;
            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");


        }
    }
}
