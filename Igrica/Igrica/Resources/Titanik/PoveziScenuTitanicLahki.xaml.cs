using Igrica.Klase;
using Igrica.Resources.Sherlock;
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

namespace Igrica.Resources.Titanik
{
    /// <summary>
    /// Interaction logic for PoveziScenuTitanicLahki.xaml
    /// </summary>
    public partial class PoveziScenuTitanicLahki : Window
    {
        public PoveziScenuTitanicLahki()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PrvaLahki novaIgra = new PrvaLahki();
            novaIgra.igraj((string)DugmeTitanik.Content);
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            PrvaLahki novaIgra = new PrvaLahki();
            novaIgra.igraj((string)DugmeShipWreck.Content);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SherlockLahki novaForma = new SherlockLahki();
            novaForma.Show();
            this.Close();
            PrvaLahki.brojacL++;
        }
    }
}
