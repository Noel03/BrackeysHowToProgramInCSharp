using System;

namespace LoopsE04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("i = 0; i < 10; i++");
            //    before condition after
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("i = 1; i <= 10; i++");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("i = 10; i > 0; i--");
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
