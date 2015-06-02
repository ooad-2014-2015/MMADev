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
using Kino.View;

namespace Kino
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


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password == "dodaci")
            {
                FormaDodaci fd = new FormaDodaci();

                //fd.DataContext = new ViewModel.ProdajaDodatakViewModel();
                fd.Show();
                this.Close();
            }
            else if (PasswordBox.Password=="film")
            {
                FormaFilm ff = new FormaFilm();
            
                ff.Show();
                this.Close();
            }
            else if (PasswordBox.Password=="karta")
            {
                FormaKarta fk = new FormaKarta();

              //  fk.DataContext = new ViewModel.KartaViewModel();
                fk.Show();
                this.Close();
            }
        
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Dobro došli u Kino! \nUkoliko unesete šifru 'film' otvoriće se forma u kojoj će biti moguće napraviti sedmični raspored filmova te isprintati isti. Također će biti moguće dodati novi film u sedmični program, ali i obrisati potojeći. \nUkoliko unesete šifru 'karta' otvoriće se forma u kojoj će biti omogućena prodaja karata, rezervacija karata kao i registracija novih klijenata. \nUkoliko uneste šifru 'dodaci' otvoriće se forma na kojoj će biti omogućena prodaja i ažuriranje količine zaliha unutar sistema.", "Uputa za korištenje aplikacije", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
