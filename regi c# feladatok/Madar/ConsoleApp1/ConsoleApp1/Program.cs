using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Madar> madarak = new List<Madar>();
            madarak.Add(new Madar(1, "fecske", DateTime.Now, DateTime.Parse("2024.11.01"), "törött láb", "sínbe rögzítve"));

            madarak.Add(new Madar() 
            {
                id =2,
                faj="veréb",
                beerkezes=DateTime.Now,
                tavozas=DateTime.Parse("2024.12.23"),
                allapot="mérgezés",
                kezeles="komplex étrend"
            });
            
            Console.WriteLine("Kérem az azonosítót");
            string azonosito = Console.ReadLine();
            while (azonosito !="") {
                Madar madar1 = new Madar();
                // Console.WriteLine(madar1.ToString());
                // a madár adatainak rögzítése


                madar1.id = int.Parse(azonosito);
                Console.WriteLine("kérem a madár faját: ");
                madar1.faj = Console.ReadLine();
                Console.WriteLine("kérem az állapotát ");
                madar1.allapot = Console.ReadLine();
                Console.WriteLine("Kérem a bekerülés dátumát: ");
                madar1.beerkezes = DateTime.Parse(Console.ReadLine());
                // hozzáadom a listához
                madarak.Add(madar1);

              

                Console.WriteLine("Kérem az azonosítót! (üres értékre befejeződik a rögzítés.): ");
                azonosito = Console.ReadLine();
            }
            foreach (Madar madar in madarak)
            {

                Console.WriteLine($"A madár adatai:\n" +
                       $"faj:{madar.faj}\n" +
                       $"beérkezés :{madar.beerkezes}\n" +
                       $"állapot:{madar.allapot}");
                Console.WriteLine();
            }

            Console.ReadKey();
            foreach  (Madar madar in madarak)
            {
                Console.WriteLine(madar.ToString());
                Console.WriteLine();
            }
            Console.ReadKey();


            
        }
    }
    public class Madar
    {
        // tárolt adatok ---> adattagok vagy mezők vagy fields
        // az osztály saját változóit jelenti
        public int id;
        public string faj;
        public DateTime beerkezes;
        public DateTime tavozas;
        public string allapot;
        public string kezeles;


        // metódusok --> az adattagokkal végezhető műveleteket jelenti
        // az osztály saját függvényeit és eljárásaiti soroljuk ide
        public Madar(int id, string faj, DateTime beerkezes, DateTime tavozas, string allapot, string kezeles)
        {
            this.id = id;
            this.faj = faj;
            this.beerkezes = beerkezes;
            this.tavozas = tavozas;
            this.allapot = allapot;
            this.kezeles = kezeles;
        }

        public Madar() { }

        public override string ToString()
        {
            return $"A madár adatai:\n" +
                            $"faj:{faj}\n" +
                            $"beérkezés :{beerkezes}\n" +
                            $"állapot:{allapot}\n" +
                            $"távozás: {tavozas}\n " +
                            $"kezelés: {kezeles}";
        }   


    }
}
