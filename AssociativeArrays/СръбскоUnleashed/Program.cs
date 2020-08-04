using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Srubsko
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Singer>> singers = new Dictionary<string, List<Singer>>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArgs = input.Split(" @");
                   
                if (inputArgs.Length < 2)
                {
                    continue;
                }

                string[] build = inputArgs[0].Trim().Split();
                if (build.Length > 3)
                {
                    continue;
                }
                string[] chackInts = input.Split().TakeLast(2).ToArray();
                if (!((char.IsDigit(chackInts[0][0])) && char.IsDigit(chackInts[1][0])))
                {
                    continue;
                }
                string name = inputArgs[0];

                string[] concertData = inputArgs[1].Split();
                long price =long.Parse(concertData[concertData.Length-2]);
                long count = long.Parse(concertData[concertData.Length-1]);
                long totalPrice = price * count;
                string venue;
                StringBuilder location = new StringBuilder();
                for (int i = concertData.Length - 3; i >= 0; i--)
                {
                    location.Insert(0, concertData[i] + " ");
                }
                   
                string[] town = location.ToString().Trim().Split();
                if (town.Length > 3 )
                {
                    continue;
                }
                venue = location.ToString().Trim();
                Singer current = new Singer(name, totalPrice);

                if (!singers.ContainsKey(venue))
                {
                    List<Singer> curr = new List<Singer>();
                    curr.Add(current);
                    singers.Add(venue, curr);
                }
                else
                {
                    bool isFound = false;
                    isFound = CheckForTheSinger(singers, name, venue, current, isFound);
                    if (!isFound)
                    {
                        singers[venue].Add(current);
                    }
                }
            }

            PrintResult(singers);
        }

        private static bool CheckForTheSinger(Dictionary<string, List<Singer>> singers, string name, string venue, Singer current, bool isFound)
        {
            foreach (var item in singers[venue])
            {
                if (item.Name == name)
                {
                    long currPrice = item.TotalPrice;
                    current.TotalPrice += currPrice;
                    singers[venue].Remove(item);
                    singers[venue].Add(current);
                    isFound = true;
                    break;
                }
            }

            return isFound;
        }

        private static void PrintResult(Dictionary<string, List<Singer>> singers)
        {
            foreach (var item in singers)
            {
                Console.WriteLine($"{item.Key}");

                foreach (var data in item.Value.OrderByDescending(x => x.TotalPrice))
                {
                    Console.WriteLine($"#  {data.Name} -> {data.TotalPrice}");
                }
            }
        }      
    }


    class Singer
    {
        public string Name { get; set; }
        public long TotalPrice { get; set; }


        public Singer(string name, long totalPrice)
        {
            this.Name = name;
            this.TotalPrice = totalPrice;
        }
    }
}
