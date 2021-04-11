using System;

namespace ConditionsE03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Tickets are $5. Please insert cash.");
            int cash = Convert.ToInt32(Console.ReadLine());

            if (cash < 5)
            {
                Console.WriteLine("That's not enough");
            }
            else if (cash == 5)
            {
                Console.WriteLine("Here is your ticket");
            }
            else
            {
                int change = cash - 5;
                Console.WriteLine("Here is your ticket and ${0} in change", change);
            }
        }
    }
}
