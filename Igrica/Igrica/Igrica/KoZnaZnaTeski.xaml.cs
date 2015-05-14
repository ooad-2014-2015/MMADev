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

namespace Igrica
{
    /// <summary>
    /// Interaction logic for KoZnaZnaTeski.xaml
    /// </summary>
    public partial class KoZnaZnaTeski : Window
    {
        //varijabla koja ce nam pomoc da kontrolisemo bodove ukoliko se ne predje na sljedecu sliku

        public KoZnaZnaTeski()
        {
            InitializeComponent();
        }

        public static List<Pitanje> Pitanja = new List<Pitanje>();
        public static int brojPitanja = 0;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Pitanja.Clear();
            brojPitanja = 0;

            Pitanja.Add(new Pitanje("Koje godine je objavljen prvi dio filma Matrix?", "1997", "1999", "2001", "2003", "1999"));
            Pitanja.Add(new Pitanje("Koji dio filma Gospodar Prstenova ima podnaslov 'The Two Towers'?", "nijedan", "prvi", "drugi", "treci", "drugi"));
            Pitanja.Add(new Pitanje("Zivot koje porodice je prikazan u filmu Kum?", "Bonanno", "Colombo", "Gambino", "Corleone", "Corleone"));
            Pitanja.Add(new Pitanje("Koji glumac se ne pojavljuje u prvom dijelu filma The Expendables?", "Terry Crews", "Jet Li", "Chuck Norris", "Dolph Lundgren", "Chuck Norris"));
            Pitanja.Add(new Pitanje("Sta nije bio Forrest Gump?", "vojnik", "stonoteniser", "kosarkas", "ragbi igrac", "ksoarkas"));
            Pitanja.Add(new Pitanje("Kako se zove lik Decimus Meridius, kojeg glumi Russel Crowe u filmu Gladiator?", "Minimus", "Midimus", "Maximus", "Optimus", "Maximus"));
            

            pitanje.Content = Pitanja[brojPitanja].Pitanjee;
            prviOdg.Content = Pitanja[brojPitanja].Odgovor1;
            drugiOdg.Content = Pitanja[brojPitanja].Odgovor2;
            treciOdg.Content = Pitanja[brojPitanja].Odgovor3;
            cetvrtiOdg.Content = Pitanja[brojPitanja].Odgovor4;
        }

        private void prviOdg_Click(object sender, RoutedEventArgs e)
        {
            if (!TrecaTeski.tacanOdgovor)
            {
                TrecaTeski igra = new TrecaTeski();

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
            if (!TrecaTeski.tacanOdgovor)
            {
                TrecaTeski igra = new TrecaTeski();

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
            if (!TrecaTeski.tacanOdgovor)
            {
                TrecaTeski igra = new TrecaTeski();
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
            if (!TrecaTeski.tacanOdgovor)
            {
                TrecaTeski igra = new TrecaTeski();
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
                MainWindow.rezultat += TrecaTeski.brojacPoenaT;
                if (MessageBox.Show("Osvojili ste " + Convert.ToString(TrecaTeski.brojacPoenaT) + " poena!", "Kraj igre", MessageBoxButton.OK) == MessageBoxResult.OK) this.Close();
            }
            else
            {
                TrecaTeski.tacanOdgovor = false;
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
