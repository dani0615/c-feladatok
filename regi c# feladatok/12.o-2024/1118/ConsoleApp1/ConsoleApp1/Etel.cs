using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Etel
    {
       private int id;
       private string kategoria;
       private string megnevezes;
       private int ar;

        public Etel(int id, string kategoria, string megnevezes, int ar)
        {
            this.Id = id;
            this.Kategoria = kategoria;
            this.Megnevezes = megnevezes;
            this.Ar = ar;
        }

        public int Id { get => id; set => id = value; }
        public string Kategoria
        {
            get => kategoria;
            set
            {
                string[] elfogadott = { "hamburger", "leves", "főétel", "saláta", "desszert" };
                if (elfogadott.Contains(value))
                    kategoria = value;
                //az else ágban egy saját kivétel dobásával kezelhetnénk a problémát
            }
        }
        public string Megnevezes { get => megnevezes; set => megnevezes = value; }
        public int Ar
        {
            get => ar;
            set { if (value < 0)
                    ar = 1;
                else
                    ar = value;
            }

            // hármás operátorral ar = value < 0 ? 1 : value;

        }

        public Etel(string sor)
        {
            string[] ertekek = sor.Split(";");
            Id = int.Parse(ertekek[0]);
            Kategoria = ertekek[2];
            Megnevezes = ertekek[1];
            Ar = int.Parse(ertekek[3]);
        }

        public override string ToString()
        {
            return $"Megnevezés: {megnevezes}\n" +
                   $"Kategória: {kategoria}\n" +
                   $"Ár: {ar}";
        }

        public string Akcios(int het)
        {

            if (het % 2 == 0)
            {
                return "leves";

            }
            else
            {
                return "desszert";
            }
            
        }
        public int AkciosAr(int het)
        {
            double kedvezmeny = 5; // kedvevzmény %-ban
            if (Akcios(het) == Kategoria  )
                return (int)Math.Floor(Ar*(100-kedvezmeny)/100);
            else
                return Ar;
        }
    }
}
