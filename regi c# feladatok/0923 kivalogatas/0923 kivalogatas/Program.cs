using System;
using System.Collections.Generic;

namespace _0923_kivalogatas
{
    class Program
    {
        struct Ember
        {
           public string nev;
           public int szulev;
           public string vegzettseg;
        }

        static void Main(string[] args)
        {
            List<Ember> jelentkezok = new List<Ember>();
            #region Adatbevitel rész
            string valasz = "";
            
            do
            {
                Ember ujJelentkezok = new Ember();
                Console.WriteLine("Adja meg a jelentkező nevét");
                ujJelentkezok.nev = Console.ReadLine();

                Console.WriteLine("Adja meg a jelentkező születési évét:");
                do
                {
                    string ujEv = Console.ReadLine();
                    int ujEvSzam = 0;
                    if(int.TryParse(ujEv,out ujEvSzam))
                    {
                        ujJelentkezok.szulev = ujEvSzam;
                    }

                    else {
                        Console.WriteLine("Hibás évszám kérem adja meg újra!:"); 
                    }

                } while (ujJelentkezok.szulev == 0);

                
                Console.WriteLine("Adja meg a végzettségét:");

                do
                {
                    ujJelentkezok.vegzettseg = Console.ReadLine();
                    if (!HelyesVegzettseg(ujJelentkezok.vegzettseg))
                        Console.WriteLine("Nincs ilyen végzettségi kategória adja meg újra!");
                } while (!HelyesVegzettseg(ujJelentkezok.vegzettseg));

                jelentkezok.Add(ujJelentkezok);
                Console.WriteLine("Szeretne új jelentkezőt felvinni? [I/N] ");
                valasz = Console.ReadLine().ToLower();
                } while (valasz=="i");
            #endregion

            #region Kiválogatás
            //érettségivel rendelkezők kiválogatása
            List<Ember> erettsegizettek = new List<Ember>();

            foreach(var jelentkezo in jelentkezok)
            {
                if (Erettsegi(jelentkezo.vegzettseg))
                {
                    erettsegizettek.Add(jelentkezo);
                }
            }
            // az erettsegivel rendelkezők 
            foreach (var jelentekzo in erettsegizettek)
            {
                Console.WriteLine($"Név: {jelentekzo.nev} születesi év: {jelentekzo.szulev} legmagasabb végzettsége:  {jelentekzo.vegzettseg}" );
            }
            #endregion


        }
        #region vegzettseg
        public static bool HelyesVegzettseg(string vegzettseg)
        {
            if (vegzettseg == "főiskola vagy egyetem" || vegzettseg == "nincs nyolc általános" || vegzettseg == "érettségi" || vegzettseg == "nyolc általános")
                return true;
            return false;
        }
        #endregion 
        public static bool Erettsegi(string vegzettseg)
        {
            if (vegzettseg == "érettségi" || vegzettseg == "főiskola vagy egyetem")
                return true;

            return false;
        }




    }
}
