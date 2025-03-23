using System;
using System.Windows;

namespace SzambevitelMezo
{
    public partial class KijelentkezesWindow : Window
    {
        public KijelentkezesWindow()
        {
            InitializeComponent();
        }

        private void btnKijelentkezes_Click(object sender, RoutedEventArgs e)
        {
            
            if (tbxNev.Text == "" || tbxFaj.Text == "" || tbxFajta.Text == "")
            {
                MessageBox.Show("Minden mező kitöltése kötelező!");
                return;
            }

            
            Pet torlendo = null;
            foreach (Pet pet in MainWindow.Pets)
            {
                if (pet.Nev == tbxNev.Text && pet.Faj == tbxFaj.Text && pet.Fajta == tbxFajta.Text)
                {
                    torlendo = pet;
                    break; 
                }
            }

            
            if (torlendo != null)
            {
                MainWindow.Pets.Remove(torlendo);
                MessageBox.Show("Az állat sikeresen kijelentkezett!");
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Nem található ilyen állat!");
            }
        }

        private void btnMegse_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); 
        }
    }
}