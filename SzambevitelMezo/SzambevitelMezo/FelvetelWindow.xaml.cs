using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SzambevitelMezo
{
    /// <summary>
    /// Interaction logic for FelvetelWindow.xaml
    /// </summary>
    public partial class FelvetelWindow : Window
    {
        public FelvetelWindow()
        {
            InitializeComponent();
        }

        private void btnMegse_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void btnFelvetel_Click(object sender, RoutedEventArgs e)
        {
            // A kötelező mezők ellenőrzése HF
            //Ha kitöltöttek , akkor példányosítani kell egy Pet objektumot és hozzáadni a Pets listához , a főablakban
            Pet ujkedvenc = new Pet(tbxNev.Text,tbxFaj.Text,tbxFajta.Text,tbxNem.Text,tbxSzin.Text,DateTime.Parse(dpSzuletesiDatum.Text),int.Parse(tbxSuly.Text),tbxKedvencEtel.Text,tbxKedvencJatek.Text);
            MainWindow.Pets.Add(ujkedvenc);
            MessageBox.Show("sikeres felvétel.")
            
        }
    }
}
