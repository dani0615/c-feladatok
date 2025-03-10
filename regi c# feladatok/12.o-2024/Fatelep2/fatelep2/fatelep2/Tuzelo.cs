using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fatelep2
{
   public class Tuzelo
    {
        int ar;
        double keszlet;
        string megnevezes;

        public Tuzelo(int ar, double keszlet, string megnevezes)
        {
            this.Ar = ar;
            this.Keszlet = keszlet;
            this.Megnevezes = megnevezes;
        }

        public int Ar { get => ar; set => ar = value; }
        public double Keszlet { get => keszlet; set => keszlet = value; }
        public string Megnevezes { get => megnevezes; set => megnevezes = value; }

        public Tuzelo(string sor)
        {
            string[] adatok = sor.Split(";");
            Ar = int.Parse(adatok[0]);
            Keszlet = double.Parse(adatok[1]);
            Megnevezes = adatok[2];
        }

        public override string ToString()
        {
            return $"Megnevezés: {megnevezes} \n" +
                   $"Ár: {ar} Ft/q \n" +
                   $"Készlet: {keszlet} q";

        }

        public int KeszletAr()
        {
            return (int)(keszlet * ar);
        }
    }
}
