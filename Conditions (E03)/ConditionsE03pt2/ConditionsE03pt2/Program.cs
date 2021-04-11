using System;

namespace ConditionsE03pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int height;

            Console.WriteLine("Write your age");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write your height");
            height = Convert.ToInt32(Console.ReadLine());

            //|| is the or sign
            //&& is the and sign
            if(age >= 18 && height >= 160)
            {
                Console.WriteLine("You can go on the ride");
            }
            else
            {
                Console.WriteLine("You can't go on the ride");
            }

        }
    }
}
