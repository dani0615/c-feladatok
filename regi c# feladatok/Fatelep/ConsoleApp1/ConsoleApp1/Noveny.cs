using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Noveny
    {
        //mezők az osztály saját változói. Hívjuk az adattagoknak is.
        string faj;
        string fajta;
        string hasznositasa;
        int torzskonyvezesEve;

        /// <summary>
        /// Minden mező értéke külön paraméterben
        /// </summary>
        /// <param name="faj"></param>
        /// <param name="fajta"></param>
        /// <param name="hasznositasa"></param>
        /// <param name="torzskonyvezesEve"></param>
    

        public Noveny(string faj, string fajta, string hasznositasa, int torzskonyvezesEve)
        {
            this.faj = faj;
            this.fajta = fajta;
            this.hasznositasa = hasznositasa;
            this.torzskonyvezesEve = torzskonyvezesEve;
        }

        /// <summary>
        /// A mezők értéke egyetlen stringként érkezik. A stringet feldaraboljuk tabulátorok mentén.
        /// </summary>
        /// <param name="sor">Tabulátorokkal tagolt szöveg</param>

        public Noveny(string sor)
        {
            string[] adatok = sor.Split('\t');
            faj = adatok[0];
            fajta = adatok[1];
            hasznositasa = adatok[2];
            torzskonyvezesEve = int.Parse(adatok[3]);
        }


    }

    
}
