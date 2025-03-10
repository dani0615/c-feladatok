using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pizza
    {
        string megnevezes;
        int ar;

        public Pizza(string megnevezes, int ar)
        {
            this.Megnevezes = megnevezes;
            this.Ar = ar;
        }

        public string Megnevezes { get => megnevezes; set => megnevezes = value; }
        public int Ar { get => ar; set => ar = value; }

        public override string ToString()
        {
            return $"Megnevezes : {Megnevezes} \n" +
                   $"Ár: {Ar}";
        }
    }
}
