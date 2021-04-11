using System;

namespace VariablesE02
{
    class Program
    {
        static void Main(string[] args)
        {
            double num01;
            double num02;
            double num03;
            Console.WriteLine("Write a number down");
            num01 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Write another number down");
            num02 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Write another number down");
            num03 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The average is " + (num01 + num02 + num03)/3);
        }
    }
}
