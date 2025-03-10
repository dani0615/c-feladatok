using System;
using System.Collections.Generic;

namespace Sutinap
{
    class Program
    {
        public struct Sutinapok
        {
            public int napszam;
            public string szervezo;
            public string feladata;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Add meg a hónap számát");
            int honapszam = Convert.ToInt32(Console.ReadLine());
            string[] szervezok = { "Béla", "Juci", "Andris","Eleonóra","Jenő", "Zsófi" };
            Console.WriteLine(honapszam);
            int kivalaszott = HonapNapja(honapszam);

            Console.WriteLine($"A kivalasztott honap napja {kivalaszott}");
           


        }

        static int HonapNapja(int honapszam)
        {
            Random r = new Random();
            switch (honapszam)
            {
                case 1 : 
                    return r.Next(1, 32);
                   

                case 2: 
                    return r.Next(1, 29); 

                case 3: 
                    return r.Next(1, 32); 

                case 4: 
                    return r.Next(1, 31); 

                case 5:
                    return r.Next(1, 32); 

                case 6: 
                    return r.Next(1, 31); 

                case 7: 
                    return r.Next(1, 32); 

                case 8:
                    return r.Next(1, 32); 

                case 9: 
                    return r.Next(1, 31); 

                case 10: 
                    return r.Next(1, 32); 

                case 11: 
                    return r.Next(1, 31);

                case 12: 
                    return r.Next(1, 31);
            }
            return honapszam ;



        }
    }
}
