using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static List<Szoba> szobak = new List<Szoba>();

        static void Main(string[] args)

        {
            szobak.Add(new Szoba("012", 3, 23000, true));
            bool fut = true;
            do
            {
                Console.WriteLine("**** Szobák adatai ****");
                Console.WriteLine("1. Rögzített szobák adatainak listjá");
                Console.WriteLine("2. Szobák adatainak beolvasása állományból ");
                Console.WriteLine("3. Új szoba adatainak felvitele");
                Console.WriteLine("4. Kilépés");
                Console.WriteLine("\n Adja meg a válaszott menüpont sorszámát");
                string menupont = Console.ReadLine();
                switch (menupont)
                {

                    case "1":
                        SzobaListaja();
                        break;


                    case "2":
                        Console.Clear();
                        Console.WriteLine("Beolvasás állományból");
                        Console.Write("Kérem adja meg az állomány nevét: ");
                        string fileName = Console.ReadLine();
                        string[] sorok = File.ReadAllLines(fileName);
                        foreach (string sor in sorok)
                        {
                            szobak.Add(new Szoba(sor));
                        }

                        break;



                    case "3":
                        Ujszobafelvetel();
                        break;



                    case "4":
                        Console.Clear();
                        Console.WriteLine("Sikeres kilépés");
                        fut = false;
                        Console.ReadKey();
                        break;



                    default:
                        Console.WriteLine("Nincs ilyen menüpont! Kérem válasszon újra !");
                        Console.ReadKey();
                        break;
                }

            } while (fut);


        }

        private static void SzobaListaja()
        {
            /*foreach (Szoba szoba in szobak)
            {
                Console.WriteLine($"A szobák adatai : \n" +
                    $"Szobaszám:{szoba.Szobaszam}\n" +
                    $"Férőhely:{szoba.Ferohely}\n " +
                    $"Ár:{szoba.Ar}\n" +
                    $"Prémium : {szoba.Premium}\n");
            }
            */
            foreach (Szoba szoba in szobak)
                Console.WriteLine(szoba.ToString());
        }

        private static void Ujszobafelvetel()
        {
            Console.Write("Szobaszám: ");
            string szobaszam = Console.ReadLine();

            Console.Write("Férőhelyek száma: ");
            int ferohely = int.Parse(Console.ReadLine());

            Console.Write("Ár egy éjszakára: ");
            int ar = int.Parse(Console.ReadLine());

            Console.Write("Prémium ? [i/n]: ");
            string premium = Console.ReadLine().ToLower();
            bool premiumErtek = premium == "i" ? true : false;
            szobak.Add(new Szoba(szobaszam, ferohely, ar, premiumErtek));
        }

        
}
    }

