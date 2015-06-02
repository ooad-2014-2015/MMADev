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
        private Klijent kPopust;
        public Klijent KPopust
        {
            get { return kPopust; }
            set { kPopust = value; OnPropertyChanged("KPopust"); }
        }
        private double ukupno;
        public double Ukupno
        {
            get { return ukupno; }
            set { ukupno = value; OnPropertyChanged("Ukupno"); }
        }
        private int indeks;
        public int Indeks
        {
            get { return indeks; }
            set { indeks = value; OnPropertyChanged("Indeks"); }
        }

        public Film Film { get; set; }

        public Film FilmRez { get; set; }
        public Klijent KlijentRez { get; set; }
        public Karta KartaRez { get; set; }

        private int brojSjed;
        public int BrojSjed
        {
            get { return brojSjed; }
            set { brojSjed = value; OnPropertyChanged("BrojSjed"); }
        }

        public ObservableCollection<Film> Filmovi { get; set; }
        public ObservableCollection<Klijent> Klijenti { get; set; }

        public ICommand RezervisiKartu { get; set; }
        public ICommand KupiKartu { get; set; }
        public ICommand RegistrujKlijenta { get; set; }
        public ICommand Ucitaj { get; set; }
        public ICommand Obracunaj { get; set; }
        public ICommand Popust { get; set; }

        public void ucitajKlijente()
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

                MySqlCommand prikazKlijenata = new MySqlCommand("select * from klijent", konekcija);
                MySqlDataReader reader = prikazKlijenata.ExecuteReader();
                while (reader.Read())
                {
                    Klijent k = new Klijent();
                    id = reader.GetInt32("id");
                    k.ImePrezime = reader.GetString("ImePrezime");
                    k.BrojLicneKarte = reader.GetString("BrojLicneKarte");
                    k.BrojKinoKartice = reader.GetInt32("BrojKinoKartice");
                    k.BrojStudentKinoKartice = reader.GetInt32("BrojStudentKinoKartice");
                    Klijenti.Add(k);
                }
                konekcija.Close();
            }
            catch
            {
                MessageBox.Show("Povezivanje sa bazom nije uspjelo! Klijenti nisu učitani!");
            }
        }

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
                MessageBox.Show("Povezivanje sa bazom nije uspjelo! Filmovi nisu učitani!");
            }
        }

        public KartaViewModel()
        {
            karta = new Karta();
            karta.Film = new Film();
            KartaRez = new Karta();
            KartaRez.Film = new Film();
            klijent = new Klijent();
            Klijent.BrojKinoKartice = 0;
            Klijent.BrojStudentKinoKartice = 0;
            KlijentRez = new Klijent();
            kPopust = new Klijent();
            Film = new Film();
            FilmRez = new Film();
            Filmovi = new ObservableCollection<Film>();
            Klijenti = new ObservableCollection<Model.Klijent>();
            BrojSjed = 0;
            Ukupno = 0;
            Indeks = 0;
            ucitajFilmove();
            ucitajKlijente();
            
            RezervisiKartu = new RelayCommand(rezervisiKartu);
            KupiKartu = new RelayCommand(kupiKartu);
            RegistrujKlijenta = new RelayCommand(registrujKlijenta);
            Ucitaj = new RelayCommand(ucitajKartu);
            Obracunaj = new RelayCommand(obracunaj);
            Popust = new RelayCommand(popust);
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
        {
            if(FilmRez.Naziv == null || KlijentRez.ImePrezime == null || BrojSjed == 0)
            {
                MessageBox.Show("Morate odabrati klijenta koji rezerviše kartu, film i broj sjedišta!");
                return;
            }
            string username = "root";
            string password = "";
            string db = "kino";
            string connectionString = "server=localhost;user=" + username + ";pwd=" + password + ";database=" + db;

            try
            {
                MySqlConnection konekcija = new MySqlConnection(connectionString);
                int id;
                konekcija.Open();

                MySqlCommand ucitanjeKarte = new MySqlCommand();
                ucitanjeKarte.Connection = konekcija;
                ucitanjeKarte.CommandText = "select * from karta where Film = @naziv;";
                ucitanjeKarte.Parameters.AddWithValue("@naziv", FilmRez.Naziv);
                MySqlDataReader reader = ucitanjeKarte.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32("id");
                    KartaRez.Film.Naziv = reader.GetString("Film");
                    KartaRez.RezervacijskiBroj = reader.GetInt32("RezervacijskiBroj");
                    KartaRez.Sala = reader.GetInt32("Sala");
                    KartaRez.BrojSjedista = reader.GetInt32("BrojSjedista");
                    KartaRez.Termin = reader.GetString("Termin");
                    KartaRez.Cijena = reader.GetDouble("Cijena");
                }
                konekcija.Close();

                if (KartaRez.BrojSjedista == BrojSjed)
                {
                    MessageBox.Show("Odabrano sjedište je zauzeto!");
                }
                else
                {
                    MessageBox.Show("Uspješno ste unijeli rezervaciju karte!");

                    try
                    {
                        konekcija.Open();

                        MySqlCommand insertKarte = new MySqlCommand("insert into karta(Film, RezervacijskiBroj, Sala, BrojSjedista, Termin, Cijena)"
                            + "values('" + FilmRez.Naziv + "','" + KlijentRez.BrojKinoKartice + "','" + KartaRez.Sala + "','" + BrojSjed + "','" + 
                            KartaRez.Termin + "','" + KartaRez.Cijena + "')", konekcija);
                        insertKarte.ExecuteNonQuery();
                        konekcija.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Unos rezervacije u bazu podataka nije uspio!", "Povezivanje sa bazom");
                    }
                }
                BrojSjed = 0;                
            }
            catch
            {
                MessageBox.Show("Povezivanje sa bazom nije uspjelo! Karta nije ucitana!");
            }    
        }


        public void registrujKlijenta(object parametar)
        {
            if (Klijent.IsValid)
            {
                string username = "root";
                string password = "";
                string db = "kino";
                string connectionString = "server=localhost;user=" + username + ";pwd=" + password + ";database=" + db;
                try
                {
                    MySqlConnection konekcija = new MySqlConnection(connectionString);
                    konekcija.Open();

                    MySqlCommand insertKlijenta = new MySqlCommand("insert into klijent(ImePrezime, BrojLicneKarte, BrojKinoKartice,BrojStudentKinoKartice)"
                        + "values('" + klijent.ImePrezime + "','" + klijent.BrojLicneKarte + "','" + klijent.BrojKinoKartice + "','"
                        + klijent.BrojStudentKinoKartice + "')", konekcija);
                    insertKlijenta.ExecuteNonQuery();
                    konekcija.Close();
                    MessageBox.Show("Uspješno ste registrovali novog klijenta!");
                    ucitajKlijente();
                }
                catch
                {
                    MessageBox.Show("Unos klijenta u bazu podataka nije uspio!", "Povezivanje sa bazom");
                }
            }
            else MessageBox.Show("Niste unijeli ime i prezime klijenta ili ste unijeli pogrešan format lične karte!");
        }

        public void popust(object parametar)
        {
            if (Indeks == 0 || Ukupno == 0) return;
            string username = "root";
            string password = "";
            string db = "kino";
            string connectionString = "server=localhost;user=" + username + ";pwd=" + password + ";database=" + db;

            try
            {
                MySqlConnection konekcija = new MySqlConnection(connectionString);
                int id;
                konekcija.Open();

                MySqlCommand ucitanjeKlijenta = new MySqlCommand();
                ucitanjeKlijenta.Connection = konekcija;
                ucitanjeKlijenta.CommandText = "select * from klijent where BrojStudentKinoKartice = @broj;";
                ucitanjeKlijenta.Parameters.AddWithValue("@broj", Indeks);
                MySqlDataReader reader = ucitanjeKlijenta.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32("id");
                    KPopust.ImePrezime = reader.GetString("ImePrezime");
                    KPopust.BrojLicneKarte = reader.GetString("BrojLicneKarte");
                    KPopust.BrojKinoKartice = reader.GetInt32("BrojKinoKartice");
                    KPopust.BrojStudentKinoKartice = reader.GetInt32("BrojStudentKinoKartice");
                }
                konekcija.Close();

                if (KPopust.BrojStudentKinoKartice == Indeks)
                    Ukupno -= Ukupno * 0.25;
                else MessageBox.Show("Ne postoji klijent registrovan sa unesenim indeksom!");
                Indeks = 0;
            }
            catch
            {
                MessageBox.Show("Povezivanje sa bazom nije uspjelo! Karta nije ucitana!");
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
