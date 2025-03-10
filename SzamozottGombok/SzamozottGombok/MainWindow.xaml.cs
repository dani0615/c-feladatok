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

namespace SzamozottGombok
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

        private void btnEllenoriz_Click(object sender, RoutedEventArgs e)
        {
            bool fut=true;
            int szam;
            bool eredmeny = int.TryParse(tbxSzam.Text, out szam);
            if (szam<1 || szam >10)
            {
                MessageBox.Show("Határon kívüli szám");
                fut = false;
            }
            if (!eredmeny)
            {
                MessageBox.Show("Nem megfelelő számformátum!");
                fut = false;
            }

            if (fut)
            {
                for (int i = 0; i < szam; i++)
                {
                    Button button = new Button()
                    {
                        Content = i + 1,
                        Width = 50,
                        Height = 30,
                        Margin = new Thickness(5, i * 30, 5, 5),
                        HorizontalAlignment = HorizontalAlignment.Left,
                        VerticalAlignment = VerticalAlignment.Top,


                    };
                    gombok.Children.Add(button);
                }
            }


               
            }
           
            
        }
    }
