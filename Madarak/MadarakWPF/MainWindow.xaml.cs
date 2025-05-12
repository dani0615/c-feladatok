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
using MadarakCLI;
using Microsoft.Win32;

namespace MadarakWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Madar> madarak = new List<Madar>();
        public MainWindow()
        {
            InitializeComponent();
            Program.LoadFromFile("madarak.txt");
            dgrMadarak.ItemsSource = Program.madarak;
            dgrMadarak.Items.Refresh();
           
        }

        private void btnMentes_Click(object sender, RoutedEventArgs e)
        {
            
            if (dgrMadarak.SelectedItem != null)
            {
                Madar valasztottMadar = (Madar)dgrMadarak.SelectedItem;
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == true)
                {
                    File.WriteAllText(saveFileDialog.FileName,valasztottMadar.ToString());
                }
            }
            else
            {
                MessageBox.Show("Nincs menthető adat.");
            }


        }
    }
}