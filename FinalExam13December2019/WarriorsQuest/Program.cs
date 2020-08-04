using System;
using System.Linq;
using System.Text;

namespace WarriorsQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder skill = new StringBuilder(Console.ReadLine());

            string input;
            while ((input = Console.ReadLine()) != "For Azeroth")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];

                switch (command)
                {

                    case "GladiatorStance":
                        skill = new StringBuilder(skill.ToString().ToUpper());
                        Console.WriteLine(skill);
                        break;

                    case "DefensiveStance":
                        skill = new StringBuilder(skill.ToString().ToLower());
                        Console.WriteLine(skill);
                        break;

                    case "Dispel":
                        skill = Dispel(skill, cmdArgs);
                        break;

                    case "Target":
                        skill = Target(skill, cmdArgs);
                        break;

                    default:
                        Console.WriteLine("Command doesn't exist!");
                        break;

                }
            }
        }

        private static StringBuilder Target(StringBuilder skill, string[] cmdArgs)
        {
            switch (cmdArgs[1])
            {
                case "Change":
                    skill = TargetChange(skill, cmdArgs);
                    break;

                case "Remove":
                    skill = Remove(skill, cmdArgs);
                    break;

                default:
                    Console.WriteLine("Command doesn't exist!");
                    break;

            }

            return skill;
        }

        private static StringBuilder Remove(StringBuilder skill, string[] cmdArgs)
        {
            string substring = cmdArgs[2];
            if (skill.ToString().Contains(substring))
            {
                int index = skill.ToString().IndexOf(substring);
                skill = skill.Remove(index, substring.Length);
                Console.WriteLine(skill);
            }

            return skill;
        }

        private static StringBuilder TargetChange(StringBuilder skill, string[] cmdArgs)
        {
            string substring = cmdArgs[2];
            if (skill.ToString().Contains(substring))
            {
                string secondSubstring = cmdArgs[3];
                skill = skill.Replace(substring, secondSubstring);
                Console.WriteLine(skill);
            }

            return skill;
        }

        private static StringBuilder Dispel(StringBuilder skill, string[] cmdArgs)
        {
            int index = int.Parse(cmdArgs[1]);
            char letter = char.Parse(cmdArgs[2]);

            if (index >= 0 && index < skill.Length)
            {
                skill = skill.Replace(skill[index], letter, index, 1);      
                Console.WriteLine("Success!");
            }

            else
            {
                Console.WriteLine("Dispel too weak.");
            }

            return skill;
        }
    }
}
