using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadarakCLI
{
    public class Madar
    {
        public Madar(int ertek, int ev, string latinNev, string magyarNev, int sorszam)
        {
            Ertek = ertek;
            Ev = ev;
            LatinNev = latinNev;
            MagyarNev = magyarNev;
            Sorszam = sorszam;
        }

        public Madar()
        {
           
        }

        public Madar(string sor)
        {
            string[] adatok = sor.Split(';');
            Sorszam = int.Parse(adatok[0]);
            MagyarNev = adatok[1];
            LatinNev = adatok[2];
            Ertek = int.Parse(adatok[3]);
            Ev = int.Parse(adatok[4]);
        }

        public int Ertek { get; set; }
        public int Ev { get; set; }
        public string LatinNev { get; set; }
        public string MagyarNev { get; set; }

        public int Sorszam { get; set; }

    }
}
