using System;

namespace WordsInSentenceE06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write down a sentence: ");
            string sentence = Console.ReadLine();
            int count = wordCount(sentence);
            Console.WriteLine("There are {0} words in this sentence", count);
        }
        static int wordCount(string sentence)
        {
            int words = sentence.Split(' ').Length;
            return words;
        }
    }
}
