using NASA_Missions;
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


namespace LINQMuveletekWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //NASA_Missions-ből elérni a listát
        List<Kuldetes> kuldetesek = new List<Kuldetes>();

        public MainWindow()
        {
            InitializeComponent();
            Program.LoadFromFile("NASAmissions.txt");
            if (Program.kuldetesek.Count > 0)
            {
                MessageBox.Show("Sikeres betöltés");
            }
            else
            {
                MessageBox.Show("Úgy tűnik , nem sikerült a beolvasás","Figyelmeztetés",MessageBoxButton.OK,MessageBoxImage.Warning);
            }

            dgrKuldetesek.ItemsSource = Program.kuldetesek;
        }
    }
}