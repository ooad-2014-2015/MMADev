using Igrica.Klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Igrica.Resources.Sherlock
{
    /// <summary>
    /// Interaction logic for SherlockLahki.xaml
    /// </summary>
    public partial class SherlockLahki : Window
    {
        public SherlockLahki()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PrvaLahki novaIgra = new PrvaLahki();
            novaIgra.igraj((string)DugmeSherlock.Content);
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            PrvaLahki novaIgra = new PrvaLahki();
            novaIgra.igraj((string)DugmePrestige.Content);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            //nema potrebe za provjerom
            //if (PrvaLahki.brojacPoenaL > 3) PrvaLahki.brojacPoenaL = 3;
            MainWindow.rezultat += PrvaLahki.brojacPoenaL;
            MessageBox.Show("Kraj igre!! \nOsvojili ste " + Convert.ToString(PrvaLahki.brojacPoenaL) +"/3 poena");
            PrvaLahki.tacanOdgovor = false;
        }
    }
}
