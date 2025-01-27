using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek
{
    class Jarmu
    {
       public string Marka { get; set; }
       public double Hossz { get; set; }
       public double Magassag { get; set; }
       public double Szelesseg { get; set; }
       public double Tomeg { get; set; }


        public override string ToString()
        {
            return $"Márka : {Marka}\n" +
                $"Méretek:{Hossz}x{Magassag}x{Szelesseg} m";

               
        }
        public int Sulyado(int adoMertek)
        {
            
                return (int)Math.Round(Tomeg * adoMertek, 0);
        }

    }
}
