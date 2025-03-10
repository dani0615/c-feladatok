using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisallatHotel
{
    class Kedvenc
    {
        DateTime bekerules;
        string cim;
        string faj;
        string fajta;
        string gazda;
        int napok;
        string nev;
        string telefon;

        public Kedvenc(DateTime bekerules, string cim, string faj, string fajta, string gazda, int napok, string nev, string telefon)
        {
            Bekerules = bekerules;
            Cim = cim;
            Faj = faj;
            Fajta = fajta;
            Gazda = gazda;
            Napok = napok;
            Nev = nev;
            Telefon = telefon;
        }

        public DateTime Bekerules { get => bekerules; set => bekerules = value; }
        public string Cim { get => cim; set => cim = value; }
        public string Faj { get => faj; set => faj = value; }
        public string Fajta { get => fajta; set => fajta = value; }
        public string Gazda { get => gazda; set => gazda = value; }
        public int Napok { get => napok; set => napok = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Telefon { get => telefon; set => telefon = value; }


        public Kedvenc(string sor)
        {
            string[] ertekek = sor.Split(";");
            Nev = ertekek[0];
            Faj = ertekek[1];
            Fajta = ertekek[2];
            Gazda = ertekek[3];
            Cim = ertekek[4];
            Telefon = ertekek[5];
            Bekerules = DateTime.Parse(ertekek[6]);
            Napok = int.Parse(ertekek[7]);
        }

        public int Osszeg(int nap)
        {
            return Napok * 2000;
        }


    



    }

    


    
}
