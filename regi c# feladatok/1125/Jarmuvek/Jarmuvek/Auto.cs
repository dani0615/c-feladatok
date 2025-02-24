using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek
{
    class Auto : Jarmu
    {
        public string Tipus { get; set; }
        public int GyarasiEv { get; set; }
        public string  Uzeamanyag { get; set; }




        public override string ToString()
        {
            return $"Márka:{Marka}, Típus : {Tipus}\nÜzemanyag :{Uzeamanyag}";
        }
        public int Sulyado(int adoMertek)
        {
            if (Tomeg < 1000)
                return 0;
            else
                return (int)Math.Round(Tomeg * adoMertek, 0);
        }
    }
}
