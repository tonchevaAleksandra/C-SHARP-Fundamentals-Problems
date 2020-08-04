using System;

using System.Text.RegularExpressions;

namespace SongEnxcryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(?<artist>[A-Z][[a-z\'\s]+):(?<song>[A-Z\s]+)$";
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string artist = match.Groups["artist"].Value;
                    int key = artist.Length;
                    string song = match.Groups["song"].Value;
                    string text = string.Concat(artist, "@", song);

                    for (int i = 0; i < text.Length; i++)
                    {
                        if (text[i] != ' ' && text[i] != '\'' && text[i] != '@')
                        {
                            char curr = new char();
                            if ((int)text[i] + key > 90 && ((int)text[i] ) <= 90)
                            {
                                curr = (char)(65 + (key - (90 - (int)text[i]) - 1));
                            }

                            else if ((int)text[i] + key <= 90)
                            {
                                curr = (char)((int)text[i] + key);
                            }
                            else if ((int)text[i] + key > 122)
                            {
                                curr = (char)(97 + (key - (122 - (int)text[i]) - 1));
                            }
                            else if ((int)text[i] + key <= 122 && (int)text[i] + key>=97)
                            {
                                curr = (char)((int)text[i] + key);
                            }
                            text = text.Remove(i, 1);
                            text = text.Insert(i, curr.ToString());


                        }

                    }

                    Console.WriteLine($"Successful encryption: {text}");

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }
        }
    }
}
