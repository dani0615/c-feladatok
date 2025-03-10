using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {

        static List<Noveny> novenyek = new List<Noveny>();
        static string[] hasznositasok = { "dísznövény", "gyümölcs", "sövényalkotó" };

        static void Main(string[] args)
        {
            bool fut = true;
            do
            {
                Console.Clear();
                Console.WriteLine("***** Faiskola Projekt *****\n");
                Console.WriteLine("Adatok felvitele");
                Console.WriteLine("1 Az adatok megadása egyenként");
                Console.WriteLine("2 Az adatok megadása egy sorban");
                Console.WriteLine("3 Az adatok beolvasása állomáynból");
                Console.WriteLine("4 Kilépés");
                Console.WriteLine("Adja meg a választott menüpont számát");
                string valasz = Console.ReadLine();

                switch (valasz)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("1 Az adatok megadása egybeként! ");
                        Console.Write("Faj: ");
                        string faj = Console.ReadLine();
                        Console.Write("Fajta: ");
                        string fajta = Console.ReadLine();
                        Console.WriteLine("Hasznosítása : ");
                        string haszn = Console.ReadLine();
                        while (!hasznositasok.Contains(haszn))
                        {
                            Console.Write($"A hasznositas csak a következő lehet: \n {string.Join(",", hasznositasok)} \n Kérem adja meg újból:");
                            haszn = Console.ReadLine();
                        }

                        Console.Write("Törzskönyvezés éve:");

                        int ev;
                        while (!int.TryParse(Console.ReadLine(), out ev))
                        {
                            Console.WriteLine("helytelen számformátum , kérem adja meg újból !");
                        }

                        novenyek.Add(new Noveny(faj, fajta, haszn, ev));
                        Console.WriteLine("A növényt sikeresen rögzítettük");
                        break;


                    case "2":
                        Console.Clear();
                        Console.WriteLine("2 Az adatok megadása egy sorban");
                        Console.WriteLine("kérem adja meg tabulátorral elválasztva aza adatokat:");
                        string adatok = Console.ReadLine();
                        novenyek.Add(new Noveny(adatok));
                        Console.WriteLine("Sikeres rögzítés. (Enterre tovább)");
                        Console.ReadLine();

                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("3 Az adatok beolvasása állományból");
                        Console.WriteLine("Adja meg az állomány nevét :");
                        string allomanynev = Console.ReadLine();
                        StreamReader beolvas = new StreamReader(allomanynev);

                        break;


                    case "4":
                        fut = false;

                        break;

                    default:
                        Console.WriteLine("Helytelen menüpont válassz 1-től 3-ig!");
                        Console.ReadLine();
                        break;
                }


            } while (fut);
            Console.WriteLine("Sikeres kilépés");
            Console.ReadLine();



        }
    }
}