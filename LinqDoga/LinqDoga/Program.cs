namespace LinqDoga
{
    public class Program
    {
        public static List<Video> videok = new List<Video>();
        static void Main(string[] args)
        {
            LoadFromFile("ytlist.txt");

            double atlag = videok.Average(x => x.Megtekintes);
            double max = videok.Max(x => x.Megtekintes);
            double min = videok.Min(x => x.Megtekintes);
            string videocim = videok.Where(x=> x.Eloado == "Robin Schulz").First().Cim;

            Console.WriteLine("A videok megtekintésének átlaga: " + (int)atlag);
            Console.WriteLine($"A legtöbbször megtekintett videót :{max} alkalommal nézték meg.");
            Console.WriteLine($"A legkevesebbszer megtekintett videót:{min} alkalommal nézték meg.");
            Console.WriteLine("A Robin Schulztól szereplő videó: " + videocim);

            
                    
            foreach (Video video in videok)
            {   if(videok.Where(x=> x.Idotartam.StartsWith("2")).ToList().Count > 0)
                {
                    Console.WriteLine(video.Idotartam);
                }
            else
                {
                    Console.WriteLine("Nincs ilyen video");
                }
            }
        }

       public  static List<Video> LoadFromFile(string filename)
            {
            var videok = new List<Video>();
            string[] sorok = File.ReadAllLines("ytlist.txt").Skip(1).ToArray();
            foreach (string sor in sorok)
            {
                videok.Add(new Video(sor));
            }
            return videok;


        }
    }
}
