using System;

namespace BrackeysEP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Skynet";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Hello, what's your name");

            string name = Console.ReadLine();

            Console.WriteLine("Hi {0} My name is RX-9000.\nI'm an AI sent to destroy mind kind",name);

            Console.WriteLine("What is your favourite Colour?");

            string strColour = Console.ReadLine();

            Console.WriteLine("{0}? Well mine is destruction", strColour);
            Console.ReadKey();
        }
    }
}
