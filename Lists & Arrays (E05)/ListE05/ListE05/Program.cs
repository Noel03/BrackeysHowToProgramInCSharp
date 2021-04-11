using System;
using System.Collections.Generic;

namespace ListE05
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> shoppingList = new List <string> ();

            shoppingList.Add("Dreams");
            shoppingList.Add("Miracles");
            shoppingList.Add("dn");
            shoppingList.Add("21");
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }
            shoppingList.Remove("Dreams");
            shoppingList.RemoveAt(1);

            Console.WriteLine("--------");
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }
        }
    }
}
