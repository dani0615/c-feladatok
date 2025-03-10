using Microsoft.Win32;
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

namespace Orai_03._10
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tbxSzam.Text, out int db))
            {
                if (db >= 1 && db <= 10)
                {
                    for (int i = 0; i < db; i++)
                    {
                        Button newButton = new()
                        {
                            Content = $"{i + 1}.",
                            Height = 30,
                            Width = 50,
                            Margin = new Thickness(5, i * 30, 5, 5),
                            HorizontalAlignment = HorizontalAlignment.Left,
                            VerticalAlignment = VerticalAlignment.Top
                        };
                        newButton.Click += UjGombClick;
                        gridGombok.Children.Add(newButton);
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

        private void UjGombClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Klikk történt a {(sender as Button).Content} számú gombon ");
        }



        private void tbxSzamBevitel_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!int.TryParse((sender as TextBox).Text, out int eredmeny))
            {
                MessageBox.Show("Nem megfelelő számformátum.");
                (sender as TextBox).Text = "0";
            
            }
        }

        private void btnCheckAdd_Click(object sender , RoutedEventArgs e)
        {
            //HF Classroom
        }
    }
}