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

namespace SzambevitelWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void Hozzaad_click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tbxSzam.Text, out int db))
            {
                if (db >= 1 && db <= 20)
                {
                    grCheckboxok.Children.Clear();
                    bool jelolt = rbtJelolt.IsChecked == true;
                    for (int i = 0; i < db; i++)
                    {
                        CheckBox newCheckbox = new()
                        {
                            Content = $"CheckBox {i + 1}", 
                            IsChecked = jelolt, 
                            Margin = new Thickness(5, i * 20 + 5, 5, 5), 
                            HorizontalAlignment = HorizontalAlignment.Center,
                            VerticalAlignment = VerticalAlignment.Top
                        };
                        grCheckboxok.Children.Add(newCheckbox);

                    }
                }
                else
                {
                    MessageBox.Show("Határon kívüli szám");
                }

            }
            else
            {
                MessageBox.Show("Nem megfelelő számformátum");
            }

        }

        private void rbtJelolt_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void tbxSzam_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!int.TryParse((sender as TextBox).Text, out int eredmeny))
            {
                MessageBox.Show("Nem megfelelő számformátum.");
                (sender as TextBox).Text = "0";

            }
        }
        private void Kilepes_click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Biztosan ki akarsz lépni?", "Kilépés", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}