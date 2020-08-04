using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            decimal sum = 0;
            while (command != "Start")
            {
                decimal currCoins = decimal.Parse(command);
                if (currCoins == 0.1M || currCoins == 0.2M || currCoins == 0.5M || currCoins == 1.00M || currCoins == 2.00M)
                {
                    sum += currCoins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currCoins}");
                }

                command = Console.ReadLine();
            }
            bool isValid = true;

            if (command == "Start")
            {
                string product = Console.ReadLine();
                decimal currPrice = 0;

                while (product != "End")
                {
                    
                    switch (product)
                    {
                        case "Nuts":
                            currPrice = 2.0M;
                            break;
                        case "Water":
                            currPrice = 0.7M;
                            break;
                        case "Crisps":
                            currPrice = 1.5M;
                            break;
                        case "Soda":
                            currPrice = 0.8M;
                            break;
                        case "Coke":
                            currPrice = 1.0M;
                            break;
                        default:
                            Console.WriteLine("Invalid product");
                            isValid = false;
                            break;
                    }

                    if (sum < currPrice && isValid)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else if(sum>=currPrice && isValid)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        sum -= currPrice;
                    }
                    
                    product = Console.ReadLine();
                }
                if (product == "End")
                {
                    Console.WriteLine($"Change: {sum:f2}");
                }
            }
        }
    }
}
