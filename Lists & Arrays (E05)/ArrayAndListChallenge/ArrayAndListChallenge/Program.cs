using System;
using System.Collections.Generic;

namespace ArrayAndListChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Console.WriteLine("Enter the words to be sorted, end by typing 'END'");
            List<string> words = new List<string>();
            while  (input != "END")
            {
                input = Console.ReadLine();
                if (input != "END")
                {
                words.Add(input);
                }
            }
            words.Sort();
            Console.WriteLine("\nHere are your words, sorted in alphabetical order");
            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
