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
            int sorokSzama = TxtSorok.Count;
            
            tbxSzam.Text = sorokSzama.ToString();
            int betoltendo = int.Parse(tbxSzam.Text);

            tbkSorok.Text = TxtSorok[betoltendo];









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