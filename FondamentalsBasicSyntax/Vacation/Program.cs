using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int cntPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0;
            double price = 0;

            switch (type)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            price = 8.45;
                            totalPrice = price * cntPeople;
                            break;
                        case "Saturday":
                            price = 9.80;
                            totalPrice = price * cntPeople;
                            break;
                        case "Sunday":
                            price = 10.46;
                            totalPrice = price * cntPeople;
                            break;

                    }
                    if (cntPeople >= 30)
                    {
                        totalPrice *= 0.85;
                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            price = 10.90;
                            totalPrice = price * cntPeople;
                            break;
                        case "Saturday":
                            price = 15.60;
                            totalPrice = price * cntPeople;
                            break;
                        case "Sunday":
                            price = 16.00;
                            totalPrice = price * cntPeople;
                            break;

                    }
                    if (cntPeople >= 100)
                    {
                        totalPrice -= 10 * price;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            price = 15.00;
                            totalPrice = price * cntPeople;
                            break;
                        case "Saturday":
                            price = 20.00;
                            totalPrice = price * cntPeople;
                            break;
                        case "Sunday":
                            price = 22.50;
                            totalPrice = price * cntPeople;
                            break;

                    }
                    if(cntPeople>=10&& cntPeople<=20)
                    {
                        totalPrice *= 0.95;
                    }
                    break;

            }
            Console.WriteLine($"Total price: {totalPrice:f2}");

        }
    }
}
