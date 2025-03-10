using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Szoba
    {
        string szobaszam;
        int ferohely;
        int ar;
        bool premium;

        public string Szobaszam { get => szobaszam; set => szobaszam = value; }
        public int Ferohely { get => ferohely; set => ferohely = value; }
        public int Ar { get => ar; set => ar  = value; }
        public bool Premium { get => premium; set => premium = value; }

        public Szoba(string szobaszam, int ferohely, int ar, bool premium)
        {
            this.Szobaszam = szobaszam;
            this.Ferohely = ferohely;
            this.Ar = ar;
            this.Premium = premium;
        }
        /// <summary>
        /// Paraméterként egy sort kap amiven az értékek ;-vel elválasztva szerepelnek.
        /// </summary>
        /// <param name="sor"> string , ; -vel tagolt négy érték (szobaszam;férőhely;ár;prémium</param>
        public Szoba(string sor)
        {
            string[] ertekek = sor.Split(";");
            Szobaszam = ertekek[0];
            Ferohely = int.Parse(ertekek[1]);
            Ar = int.Parse(ertekek[2]);
            Premium = bool.Parse(ertekek[3]);
        }
        public override string ToString()
        {
            string pr = premium ? "igen" : "nem";

            return $"Szobaszám : {szobaszam} \n " +
                   $"Férőhelyek száma : {ferohely}\n " +
                   $"ár egy éjszakára : {ar} Ft \n" +
                   $"Prémium szoba : {pr}";
        }
    }
}
