using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string healthPattern = @"[^0-9+\-*\/.]";
            Regex healthRegex = new Regex(healthPattern);

            string digitPattern = @"-?\d+\.?\d*";
            Regex digitRegex = new Regex(digitPattern);

            string operatorsPattern = @"[*\/]";
            Regex operatorRegex = new Regex(operatorsPattern);

            string[] demonsNames = Regex.Split(Console.ReadLine(), @"\s*,\s*").OrderBy(x=>x).ToArray();
            for (int i = 0; i < demonsNames.Length; i++)
            {
                string currentDemon = demonsNames[i];
                int currentHealth = 0;
                MatchCollection healthSymbols = healthRegex.Matches(currentDemon);

                foreach (Match item in healthSymbols)
                {
                    currentHealth += char.Parse(item.Value);
                }

                MatchCollection digitMatch = digitRegex.Matches(currentDemon);
                double baseDamage = 0;
                foreach (Match number in digitMatch)
                {
                    baseDamage += double.Parse(number.Value);
                }

                MatchCollection operatorMatch = operatorRegex.Matches(currentDemon);

                foreach (Match operatorr in operatorMatch)
                {
                    string @operator = operatorr.Value;

                    if(@operator=="*")
                    {
                        baseDamage *= 2;
                    }
                    else
                    {
                        baseDamage /= 2;
                    }
                }
                Console.WriteLine($"{demonsNames[i]} - {currentHealth} health, {baseDamage:f2} damage");
            }

        }
    }
}
