using System;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            // print the time after 30 min
            if(hour==23 && minutes>=30)
            {
                hour = 0;
                minutes -=30;

            }
            else if(minutes<30)
            {
                minutes += 30;
               
            }
            else if(minutes>=30)
            {
                minutes -=30;
                hour += 1;
                
            }
            Console.WriteLine($"{hour}:{minutes:d2}");
        }
    }
}
