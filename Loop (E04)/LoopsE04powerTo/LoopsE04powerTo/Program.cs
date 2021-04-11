using System;

namespace LoopsE04powerTo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers to you want to be squared: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {

                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }
        }
    }
}
