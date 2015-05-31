using Kino.Model;
using Kino.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using ViewModel;
using MySql.Data.MySqlClient;
using System.Windows;

namespace Kino.ViewModel
{
    public class KartaViewModel : INotifyPropertyChanged
    {
        private Karta karta;
        public Karta Karta
        { 
            get { return karta; }
            set { karta = value; OnPropertyChanged("Karta"); } 
        }

        private Klijent klijent;
        public Klijent Klijent
        {
            get { return klijent; }
            set { klijent = value; OnPropertyChanged("Klijent"); }
        }
        private double ukupno;
        public double Ukupno
        {
            get { return ukupno; }
            set { ukupno = value; OnPropertyChanged("Ukupno"); }
        }

        public Film Film { get; set; }

        public ObservableCollection<Film> Filmovi { get; set; }

        public ICommand RezervisiKartu { get; set; }
        public ICommand KupiKartu { get; set; }
        public ICommand RegistrujKlijenta { get; set; }
        public ICommand Ucitaj { get; set; }
        public ICommand Obracunaj { get; set; }

        public void ucitajFilmove()
        {
            string username = "root";
            string password = "";
            string db = "kino";
            string connectionString = "server=localhost;user=" + username + ";pwd=" + password + ";database=" + db;

            try
            {
                MySqlConnection konekcija = new MySqlConnection(connectionString);
                int id;
                konekcija.Open();

                MySqlCommand prikazFilmova = new MySqlCommand("select * from film", konekcija);
                MySqlDataReader reader = prikazFilmova.ExecuteReader();
                while (reader.Read())
                {
                    Film f = new Film();
                    id = reader.GetInt32("id");
                    f.Naziv = reader.GetString("naziv");
                    f.GodinaIzdavanja = reader.GetInt32("GodinaIzdavanja");
                    f.Glumac1 = reader.GetString("Glumac1");
                    f.Glumac2 = reader.GetString("Glumac2");
                    f.Reziser = reader.GetString("Reziser");
                    f.zanr = reader.GetString("Zanr");
                    Filmovi.Add(f);
                }
                konekcija.Close();
            }
            catch
            {
                MessageBox.Show("Povezivanje sa bazom nije uspjelo! Filmovi nisu ucitani!");
            }
        }

        public KartaViewModel()
        {
            karta = new Karta();
            karta.Film = new Film();
            klijent = new Klijent();
            Film = new Film();
            Filmovi = new ObservableCollection<Film>();
            Ukupno = 0;
            ucitajFilmove();
            
            RezervisiKartu = new RelayCommand(rezervisiKartu);
            KupiKartu = new RelayCommand(kupiKartu);
            RegistrujKlijenta = new RelayCommand(registrujKlijenta);
            Ucitaj = new RelayCommand(ucitajKartu);
            Obracunaj = new RelayCommand(obracunaj);
        }

        public void ucitajKartu(object parametar)
        {
            if (Film.Naziv != null)
            {
                string username = "root";
                string password = "";
                string db = "kino";
                string connectionString = "server=localhost;user=" + username + ";pwd=" + password + ";database=" + db;

                try
                {
                    MySqlConnection konekcija = new MySqlConnection(connectionString);
                    int id;
                    int rezervacijski = 0;
                    int brojSjed = 0;
                    konekcija.Open();

                    MySqlCommand ucitanjeKarte = new MySqlCommand();
                    ucitanjeKarte.Connection = konekcija;
                    ucitanjeKarte.CommandText = "select * from karta where Film = @naziv;";
                    ucitanjeKarte.Parameters.AddWithValue("@naziv", Film.Naziv);
                    MySqlDataReader reader = ucitanjeKarte.ExecuteReader();
                    while (reader.Read())
                    {
                        id = reader.GetInt32("id");
                        Karta.Film.Naziv = reader.GetString("Film");
                        rezervacijski = reader.GetInt32("RezervacijskiBroj");
                        Karta.Sala = reader.GetInt32("Sala");
                        brojSjed = reader.GetInt32("BrojSjedista");
                        Karta.Termin = reader.GetString("Termin");
                        Karta.Cijena = reader.GetDouble("Cijena");
                    }
                    konekcija.Close();

                    if (Karta.RezervacijskiBroj == rezervacijski)
                        Karta.BrojSjedista = brojSjed;
                    else Karta.BrojSjedista = 0;
                }
                catch
                {
                    MessageBox.Show("Povezivanje sa bazom nije uspjelo! Karta nije ucitana!");
                }
            }

        }

        public void kupiKartu(object parametar)
        {
            if (Film.ZauzetaSjedista.Contains(Karta.BrojSjedista) || Karta.BrojSjedista == 0)
                MessageBox.Show("Odaberite drugo sjedište!");
            else
            {
                Film.ZauzetaSjedista.Add(Karta.BrojSjedista);
                Karta.RezervacijskiBroj = 0;
                Karta.BrojSjedista = 0;
                Ukupno += Karta.Cijena;
            }
        }

        public void obracunaj(object parametar)
        {
            MessageBox.Show("Kupovina karata je obavljena");
            Ukupno = 0;
        }

        public void rezervisiKartu(object parametar)
        { }


        public void registrujKlijenta(object parametar)
        {
            klijent.ImePrezime = "Armin Nogo";
            klijent.BrojLicneKarte = "sdjhsj";
            klijent.BrojKinoKartice = 10;
            klijent.BrojStudentKinoKartice = 814;

            string username = "root";
            string password = "";
            string db = "kino";
            string connectionString = "server=localhost;user=" + username + ";pwd=" + password + ";database=" + db;
            try
            {
                MySqlConnection konekcija = new MySqlConnection(connectionString);
                konekcija.Open();

                MySqlCommand insertKlijenta = new MySqlCommand("insert into klijent(ImePrezime, BrojLicneKarte, BrojKinoKartice,BrojStudentKinoKartice)"
                    + "values('" + klijent.ImePrezime + "','" + klijent.BrojLicneKarte + "','" + klijent.BrojKinoKartice + "','" + klijent.BrojStudentKinoKartice + "')", konekcija);
                insertKlijenta.ExecuteNonQuery();
                konekcija.Close();
                MessageBox.Show("Dobro je");
            }
            catch
            {
                MessageBox.Show("Unos klijenta u bazu podataka nije uspio!", "Povezivanje sa bazom");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
