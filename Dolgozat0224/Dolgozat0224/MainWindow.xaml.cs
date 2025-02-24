using Microsoft.Win32;
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

namespace Dolgozat0224
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
   
    public partial class MainWindow : Window
    {
        List<string> TxtSorok = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Megjelenit_click(object sender, RoutedEventArgs e)
        {
          
            int betoltendo = int.Parse(tbxSzam.Text);

            
            if (betoltendo > TxtSorok.Count)
            {
                betoltendo = TxtSorok.Count;
                MessageBox.Show("Nagyobb szám mint a sorok száma , összes sor betöltve", "Információ", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            
            string megjelenitettSzoveg = "";
            for (int i = 0; i < betoltendo; i++)
            {
                megjelenitettSzoveg += TxtSorok[i] + "\n";
            }
            tbkSorok.Text = megjelenitettSzoveg;

        }

        private void Betolt_click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                string filename = openFileDialog.FileName;
                TxtSorok = new List<string>(File.ReadAllLines(filename));
                MessageBox.Show("Sikeres beolvasás!");

            }

        }
    }
}