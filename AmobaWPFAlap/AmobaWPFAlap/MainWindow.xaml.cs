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
using Microsoft.Win32;

namespace AmobaWPFAlap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string[,]? jatekter;
        public static string jatekos = "X";
        public MainWindow()
        {
            InitializeComponent();

        }

        private void UjJatek(object sender, RoutedEventArgs e)
        {
            int sorSzam = int.Parse(tbxSor.Text);
            int oszlopSzam = int.Parse(tbxOszlop.Text);
            jatekter = new string[sorSzam, oszlopSzam];
            for (int i = 0; i < jatekter.GetLength(0); i++)
            {

                for (int j = 0; j < jatekter.GetLength(1); j++)
                {
                    jatekter[i, j] = " ";
                }
            }

            JatekterKiir();

        }

        private void JatekterKiir()
        {
            int meret = 20;
            if (jatekter == null)
            {
                MessageBox.Show("Nincs feltöltve a játéktér!");
            }
            else
            {
                gridJatekter.Children.Clear();
            }
            // a gridJatekter racshoz gombokat adunk
            for (int i = 0; i < jatekter.GetLength(0); i++)
            {

                for (int j = 0; j < jatekter.GetLength(1); j++)
                {
                    Button button = new Button()
                    {
                        Name = $"btn_{i}_{j}",
                        Content = jatekter[i, j],
                        Width = meret,
                        Height = meret,
                        Margin = new Thickness(j * meret, i * meret, 0, 0),
                        HorizontalAlignment = HorizontalAlignment.Left,
                        VerticalAlignment = VerticalAlignment.Top,
                    };
                    button.Click += Lepes;
                    gridJatekter.Children.Add(button);
                }

            }

        }

        private void Lepes(object sender, RoutedEventArgs e)
        {
            int SorSzam = int.Parse((sender as Button).Name.Split("_")[1]);
            int OszlopSzam = int.Parse((sender as Button).Name.Split("_")[2]);
            if (jatekter[SorSzam, OszlopSzam] != " ")
            {
                MessageBox.Show("Ez a mező már foglalt!");
                return;
            }
            jatekter[SorSzam, OszlopSzam] = jatekos;
            JatekterKiir();
            if (jatekos == "X")
            {
                jatekos = "O";
            }
            else
            {
                jatekos = "X";
            }

            
        }

        private void Mentes_Click(object sender, RoutedEventArgs e)
        {
            if (jatekter == null)
            {
                MessageBox.Show("Nincs feltöltve a játéktér!");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Szöveges fájl|*.txt";
            if (saveFileDialog.ShowDialog() == true)
            {
                using (StreamWriter mentes = new StreamWriter(saveFileDialog.FileName))
                {
                    mentes.WriteLine(jatekter.GetLength(0));
                    mentes.WriteLine(jatekter.GetLength(1));
                    mentes.WriteLine(jatekos);
                    for (int i = 0; i < jatekter.GetLength(0); i++)
                    {
                        for (int j = 0; j < jatekter.GetLength(1); j++)
                        {
                            mentes.Write(jatekter[i, j]);
                        }
                        mentes.WriteLine();
                    }
                    MessageBox.Show("A játék mentése sikeres volt!");
                }


            }
        }

        private void Kilepes_Click(object sender, RoutedEventArgs e)
        {
           MessageBoxResult Yes_or_No= MessageBox.Show("Kiszeretnél lépni a programból?", "Megerősítés", MessageBoxButton.YesNo, MessageBoxImage.Question );
            if (Yes_or_No == MessageBoxResult.Yes)
                Application.Current.Shutdown();

        }

        private void Megnyitas_click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Szöveges fájl|*.txt";
            if (openFileDialog.ShowDialog() == true)
            {
                string[] sorok = File.ReadAllLines(openFileDialog.FileName);

                int sorSzam = int.Parse(sorok[0]);
                int oszlopSzam = int.Parse(sorok[1]);
                jatekos = sorok[2];

                jatekter = new string[sorSzam, oszlopSzam];

                for(int i = 0; i < sorSzam; i++)
                {
                    string jateksor=sorok[i + 3];
                    for (int j = 0; j < oszlopSzam; j++)
                    {
                        jatekter[i, j] = jateksor[j].ToString();
                    }
                }
            }
            JatekterKiir();
            MessageBox.Show("A játék betöltése sikeres volt!");

        }


        //hf: nyerési feltételek vizsgálata
    }
}
