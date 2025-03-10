using System;

namespace Jarmuvek
{
    class Program
    {
        static void Main(string[] args)
        {
            Jarmu UjJarmu1 = new Jarmu();
            UjJarmu1.Hossz = 50;
            Console.WriteLine(UjJarmu1.Hossz);
            Console.WriteLine(UjJarmu1.ToString());
            Auto ujAuto1 = new Auto();
            ujAuto1.Marka = "Suzuki";
            ujAuto1.Tipus = "Vitara";
            ujAuto1.Uzeamanyag = "benzin";
            ujAuto1.Tomeg = 800;
            Console.WriteLine(ujAuto1.ToString()); 
            Console.WriteLine($"Súlyadó: {ujAuto1.Sulyado(200)}");
            Console.WriteLine($"Súlyadó általában:{(ujAuto1 as Jarmu).Sulyado(200)}");
            Console.ReadLine();
        }
    }
}
