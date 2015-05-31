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
    public class Film : INotifyPropertyChanged
    {
        private string naziv;
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; OnPropertyChanged("Naziv"); }
        }

        private int godinaIzdavanja;
        public int GodinaIzdavanja 
        {
            get { return godinaIzdavanja; }
            set { godinaIzdavanja = value; OnPropertyChanged("GodinaIzdavanja"); }
        }
        private string glumac1;
        public string Glumac1 
        { 
            get { return glumac1; }
            set { glumac1 = value; OnPropertyChanged("Glumac1"); }
        }
        private string glumac2;
        public string Glumac2
        {
            get { return glumac2; }
            set { glumac2 = value; OnPropertyChanged("Glumac2"); }
        }
        private string reziser;
        public string Reziser
        {  
            get { return reziser; }
            set { reziser = value; OnPropertyChanged("Reziser"); }
        }
        private string _zanr;
        public string zanr
        {
            get { return _zanr; }
            set { _zanr = value; OnPropertyChanged("zanr"); }
        }
        public List<int> ZauzetaSjedista { get; set; }

        public List<string> Zanr{get; set;}

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public Film()
        {
            ZauzetaSjedista = new List<int>();
            Zanr = new List<string> { "Akcija", "Komedija", "Horror", "Triler", "Drama", "Sci_Fi", "Romantika", "Avantura", "Dokumentarni" };
        }

        //vjerovatno ne treba

        public Film( string naziv, int godina, string glumac1, string glumac2, string reziser, string zanr)
        {
            Zanr = new List<string> { "Akcija", "Komedija", "Horror", "Triler", "Drama", "Sci_Fi", "Romantika", "Avantura", "Dokumentarni" };
            Naziv = naziv;
            GodinaIzdavanja = godina;
            Glumac1 = glumac1;
            Glumac2 = glumac2;
            Reziser = reziser;
            this.zanr = zanr;
        }

        public override string ToString()
        {
            return naziv;
        }
    }
}
