using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrodalomProjekt.Models
{
    class Kerdes
    {
        public Kerdes(string kerdesSzovege, string valaszA, string valaszB, string valaszC, string helyesValasz, string felhvalasz)
        {
            KerdesSzovege = kerdesSzovege;
            ValaszA = valaszA;
            ValaszB = valaszB;
            ValaszC = valaszC;
            HelyesValasz = helyesValasz;
            FelhValasz = felhvalasz;
        }

        public string KerdesSzovege { get; set; }
        public string ValaszA { get; set; }
        public string ValaszB { get; set; }
        public string ValaszC { get; set; }
        public string HelyesValasz { get; set; }
        public string FelhValasz { get; set; }

    }
}
