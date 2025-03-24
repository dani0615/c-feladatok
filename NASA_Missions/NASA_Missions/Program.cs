using System.IO;
namespace NASA_Missions
{
    public class Program
    {
       public static List<Kuldetes> kuldetesek = new List<Kuldetes>();
        static void Main(string[] args)
        {
            Console.WriteLine("Szeva, World!");
            LoadFromFile("NASAmissions.txt");
            Console.WriteLine($"3.feladat : {kuldetesek.Count} db sikeres kuldetes volt ");
            //max költséges küldetés
            double max = kuldetesek.Max(x => x.Koltseg);
            Console.WriteLine($"4.feladat : A legdrágább küldetés költsége: {max} milliárd dollár");

            //szűrés adott tulajdonságra pl. küldetés neve alapján keresünk , mekkora volt a hasznos teher LINQ
            Console.WriteLine(kuldetesek.Where(x => x.Nev == "Hubble Űrtávcső").First().HasznosTeher);

            // első találatot adja vissza
            if(kuldetesek.FirstOrDefault(x => x.Nev == "Hubble Űrtávcső")!=null)
                Console.WriteLine(kuldetesek.FirstOrDefault(x=> x.Nev=="Hubble Űrtávcső").HasznosTeher);
            else
                Console.WriteLine("Nincs ilyen nevű küldetés");

            //adott tulajdonságú elemek mindegyikét szűrhetjük pl. Az összes Apollo küldetés költsége kell
            foreach(Kuldetes kuldetes in kuldetesek.Where(x => x.Nev.Contains("Apollo")).ToList())
            {
                Console.WriteLine(kuldetes.Koltseg);
            }
            Console.WriteLine($"Az Apollo küldetések összköltsége: {kuldetesek.Where(x => x.Nev.Contains("Apollo")).Sum(x => x.Koltseg)}");

            //válogatás azok a küldetések ahol a legénység száma nagyobb mint 3
            Console.WriteLine("Küldetések ahol a legénység száma több mint 3:");
            foreach (Kuldetes kuldetes in kuldetesek.Where(x=> x.Legenyseg > 3 ).ToList())
            {
                Console.WriteLine(kuldetes.Nev);
            }


        }

       public static void LoadFromFile(string Filename) 
        {
            string[] sorok = File.ReadAllLines(Filename).Skip(1).ToArray();
            foreach (var sor in sorok)
            {
                kuldetesek.Add(new Kuldetes(sor));
            }

        }
    }
}
