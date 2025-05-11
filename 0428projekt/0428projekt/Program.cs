using System.Linq;
using System.IO;
namespace _0428projekt
{
    public class Program
    {
       public static List<Csemete> csemetek = new List<Csemete>();
        static void Main(string[] args)
        {
            LoadFromFile("fa.txt");
            foreach (Csemete c in csemetek)
            {
                Console.WriteLine($"Fajta: {c.Fajta}, Ár: {c.Ar}, Önbeporzó: {c.Onbeporzo}, Készlet: {c.Keszlet}, Kategória: {c.Kategoria()}");
            }
            Feladatok();



        }

        static string LoadFromFile(string FileName)
        {
            try
            {
                string[] sorok = File.ReadAllLines(FileName).Skip(1).ToArray();
                foreach (string sor in sorok)
                {
                    Csemete c = new Csemete(sor);
                    csemetek.Add(c);
                }
                return "Sikeresen beolvasva";
            }
            catch (Exception ex)
            {
                return $"Hiba a fájl beolvasásakor: {ex.Message}";
            }


        }

        static void Feladatok()
        {
            // 1. feladat Mennyibe kerul a legdragabb csemete
            Console.WriteLine($"A legdrágább csemete ára: {csemetek.Max(x => x.Ar)}");

            //2.feladat fickó 30 db egyforma gyümölcsfát szeretne venni , mely fajtákból van legalabb 30 darab linq
            List<Csemete> legalabb30 = csemetek.Where(x => x.Keszlet >= 30).ToList();
            Console.WriteLine("Fajták, amikből legalább 30 db van:");
            foreach (Csemete c in legalabb30)
            {
                Console.WriteLine(c.Fajta);
            }

            

        }
    }
}
