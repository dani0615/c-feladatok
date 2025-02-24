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
using IrodalomProjekt.Models;
using Microsoft.Win32;

namespace IrodalomProjekt
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
   
    public partial class MainWindow : Window
    {
        private static List<Kerdes> kerdesek = new List<Kerdes>();
        private static int aktKerdesIndex = 0;

        public MainWindow()
        {
            InitializeComponent();
           
        }

        private static void KerdesekBetoltese(string filename)
        {
            kerdesek.Clear();
            try
            {
                StreamReader sr = new StreamReader(filename, Encoding.UTF8);
                while (!sr.EndOfStream)
                {
                    string kerdesSzovege = sr.ReadLine();
                    string valaszA = sr.ReadLine();
                    string valaszB = sr.ReadLine();
                    string valaszC = sr.ReadLine();
                    string utolsoSorLine = sr.ReadLine();
                    if (utolsoSorLine == null)
                        break; 
                    string[] utolsoSor = utolsoSorLine.Split(' ');
                    string helyesValasz = utolsoSor[2];
                    kerdesek.Add(new Kerdes(kerdesSzovege, valaszA, valaszB, valaszC, helyesValasz));
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Betoltes1_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    KerdesekBetoltese(openFileDialog.FileName);
                    MessageBox.Show("Sikeres betöltés!","informacio",MessageBoxButton.OK,MessageBoxImage.Information);
                    if (kerdesek.Count > 0)
                    {
                        aktKerdesIndex = 0;
                        Mutatkerdes(aktKerdesIndex);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                
            }
        }
        private void Mutatkerdes(int aktKerdesIndex) 
        {
            if (kerdesek.Count == 0)
                return;

            Kerdes aktualisKerdes = kerdesek[aktKerdesIndex];
         
            tbkKerdesSzovege.Text = aktualisKerdes.KerdesSzovege;
            ValaszA.Content = aktualisKerdes.ValaszA;
            ValaszB.Content = aktualisKerdes.ValaszB;
            ValaszC.Content = aktualisKerdes.ValaszC;

            
            ValaszA.IsChecked = false;
            ValaszB.IsChecked = false;
            ValaszC.IsChecked = false;

            if (aktualisKerdes.FelhValasz == "A") ValaszA.IsChecked = true;
            else if (aktualisKerdes.FelhValasz == "B") ValaszB.IsChecked = true;
            else if (aktualisKerdes.FelhValasz == "C") ValaszC.IsChecked = true;

        }
       

        private void Elozo_Click(object sender, RoutedEventArgs e)
        {
            if (aktKerdesIndex > 0)
            {
                aktKerdesIndex--;
                Mutatkerdes(aktKerdesIndex);
            }
            else
            {
                MessageBox.Show("Nincs előző kérdés!", "Figyelmeztetés", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
       
        private void Kovetkezo_click(object sender, RoutedEventArgs e)
        {
            if (aktKerdesIndex < kerdesek.Count - 1)
            {
                aktKerdesIndex++;
                Mutatkerdes(aktKerdesIndex);
            }
            else
            {
                MessageBox.Show("Nincs több kérdés!", "Figyelmeztetés", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Kilepes_click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Kiszeretnél lépni a programból?", "Megerősítés", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        
       private void Mentes_Click(object sender, RoutedEventArgs e)
       {

            if(aktKerdesIndex < kerdesek.Count)
            {
                Kerdes aktualisKerdes = kerdesek[aktKerdesIndex];
                if (ValaszA.IsChecked == true)
                {
                    aktualisKerdes.FelhValasz = "A";
                }
                else if (ValaszB.IsChecked == true)
                {
                    aktualisKerdes.FelhValasz = "B";
                }
                else if (ValaszC.IsChecked == true)
                {
                    aktualisKerdes.FelhValasz = "C";
                }
                

            }
            if (ValaszA.IsChecked != true && ValaszB.IsChecked != true && ValaszC.IsChecked != true)
            {
                MessageBox.Show("Kérlek, válassz egy választ!", "Figyelmeztetés", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            MessageBox.Show("Sikeres mentés!", "informacio", MessageBoxButton.OK, MessageBoxImage.Information);
            
        }
               
       private void Kiertekeles_click(object sender, RoutedEventArgs e)
       {
            MessageBox.Show("// Nem elérhető funkció! //", "Figyelmeztetés", MessageBoxButton.OK, MessageBoxImage.Warning);

        }

    }
}