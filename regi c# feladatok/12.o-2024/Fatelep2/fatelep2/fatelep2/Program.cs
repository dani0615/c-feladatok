using System;
using System.Collections.Generic;

namespace fatelep2
{
    class Program
    {
        static List<Tuzelo> Tuzeloanyag = new List<Tuzelo>()
        {
            new Tuzelo(60000, 350,"Kacolai barnaszén"),
            new Tuzelo(150000,70,"lengyel feketeszén"),
            new Tuzelo(54000,250,"méteres keményfa")
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Új tüzelőanyag felvitele");
            Console.WriteLine("Megnevezés: ");
            string megnevezes = Console.ReadLine();
            Console.WriteLine("Ár(Ft/q): ");
            int ar = int.Parse(Console.ReadLine());
            Console.WriteLine("Készlet:");
            double keszlet = double.Parse(Console.ReadLine());
            Tuzeloanyag.Add(new Tuzelo(ar, keszlet, megnevezes));


            int osszErtek = 0;
            foreach (Tuzelo tuzelo in Tuzeloanyag)
            {
                osszErtek += tuzelo.KeszletAr();
            }
            Console.WriteLine($"A telepen lévő áruk összértéke: {osszErtek} Ft.");

            foreach(Tuzelo tuzelo in Tuzeloanyag)
            {
                if (tuzelo.Keszlet < 100)
                {
                    Console.WriteLine(tuzelo.ToString());
                }
            }


            


        }

    }
}
