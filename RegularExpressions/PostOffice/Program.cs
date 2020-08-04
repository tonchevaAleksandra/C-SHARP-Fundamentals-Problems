using System;
using System.Text.RegularExpressions;

namespace PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|");
            string firstPart = input[0];
            string secondPart = input[1];
            string thirdPart = input[2];
            string patternFirst = @"\w*?([#|$|%|*|&]{1})(?<capitalLetters>[A-Z]+)\1w*";

            Match capitalLArgs = Regex.Match(firstPart, patternFirst);
            string capitalLetters = capitalLArgs.Groups["capitalLetters"].Value;
            //MatchCollection asciiLenghtArgs = Regex.Matches(secondPart, patternSecond);
            for (int i = 0; i < capitalLetters.Length; i++)
            {
                char startLetter = capitalLetters[i];
                int ascii = startLetter;
                string secondPattern = $@"{ascii}:(?<length>[0-9][0-9])";
                Match secondReg = Regex.Match(secondPart, secondPattern);
                int length = int.Parse(secondReg.Groups["length"].Value);
                  string thirdPattern= $@"(?<=\s|^){startLetter}[^\s]{{{length}}}(?=\s|$)";
                Match thirdMatch = Regex.Match(thirdPart, thirdPattern);
                string word = thirdMatch.ToString();

                Console.WriteLine(word);
            }
        }
    }
}
