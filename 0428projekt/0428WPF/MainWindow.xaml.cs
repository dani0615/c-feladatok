using _0428projekt;
using System.Windows;
using System.Windows.Controls;

namespace _0428WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string eredmeny= Program.LoadFromFile("fa.txt");
            if (eredmeny == "Sikeresen beolvasva")
            {
                dgrAdatok.ItemsSource = Program.csemetek; 
                dgrAdatok.Items.Refresh();
            }
            else
            {
                MessageBox.Show(eredmeny, "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}