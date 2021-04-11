using System;

namespace LoopsE04WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGen = new Random();
            int roll = 0;
            int attempts = 0;
            //   condition
            Console.WriteLine("Press enter to roll the die");
            while (roll != 6)
            {
                Console.ReadKey();
                Console.WriteLine("");
                roll = numberGen.Next(1,7);
                Console.WriteLine("You rolled: " + roll);
                attempts++;
            }
            switch (attempts)
            {
                case 1:
                    Console.WriteLine("That took only took one attempt, nice");
                    break;
                default:
                    Console.WriteLine("That took " + attempts + " attempts");
                    break;

            }
        }
    }
}
