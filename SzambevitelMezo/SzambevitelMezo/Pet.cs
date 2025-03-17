using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzambevitelMezo
{
   public class Pet
    {
        public Pet(string nev, string faj, string fajta, string nem, string szin, DateTime szuletesiDatum, int suly, string? kedvencEtel, string? kedvencJatek)
        {
            Nev = nev;
            Faj = faj;
            Fajta = fajta;
            Nem = nem;
            Szin = szin;
            SzuletesiDatum = szuletesiDatum;
            Suly = suly;
            KedvencEtel = kedvencEtel;
            KedvencJatek = kedvencJatek;
        }

        public Pet(){}
        public string Nev { get; set; }
        public string Faj { get; set; }
        public string Fajta { get; set; }
        public string Nem { get; set; }
        public string Szin { get; set; }
        public DateTime SzuletesiDatum { get; set; }
        public int Suly { get; set; }
        public string? KedvencEtel { get; set; }
        public string? KedvencJatek { get; set; }


        /// <summary>
        /// A bemeneti állomány egy sorát feldolgozó konstruktor
        /// Név;Faj;Fajta;Nem;Szín;SzületésiDátum;Súly;KedvencÉtel;KedvencJáték az adatok sorrendje.
        /// </summary>
        /// <param name="sor">A bemeneti állomány egy sora ami adatok tartalmaz.</param>
        public Pet(string sor)
        {
            string[] adatok = sor.Split(';');
            Nev = adatok[0];
            Faj = adatok[1];
            Fajta = adatok[2];
            Nem = adatok[3];
            Szin = adatok[4];
            SzuletesiDatum = DateTime.Parse(adatok[5]);
            Suly = int.Parse(adatok[6]);
            KedvencEtel = adatok[7];
            KedvencJatek = adatok[8];
            
        }
        /// <summary>
        /// A házikedvenc életkora betölött születésnap alapján.
        /// </summary>
        /// <returns>Az életkor egész években</returns>
        public int Kor()
        {
            int eletkor =0;
            if (SzuletesiDatum.Month < DateTime.Today.Month)
                eletkor = DateTime.Now.Year - SzuletesiDatum.Year;
            else if (SzuletesiDatum.Month > DateTime.Now.Month)
                eletkor = DateTime.Now.Year - SzuletesiDatum.Year - 1;
            else
            {
                if(SzuletesiDatum.Day<= DateTime.Today.Day)
                    eletkor = DateTime.Now.Year - SzuletesiDatum.Year;
                else
                    eletkor = DateTime.Now.Year - SzuletesiDatum.Year -1;
            }
            return eletkor;

        }




    }
   
}
