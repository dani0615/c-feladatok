using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDoga
{
    public class Video
    {
        public int Helyezes { get; set; }
        public string Idotartam { get; set; }
        public string Eloado { get; set; }
        public string Cim { get; set; }
        public string Kiado { get; set; }
        public int Megtekintes { get; set; }

       public Video(string sor) 
        {
            string[] adatok = sor.Split(';');
            Helyezes = int.Parse(adatok[0]);
            Idotartam = (adatok[1]);
            Eloado = adatok[2];
            Cim = adatok[3];
            Kiado = adatok[4];
            Megtekintes = int.Parse(adatok[5]);

        }
    }
}
