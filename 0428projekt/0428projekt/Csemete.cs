using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0428projekt
{
    public  class Csemete
    {
        public string Fajta { get; set; }
        public int Ar { get; set; }
        public bool Onbeporzo { get; set; }
        public int Keszlet { get; set; }

        public Csemete(string sor)
        {
            string[] t = sor.Split(';');
            Fajta = t[0];
            Ar = int.Parse(t[1]);
            Onbeporzo = (t[2])=="1";
            Keszlet = int.Parse(t[3]);

        }
        public Csemete() { }

        public string Kategoria()

        {
             //keszlet < 25 kritikus
             //5<25 normal
             //25> telített

            if(Keszlet > 25)
            {
                return "telített";
            }
            else if (Keszlet < 5)
            {
                return "kritikus";
            }
            else
            {
                return "normal";
            }


        }


    }
}
