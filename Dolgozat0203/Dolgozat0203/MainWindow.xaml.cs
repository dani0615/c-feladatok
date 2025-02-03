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

namespace Dolgozat0203
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       static List<Meres> meresek = new List<Meres>();
       List<string> Egyedi = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            LoadFromFile("meresek.csv");
            lbxDatum.Items.Clear();
            EgyediDatumok();
        }
        private void LoadFromFile(string fileName)
        {
            meresek.Clear();
            foreach (var sor in File.ReadAllLines(fileName).Skip(1).ToArray())
            {
                meresek.Add(new Meres(sor));
            }
          
        }

        private void EgyediDatumok()
        { 

            foreach (Meres meres in meresek)
            {
                string datumok = meres.Datum.ToShortDateString();
                if (!Egyedi.Contains(datumok))
                {
                    Egyedi.Add(datumok);
                    cbxDatumok.Items.Add(datumok);
                }
            }
        }
        private void cbxDatumok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbxDatumok.SelectedItem != null)
            {
                string valasztott = cbxDatumok.SelectedItem.ToString();
                lbxDatum.Items.Clear();

                foreach (Meres meres in meresek)
                {
                    if (meres.Datum.ToShortDateString() == valasztott)
                    {
                        lbxDatum.Items.Add(meres);
                    }
                }
            }
        }

        private void lbxDatum_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbxDatum.Items != null) {

                cbxDatumok.SelectedIndex = lbxDatum.SelectedIndex;

                Meres kivalasztott = (Meres)lbxDatum.SelectedItem;
                MessageBox.Show(kivalasztott.Minosites());

            }


        }



       
    }
}