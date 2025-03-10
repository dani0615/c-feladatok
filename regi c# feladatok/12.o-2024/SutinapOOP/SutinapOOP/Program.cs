using System;
using System.Collections.Generic;
namespace SutinapOOP
{


   public class SutinapInfo // Az osztály/ objektum úgynevezett hivatkozás típusú
    {
        // mezők (field) camelCase írásmód
        public int nap;
        public string sutis;
        public string teas;
       
        // tulajdonságok(property) PascalCase

        //metódusok(saját függvények és eljárások) PascalCase
        // kiemelt metódus a konstruktor. Feladata : létrehoz egy objektumot az osztályból a memóriában és ha kell, beállítja a kezdőértéket . Fontos szabály a konstuktor neve megegyezik az osztály nevével
        
        public SutinapInfo() { } // paraméter nélküli konstruktor nem állít be kezdőértéket 

        public SutinapInfo(int nap, string sutis, string teas) // paraméteres konstruktor kezdőértéket állít be 

        {
            this.nap = nap;
            this.sutis = sutis;
            this.teas = teas;
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
        }
    }
}
