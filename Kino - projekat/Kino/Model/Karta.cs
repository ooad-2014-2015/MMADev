using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows;

namespace Kino.Model
{
    public class Karta : INotifyPropertyChanged
    {
        public Film Film { get; set; }

        private int sala;
        public int Sala
        {
            get { return sala; }
            set { sala = value; OnPropertyChanged("Sala"); }
        }

        private int brojSjedista;
        public int BrojSjedista
        {
            get { return brojSjedista; }
            set { brojSjedista = value; OnPropertyChanged("BrojSjedista"); }
        }
        private double cijena;
        public double Cijena
        {
            get { return cijena; }
            set { cijena = value; OnPropertyChanged("Cijena"); }
        }
        private int rezervacijskiBroj;
        public int RezervacijskiBroj
        {
            get { return rezervacijskiBroj; }
            set { rezervacijskiBroj = value; OnPropertyChanged("RezervacijskiBroj"); }
        }
        public string Termin {get; set;}

        public Karta()
        { }
        public Karta(Film film, int sala, int brSjedista, string termin, double cijena, int rezBr = 0)
        {
            Film = film;
            Sala = sala;
            BrojSjedista = brSjedista;
            Termin = termin;
            Cijena = cijena;
            RezervacijskiBroj = rezBr;
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
