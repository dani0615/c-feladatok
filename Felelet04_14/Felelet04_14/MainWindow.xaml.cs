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

namespace Felelet04_14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public static List<Hajok> hajok = new List<Hajok>();

        public MainWindow()
        {
            InitializeComponent();
            LoadFromFile("adatok.txt");
            dataGrid.ItemsSource = hajok;
            Combofill(cbxSzures);    
        }

        private void LoadFromFile(string Filename)
        {
            string[] sorok = File.ReadAllLines(Filename).Skip(1).ToArray();
            foreach (string s in sorok)
            {
                hajok.Add(new Hajok(s));
            }
        }

        private void btnSzures_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Combofill(ComboBox cbxTarget)
        {

        }
    }
}