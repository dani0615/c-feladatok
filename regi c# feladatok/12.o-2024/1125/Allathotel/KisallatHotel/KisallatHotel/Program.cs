using System;
using System.Collections.Generic;
using System.IO;

namespace KisallatHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kedvenc> allatok = new List<Kedvenc>();
            string[] bemenet = File.ReadAllLines("kiasallatok.txt");
            int darab = 0;
            for (int i = 1; i < bemenet.Length; i++)
            {
                allatok.Add(new Kedvenc(bemenet[i]));
                darab++;
            }
            Console.WriteLine($"Az állományban {darab} állat adatai szerepelnek.");

            Console.WriteLine();

            Console.WriteLine($"Az adatsor {AllatDarabszam(allatok)} kutya adatait tartalmazza");
            Console.WriteLine();

            KeresettAllat(allatok);



            /* foreach (string sor in bemenet)
              {
                  allatok.Add(new Kedvenc(sor));
              }
            */
            static int AllatDarabszam(List<Kedvenc> allatok)
            {
                int darabszam = 0;
                foreach (Kedvenc allat in allatok)
                {
                    if (allat.Faj == "kutya")
                    {
                        darabszam++;
                    }
                }
                return darabszam;
            }



        }

        private static void KeresettAllat(List<Kedvenc> allatok)
        {
            int nap=0 ;

            Console.WriteLine("Kérem adja meg a kisállat nevét: ");
            string neve = Console.ReadLine();
            foreach (Kedvenc allat in allatok)
            {
                if (allat.Nev == neve)
                {
                    Console.WriteLine($"Név:{allat.Nev}\nBekerült:{allat.Bekerules}\nFizetendő összeg: {allat.Osszeg(nap)}Ft ");
                    break;
                }
                else
                    Console.WriteLine("Nem találtam ilyen nevű kedvencet.");
                    
            }
        }
    }
}
