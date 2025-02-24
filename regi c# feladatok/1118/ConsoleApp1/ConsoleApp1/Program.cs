using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
       

    static void Main(string[] args)
    {
         List<Etel> etelek = new List<Etel>();

            Etel ujEtel = new Etel("2;burg;burger;900");

            string[] bemenet = File.ReadAllLines("etelek.txt");
            for (int i =1; i < bemenet.Length; i++)
            {
                etelek.Add(new Etel(bemenet[i]));
            }

            Etlap(etelek);
            Console.ReadLine();

               

         
    }
        /// <summary>
        /// Kiírja a kategória szerint csoportosítva az aktuális étellista alapján az étlapot.
        /// </summary>
        /// <param name="etellista">Az aktuális ételek listája</param>
        static void Etlap(List<Etel> etellista)
        {
            string[] kategoriak = { "hamburger", "leves", "főétel", "saláta", "desszert" };
            foreach (string kategoria in kategoriak)
            {
                Console.WriteLine(kategoria.ToUpper());
                foreach (Etel etel in etellista)
                {
                    if (etel.Kategoria== kategoria)
                        Console.WriteLine($"\t{etel.Megnevezes}: {etel.AkciosAr(AktualisHet())} Ft");
                }
                Console.WriteLine();
            }

        }
        static int AktualisHet()
        {
           return DateTime.Today.DayOfYear / 7 +1;
        }

}
    }

