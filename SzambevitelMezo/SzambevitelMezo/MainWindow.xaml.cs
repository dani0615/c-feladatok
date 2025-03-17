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

namespace SzambevitelMezo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public static List<Pet> Pets = new List<Pet>();
        public MainWindow()
        {
            InitializeComponent();
            LoadFromFile("Pets.txt");
        }

        static void LoadFromFile(string filename)
        {
            Pets.Clear();
            string[] sorok = File.ReadAllLines(filename).Skip(1).ToArray();
            foreach (string sor in sorok)
            {
                Pets.Add(new Pet(sor));
            }
        }

        private void Felvetel_click(object sender, RoutedEventArgs e)
        {
            FelvetelWindow felvetelWindow = new FelvetelWindow();
            felvetelWindow.ShowDialog();

        }
    }
}