using System;

namespace ConditionsE03Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("15 + 2 * 2 = ");
            int qOne = Convert.ToInt32(Console.ReadLine());
            if (qOne == 19)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
            Console.Write("10 * 2 / 4 = ");
            int qTwo = Convert.ToInt32(Console.ReadLine());
            if (qTwo == 5)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
            Console.Write("(4 + 3 + 2 + 1) / 2 = ");
            int qThree = Convert.ToInt32(Console.ReadLine());
            if (qThree == 5)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
