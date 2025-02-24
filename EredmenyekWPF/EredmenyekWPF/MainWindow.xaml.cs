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
            EremInit();
        }

        /// <summary>
        /// Az adatok beolvasása a megadott fájlból.
        /// </summary>
        /// <param name="filePath"></param>
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

        /// <summary>
        /// A versenyzok neveit egyedinek tételezzük fel. A versenyző nevét kiválasztva a jobb oldali textboxokban betöltődnek a megfelelő adatok.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxNevek_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbxNevek.SelectedItem != null)
            {
                int index = 0;
                while (index < eredmenyek.Count && eredmenyek[index].Nev != lbxNevek.SelectedItem.ToString())
                {
                    index++;
                }
                tbxSorszam.Text = eredmenyek[index].Sorszam.ToString();
                tbxNev.Text = eredmenyek[index].Nev;
                tbx1Feladat.Text = eredmenyek[index].Pontszam1.ToString();
                tbx2Feladat.Text = eredmenyek[index].Pontszam2.ToString();
                tbx3Feladat.Text = eredmenyek[index].Pontszam3.ToString();
                int elsoPontArany = PontszamHely(1, 1);

                if (elsoPontArany == eredmenyek[index].Pontszam1)
                {
                    imgMedal1.Source = new BitmapImage(new Uri("Images/gold.jpg", UriKind.Relative));
                }
                else if (elsoPontArany == eredmenyek[index].Pontszam2)
                {
                    imgMedal1.Source = new BitmapImage(new Uri("Images/silver.jpg", UriKind.Relative));
                }
                else if (elsoPontArany == eredmenyek[index].Pontszam3)
                {
                    imgMedal1.Source = new BitmapImage(new Uri("Images/bronze.jpg", UriKind.Relative));
                }
                else
                {
                    imgMedal1.Source = new BitmapImage(new Uri("Images/empty.jpg", UriKind.Relative));

                }


            }
        }

        private static int PontszamHely(int helyezes , int feladat)
        {
            int eredmeny = -1;
            switch (feladat)
            {
                case 1:
                    int max = eredmenyek[0].Pontszam1;
                    foreach (Eredmeny v in eredmenyek)
                    {
                        if (v.Pontszam1 > max)
                        {
                            max = v.Pontszam1;
                        }
                    }
                    eredmeny = max;
                    break;
                case 2:

                  
                    break;
                case 3:
                   
                    break;
              
            }
            return eredmeny;
        }

        private void EremInit()
        {
            
            imgMedal1.Source=new BitmapImage(new Uri("Images/empty.jpg", UriKind.RelativeOrAbsolute));
            imgMedal2.Source = new BitmapImage(new Uri("Images/empty.jpg", UriKind.RelativeOrAbsolute));
            imgMedal3.Source = new BitmapImage(new Uri("Images/empty.jpg", UriKind.RelativeOrAbsolute));
        }
    }
}