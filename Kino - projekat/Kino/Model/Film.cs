using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Kino.Model
{
    public class Film //: INotifyPropertyChanged
    {
        public string Naziv { get; set; }
        public int GodinaIzdavanja { get; set; }
        public string Glumac1 { get; set; }
        public string Glumac2 { get; set; }
        public string Reziser { get; set; }
        public Zanr zanr { get; set; }
        public enum Zanr{akcija, komedija, horror, triler, drama, Sci_Fi, romantika, avantura, dokumentarni};

        //public event PropertyChangedEventHandler PropertyChanged;
        public Film()
        { }
        public Film( string naziv, int godina, string glumac1, string glumac2, string reziser, Zanr zanr)
        {
            Naziv = naziv;
            GodinaIzdavanja = godina;
            Glumac1 = glumac1;
            Glumac2 = glumac2;
            Reziser = reziser;
            this.zanr = zanr;
        }
    }
}
