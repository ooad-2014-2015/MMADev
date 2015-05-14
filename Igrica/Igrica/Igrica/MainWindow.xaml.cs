using Igrica.Klase;
using Igrica.Resources;
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
        public static int rezultat = 0;
        private void zapocni(object sender, RoutedEventArgs e)
        {
            PrvaLahki.brojacL = 0;
            PrvaLahki.brojacPoenaL = 0;
            PrvaTeski.brojacT = 0;
            PrvaTeski.brojacPoenaT = 0;
            if (IgraSlika.IsChecked == true)
            {
                PrvaIgra igra = new PrvaIgra();
                igra.izaberiNivo((bool)LahkiNivo.IsChecked);

            }

            else if(IgraSpajalica.IsChecked == true)
            {
                DrugaIgra igra = new DrugaIgra();
                igra.izaberiNivo((bool)LahkiNivo.IsChecked);

            }

            else if(IgraKoZnaZna.IsChecked == true)
            {
                TrecaIgra igra = new TrecaIgra();
                igra.izaberiNivo((bool)LahkiNivo.IsChecked);
               
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            if (MessageBox.Show("Osvojili ste ukupno " + rezultat + " poena!", "Ukupan rezultat", MessageBoxButton.OK) == MessageBoxResult.OK)
                this.Visibility = Visibility.Visible;
        }

    }
}
