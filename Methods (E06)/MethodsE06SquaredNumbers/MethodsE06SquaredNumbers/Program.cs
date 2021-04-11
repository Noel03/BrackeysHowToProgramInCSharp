using System;

namespace MethodsE06SquaredNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            int num01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write another number: ");
            int num02 = Convert.ToInt32(Console.ReadLine());

            int result = Multiply(num01, num02);
            Console.WriteLine("The result is "+ result);

            //if the reminder is nothing when divided by 2
            if(result % 2 == 0)
            {
                Console.WriteLine("This is an even number");
            }
            else
            {
                Console.WriteLine("This is an odd number");
            }

        }
        static int Multiply(int number01, int number02)
        {
            int result = number01 * number02;
            return result;
        }
    }
}
