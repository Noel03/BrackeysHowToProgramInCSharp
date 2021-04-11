using System;

namespace MethodsE06
{
    class Program
    {
        static void Main(string[] args)
        {
            meetAlien();
            Console.WriteLine("-----------");
            meetAlien();

        }
        static void meetAlien()
        {
            Random numberGen = new Random();

            string name = "X-" + numberGen.Next(10, 9999);
            int age = numberGen.Next(18, 500);
            Console.WriteLine("Hi I am " + name);
            Console.WriteLine("I am " + age + " years old.");
            Console.WriteLine("Oh yeah, I'm an alien.");
        }
    }
}
