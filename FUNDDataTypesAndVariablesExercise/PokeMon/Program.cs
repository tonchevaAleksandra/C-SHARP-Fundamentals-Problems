using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int startPower = int.Parse(Console.ReadLine()); //when reach the target power reduces by the diff between the targets: example target 5->target 8- power-=3;
            int distTargets = int.Parse(Console.ReadLine());
            int minPower = int.Parse(Console.ReadLine());
            double originalValue = startPower * 0.50;

            int count = 0;
            while (startPower >= distTargets)
            {
                if (startPower == originalValue && minPower > 0)
                {
                    startPower /= minPower;
                    minPower = distTargets;
                    if(startPower<distTargets)
                    {
                        break;
                    }

                }
                startPower -= distTargets;
                count++;

            }

            Console.WriteLine(startPower);
            Console.WriteLine(count);



        }
    }
}
