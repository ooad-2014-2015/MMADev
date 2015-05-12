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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Igrica
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

        private void zapocni(object sender, RoutedEventArgs e)
        {
            if (IgraSlika.IsChecked == true)
            {
                PrvaIgra igra = new PrvaIgra();
                igra.izaberiNivo((bool)LahkiNivo.IsChecked);
              //  this.Visibility = Visibility.Hidden;

            }

            else if(IgraSpajalica.IsChecked == true)
            {
                Spajalica igra2 = new Spajalica();
                igra2.Show();
              //  this.Visibility = Visibility.Hidden;
            }

            else if(IgraKoZnaZna.IsChecked == true)
            {
                KoZnaZna igra3 = new KoZnaZna();
                igra3.Show();
               // this.Visibility = Visibility.Hidden;
            }
            else
            {
                MessageBox.Show("Nije izabrana nijedna igra!", "Greška", MessageBoxButton.OK, MessageBoxImage.Error); 
            }
        }

        private void IgraSlika_Checked(object sender, RoutedEventArgs e)
        {
            IzborNivoa.Visibility = Visibility.Visible;
        }

        private void IgraSpajalica_Checked(object sender, RoutedEventArgs e)
        {
            IzborNivoa.Visibility = Visibility.Visible;
        }

        private void IgraKoZnaZna_Checked(object sender, RoutedEventArgs e)
        {
            IzborNivoa.Visibility = Visibility.Visible;
        }

    }
}
