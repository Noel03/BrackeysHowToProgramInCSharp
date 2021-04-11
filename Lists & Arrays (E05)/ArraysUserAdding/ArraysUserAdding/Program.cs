using System;

namespace ArraysUserAdding
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] movies = new string[4];

            Console.WriteLine("Put in 4 movies:");

            for (int i = 0; i < 4; i++)
            {
                movies[i] = Console.ReadLine();
            }
      

            Console.WriteLine("\nHere they are alphabetically:");
            Array.Sort(movies);

            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine(movies[i]);
            }
        }
    }
}
