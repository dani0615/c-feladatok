using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EredmenyekWPF
{
    class Eredmeny
    {
        public int Sorszam { get; set; }
        public string Nev { get; set; }
        public int Pontszam1 { get; set; }
        public int Pontszam2 { get; set; }
        public int Pontszam3 { get; set; }

        public override string ToString()
        {
            return $" {Nev} ";
        }
    }


}
