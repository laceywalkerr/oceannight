using System;
using System.IO;

namespace OceanNight
{
    class Program
    {
        static void Main(string[] args)
        {
            // transform a bunch of text into a list of words

            // read text from the file
            string[] lines = File.ReadAllLines(@"theoceannight.txt");
            var text = string.Join("", lines);
            // Console.WriteLine(text);
            var words = text.ToLower().Split(" ");

            var frequencies = new Dictionary<string, int>();

            // print the list of words and counts
            foreach (var word in words)
            {
                if (frequencies.ContainsKey(word))
                {
                    frequencies[word] += 1;
                }
                else
                {
                    frequencies.Add(word, 1);
                }

                // Console.WriteLine(word);
            }
            // Console.WriteLine(words.Length);

            var topTen = frequencies.OrderByDecending(f => f.Value).Take(10);
            foreach (var word in topTen)
            {
                Console.WriteLine($"{word.Key} {word.Value}");
            }

        }
    }
}