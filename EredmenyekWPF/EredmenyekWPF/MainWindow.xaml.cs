using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EredmenyekWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Eredmeny> eredmenyek = new List<Eredmeny>();
        public MainWindow()
        {
            InitializeComponent();
            lbxNevek.Items.Clear();
            LoadFromFile("Eredmenyek.txt");
            lbxNevek.ItemsSource = eredmenyek;
        }
        static void LoadFromFile(string filePath)
        {

            try
            {

                string[] sorok = File.ReadAllLines(filePath, Encoding.Default);

                foreach (string sor in sorok)
                {
                    string[] adatok = sor.Split(';');
                    eredmenyek.Add(new Eredmeny()
                    {
                        Sorszam = int.Parse(adatok[0]),
                        Nev = adatok[1],
                        Pontszam1 = int.Parse(adatok[2]),
                        Pontszam2 = int.Parse(adatok[3]),
                        Pontszam3 = int.Parse(adatok[4])
                    });
                }
                /*
                foreach (string sor in sorok)
                {
                    eredmenyek.Add(new Eredmeny(sor));
                }
                */
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba az adatok beolvasásakor!");
                throw;
            }
            

        }
        

        private void lbxNevek_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}