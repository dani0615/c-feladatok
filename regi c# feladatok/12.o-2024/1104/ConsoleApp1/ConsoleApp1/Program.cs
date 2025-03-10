using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pizza> pizzak = new List<Pizza>();

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Megnevezés:");
                string megnevezes = Console.ReadLine();
                Console.WriteLine("ár:");
                int ar = int.Parse(Console.ReadLine());
                pizzak.Add(new Pizza(megnevezes, ar));
            }

            foreach(Pizza pizzas in pizzak)
            {
                Console.WriteLine(pizzas.ToString());
            }

        }
    }
}
