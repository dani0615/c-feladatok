using LinqDoga;
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


namespace LinqDogaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Video> videok = new List<Video>();
        public MainWindow()
        {
            InitializeComponent();
            videok =Program.LoadFromFile("ytlist.txt");
            dgrVideok.ItemsSource = videok;
        }
    }
}