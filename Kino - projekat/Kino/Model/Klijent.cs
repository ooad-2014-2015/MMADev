using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Model
{
    public class Klijent : INotifyPropertyChanged, IDataErrorInfo
    {
        private string imePrezime;
        public string ImePrezime
        {
            get { return imePrezime; }
            set { imePrezime = value; OnPropertyChanged("ImePrezime"); }
        }
        private string brojLicneKarte;
        public string BrojLicneKarte
        {
            get { return brojLicneKarte; }
            set { brojLicneKarte = value; OnPropertyChanged("BrojLicneKarte"); }
        }
        private int brojKinoKartice;
        public int BrojKinoKartice
        {
            get { return brojKinoKartice; }
            set { brojKinoKartice = value; OnPropertyChanged("BrojKinoKartice"); }
        }
        private int brojStudentKinoKartice;
        public int BrojStudentKinoKartice
        {
            get { return brojStudentKinoKartice; }
            set { brojStudentKinoKartice = value; OnPropertyChanged("BrojStudentKinoKartice"); }
        }

        public List<Karta> RezervisaneKarte { get; set; }

        public Klijent()
        { }

        public Klijent(string ime, string licna, int kinoKartica = 0, int student = 0)
        {
            ImePrezime = ime;
            BrojLicneKarte = licna;
            BrojKinoKartice = kinoKartica;
            BrojStudentKinoKartice = student;
            RezervisaneKarte = new List<Karta>();
        }

        public bool IsValid
        {
            get
            {
                foreach (string property in validateProperties)
                {
                    if (getValidationError(property) != null)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        static readonly string[] validateProperties =
        {
            "ImePrezime","BrojLicneKarte"
        };

        string IDataErrorInfo.Error
        {
            get { return null; }
        }

        string  IDataErrorInfo.this[string propertyName]
        {
            get { return getValidationError(propertyName); }
        }

        string getValidationError(string propertyName) 
        {
            string error = null;
            switch (propertyName)
            {
                case "ImePrezime":
                    error = validirajIme();
                    break;

                case "BrojLicneKarte":
                    error = validirajBrojLicneKarte();
                    break;
            }
            return error;
        }

        private string validirajIme()
        {
            if (String.IsNullOrWhiteSpace(ImePrezime))
            {
                return "Ime i prezime moraju biti uneseni!";
            }
            return null;
        }

        private string validirajBrojLicneKarte()
        {
            if (String.IsNullOrWhiteSpace(BrojLicneKarte))
            {
                return "Broj kreditne kartice mora biti unesen!";
            }
            if (BrojLicneKarte.Length != 9) return "Mora imati 9 znakova!";
            if (!(char.IsNumber(BrojLicneKarte[0]))) return "Prvi znak mora biti broj!";
            return null;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public override string ToString()
        {
            return ImePrezime;
        }
    }
}
