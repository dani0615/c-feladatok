﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        }

        private void JatekterKiir()
        {

        }

        private void Lepes(object sender, RoutedEventArgs e)
        {

        }
    }
}
