using System;

namespace ArraysE05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] movies = {"Lord of the Rings","Interstellar","Spongebob"};
            for (int i = 0; i < movies.Length; i++)
            {
                int rank = i + 1;
                Console.WriteLine(rank + ". "+ movies[i]);
            }
        }
    }
}
