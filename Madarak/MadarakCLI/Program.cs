using System.IO;
using System.Linq;
namespace MadarakCLI

{
    public class Program
    {
        public static List<Madar> madarak = new List<Madar>();
        static void Main(string[] args)
        {
            LoadFromFile("madarak.txt");

            Console.WriteLine($"A bemeneti állomány {madarak.Count()} madár adatait tartalmazza.");

            int gyurgyalagEv = madarak.FirstOrDefault(m => m.MagyarNev == "gyurgyalag").Ev;
            Console.WriteLine($"A gyurgyalg védett: {gyurgyalagEv} óta.");

            NevKereses();

            int legalabb500e = madarak.Where(x => x.Ertek > 500000).Count();
            Console.WriteLine($"{legalabb500e} madár eszmei értéke legalább 500000 Ft");

            int legkisebbErtek = madarak.Min(x => x.Ertek);

            




        }

        private static void NevKereses()
        {
            Console.WriteLine("Kérem adja meg a keresett madár magyar nevét:");
            string keresettMadarNev = Console.ReadLine();
            Madar keresettMadar = madarak.FirstOrDefault(m => m.MagyarNev == keresettMadarNev);
            if (keresettMadar != null)
            {
                Console.WriteLine($"Magyar név:{keresettMadarNev},latin neve:{keresettMadar.LatinNev}");
            }
            else
            {
                Console.WriteLine("A keresett madár nem található az adatbázisban.");
            }
        }

        public static void LoadFromFile(string FileName)
        {
            string[] sorok = File.ReadAllLines(FileName).Skip(1).ToArray();
            foreach (string sor in sorok)
            {
                Madar madar = new Madar(sor);
                madarak.Add(madar);
            }
        }
    }
}
