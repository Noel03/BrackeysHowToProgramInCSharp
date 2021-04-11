using System;

namespace LoopsE04Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGen = new Random();
            int roll01 = 1;
            int roll02 = 0;
            int attempts = 0;

            Console.WriteLine("Press enter to roll the dice.");

            while (roll01 != roll02)
            {
                Console.ReadKey();

                roll01 = numberGen.Next(1, 7);
                roll02 = numberGen.Next(1, 7);

                Console.WriteLine("Roll one: " + roll01);
                Console.WriteLine("Roll two: " + roll02 + "\n");
                attempts++;
            }
            switch (attempts)
            {
                case 1:
                    Console.WriteLine("That only took you one try. Lucky!");
                    break;
                default:
                    Console.WriteLine("That took you " + attempts + " attempts");
                    break;
            }
        }
    }
}
