using FileOpenSaveApplicationWPF.Models;
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
using System.IO;
using Microsoft.Win32;

namespace FileOpenSaveApplicationWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Auto> autok = new List<Auto>();

        public MainWindow()
        {
            InitializeComponent();
            
        }

        public void Beolvas(string filename)
        {
            try
            {
                foreach (string sor in File.ReadLines(filename).Skip(1).ToArray())
                {
                    autok.Add(new Auto(sor));
                }
            }
            catch (FileNotFoundException fnfex)
            {
                MessageBox.Show("A fájl nem található: \n" + fnfex.Message);
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Hibás formátum: \n" + fex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
            

        }

        private void Beolvasas_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialogq = new OpenFileDialog();
            openFileDialogq.Filter = "Szöveges állományok |*.txt";

            if (openFileDialogq.ShowDialog().Value)
            {
                  Beolvas(openFileDialogq.FileName);
                  lbAutok.Items.Clear();
                  lbAutok.ItemsSource = autok;

            }
            else
                MessageBox.Show("Nincw kiválasztott fájl!");

        }

        private void lbAutok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lbAutok.SelectedItem!= null)
            {
                Auto kivalasztott = (Auto)lbAutok.SelectedItem;
                tbxAzonosito.Text = kivalasztott.Id.ToString();
                tbxGyartmany.Text = kivalasztott.Marka;
                tbxTipus.Text = kivalasztott.Tipus;
                tbxSzin.Text = kivalasztott.Szin;
                tbxEvjarat.Text = kivalasztott.Evjarat.ToString();
                tbxMuszaki.Text = kivalasztott.Muszaki.ToString();
                ckxAktiv.IsChecked = kivalasztott.Aktiv;


            }
            else
                MessageBox.Show("Nincs kiválasztott elem!");


        }
    }
}