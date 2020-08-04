using System;

namespace TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            if(day=="Weekday" && age>=0 && age<=122)
            {
                if(age<=18 || age>64)
                {
                    price = 12;
                }
                else
                {
                    price = 18;
                }
                Console.WriteLine($"{price}$");
            }
            else if (day == "Weekend" && age >= 0 && age<= 122)
            {
                if (age <= 18 || age > 64)
                {
                    price = 15;
                }
                else
                {
                    price = 20;
                }
                Console.WriteLine($"{price}$");
            }
            else if (day == "Holiday" && age >= 0 && age <= 122)
            {
                if (age <= 18)
                {
                    price = 5;
                }
                else if(age>18 && age <= 64)
                {
                    price = 12;

                }
                else
                {
                    price = 10;
                }
                Console.WriteLine($"{price}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }

        }
    }
}
