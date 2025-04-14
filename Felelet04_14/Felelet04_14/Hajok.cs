using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felelet04_14
{
    public class Hajok
    {

        public string Osztaly { get; set; }
        public string Tipus { get; set; }
        public string Orszag { get; set; }
        public int AgyukSzama { get; set; }
        public int Kaliber { get; set; }
        public int Vizkiszoritas { get; set; }


        public Hajok(string sor)
        {
            string[] adatok = sor.Split(';');
            Osztaly = adatok[0];
            Tipus = adatok[1];
            Orszag = adatok[2];
            AgyukSzama = int.Parse(adatok[3]);
            Kaliber = int.Parse(adatok[4]);
            Vizkiszoritas = int.Parse(adatok[5]);
        }

    }

}
