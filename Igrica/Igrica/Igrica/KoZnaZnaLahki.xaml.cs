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
using Igrica.Klase;
using Igrica.Klase.Interfejsi;

namespace Igrica
{
    /// <summary>
    /// Interaction logic for KoZnaZna.xaml
    /// </summary>
    public partial class KoZnaZna : Window
    {
        public KoZnaZna()
        {
            InitializeComponent();
        }
        public static List<Pitanje> Pitanja = new List<Pitanje>();
        public static int brojPitanja = 0;
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Pitanja.Clear();
            brojPitanja = 0;

            Pitanja.Add(new Pitanje("Koliko dijelova Star Wars je snimljeno?", "4", "5", "6", "7", "6"));
            Pitanja.Add(new Pitanje("Ko je glavni glumac filma Indiana Jones?", "Leonardo Di Caprio", "Harrison Ford", "Steven Seagal", "Matt Damon", "Harrison Ford"));
            Pitanja.Add(new Pitanje("Koliko je oskara dobio glumac Leonardo Di Caprio?", "3", "1", "0", "2", "0"));
            Pitanja.Add(new Pitanje("Koliko dijelova filma Terminator je snimljeno dosad?", "3", "4", "5", "6", "4"));
            Pitanja.Add(new Pitanje("Kako se zove partner Sherlocka Holmesa?", "John H. Watson", "Alfred Pennyworth", "Hercule Poirot", "Agatha Christie", "John H. Watson"));
            Pitanja.Add(new Pitanje("Ko je glavni glumac u filmi Zmije u avionu(Snakes on a Plane)?", "Morgan Freeman", "Cuba Gooding jr.", "Will Smith", "Samuel L. Jakcson", "Samuel L. Jakcson"));

            pitanje.Content = Pitanja[brojPitanja].Pitanjee;
            prviOdg.Content = Pitanja[brojPitanja].Odgovor1;
            drugiOdg.Content = Pitanja[brojPitanja].Odgovor2;
            treciOdg.Content = Pitanja[brojPitanja].Odgovor3;
            cetvrtiOdg.Content = Pitanja[brojPitanja].Odgovor4;
        }

        private void prviOdg_Click(object sender, RoutedEventArgs e)
        {
            if (!TrecaLahki.tacanOdgovor)
            {
                TrecaLahki igra = new TrecaLahki();
                if (igra.igraj(Convert.ToString(prviOdg.Content), Pitanja[brojPitanja].TacanOdgovor))
                {
                    prviOdg.Background = Brushes.Green;
                }
                else
                {
                    prviOdg.Background = Brushes.Red;
                }
            }
        }

        private void drugiOdg_Click(object sender, RoutedEventArgs e)
        {
            if (!TrecaLahki.tacanOdgovor)
            {
                TrecaLahki igra = new TrecaLahki();

                if (igra.igraj(Convert.ToString(drugiOdg.Content), Pitanja[brojPitanja].TacanOdgovor))
                {
                    drugiOdg.Background = Brushes.Green;
                }
                else
                {
                    drugiOdg.Background = Brushes.Red;
                }
            }
        }

        private void treciOdg_Click(object sender, RoutedEventArgs e)
        {
            if (!TrecaLahki.tacanOdgovor)
            {
                TrecaLahki igra = new TrecaLahki();
                if (igra.igraj(Convert.ToString(treciOdg.Content), Pitanja[brojPitanja].TacanOdgovor))
                {
                    treciOdg.Background = Brushes.Green;

                }
                else
                {
                    treciOdg.Background = Brushes.Red;
                 }
            }
        }

        private void cetvrtiOdg_Click(object sender, RoutedEventArgs e)
        {
            if (!TrecaLahki.tacanOdgovor)
            {
                TrecaLahki igra = new TrecaLahki();
                if (igra.igraj(Convert.ToString(cetvrtiOdg.Content), Pitanja[brojPitanja].TacanOdgovor))
                {
                    cetvrtiOdg.Background = Brushes.Green;

                }
                else
                {
                    cetvrtiOdg.Background = Brushes.Red;
                }
            }
        }

        private void sljedecePitanje_Click(object sender, RoutedEventArgs e)
        {
            if (brojPitanja == 5) 
            {
                MainWindow.rezultat += TrecaLahki.brojacPoenaL;
                if (MessageBox.Show("Osvojili ste " + Convert.ToString(TrecaLahki.brojacPoenaL) + " poena!", "Kraj igre", MessageBoxButton.OK) == MessageBoxResult.OK) this.Close();
            }
            else
            {
                TrecaLahki.tacanOdgovor = false;
                prviOdg.ClearValue(Button.BackgroundProperty);
                drugiOdg.ClearValue(Button.BackgroundProperty);
                treciOdg.ClearValue(Button.BackgroundProperty);
                cetvrtiOdg.ClearValue(Button.BackgroundProperty);

                brojPitanja++;
                pitanje.Content = Pitanja[brojPitanja].Pitanjee;
                prviOdg.Content = Pitanja[brojPitanja].Odgovor1;
                drugiOdg.Content = Pitanja[brojPitanja].Odgovor2;
                treciOdg.Content = Pitanja[brojPitanja].Odgovor3;
                cetvrtiOdg.Content = Pitanja[brojPitanja].Odgovor4;
            }
        }
    }
}
