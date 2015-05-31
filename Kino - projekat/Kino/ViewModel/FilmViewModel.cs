using Kino.Model;
using Kino.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ViewModel;
using MySql.Data.MySqlClient;
using System.Windows.Controls;

namespace Kino.ViewModel
{
    public class FilmViewModel
    {
        public ICommand DodajFilm { get; set; }
        public ICommand NapraviRaspored { get; set; }
        public ICommand ObrisiFilm { get; set; }

        public ObservableCollection<Film> Filmovi { get; set; }

        public Film Film { get; set; }
        public Film FilmBrisanje { get; set; }

        public FormaFilm forma { get; set; }

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

        public FilmViewModel(FormaFilm Forma)
        {           
            Film = new Film();
            FilmBrisanje = new Film();
            Filmovi = new ObservableCollection<Film>();
            forma = Forma;

            ucitajFilmove();

            DodajFilm = new RelayCommand(dodajFilm);
            NapraviRaspored = new RelayCommand(napraviRaspored);
            ObrisiFilm = new RelayCommand(obrisiFilm);
        }

        public void dodajFilm(object parametar)
        {
            string username = "root";
            string password = "";
            string db = "kino";
            string connectionString = "server=localhost;user=" + username + ";pwd=" + password + ";database=" + db;
            try
            {
                MySqlConnection konekcija = new MySqlConnection(connectionString);
                konekcija.Open();

                MySqlCommand insertFilma = new MySqlCommand("insert into film(Naziv, GodinaIzdavanja, Glumac1, Glumac2, Reziser, Zanr)"
                    + "values('" + Film.Naziv + "','" + Film.GodinaIzdavanja + "','" + Film.Glumac1 + "','" + Film.Glumac2 + "','" + Film.Reziser + "','" + Film.Zanr + "')", konekcija);
                insertFilma.ExecuteNonQuery();
                konekcija.Close();
                MessageBox.Show("Uspješno ste dodali novi film!");
            }
            catch
            {
                MessageBox.Show("Unos filma u bazu podataka nije uspio!", "Povezivanje sa bazom");
            }
            ucitajFilmove();
        }

        public void napraviRaspored(object parametar)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintVisual(forma ,"Rasproed");
            }
        }

        public void obrisiFilm(object parametar)
        {
            string username = "root";
            string password = "";
            string db = "kino";
            string connectionString = "server=localhost;user=" + username + ";pwd=" + password + ";database=" + db;
            try
            {
                MySqlConnection konekcija = new MySqlConnection(connectionString);
                konekcija.Open();

                MySqlCommand deleteFilma = new MySqlCommand();
                deleteFilma.Connection = konekcija;
                deleteFilma.CommandText = "delete from film where Naziv = @naziv;";
                deleteFilma.Parameters.AddWithValue("@naziv", FilmBrisanje.Naziv);
                deleteFilma.ExecuteNonQuery();
                konekcija.Close();
                Filmovi.Remove(FilmBrisanje);
                MessageBox.Show("Uspješno ste obrisali odabrani film!");
            }
            catch
            {
                MessageBox.Show("Brisanje filma iz baze podataka nije uspjelo!", "Povezivanje sa bazom");
            }
        }

        
    }
}
