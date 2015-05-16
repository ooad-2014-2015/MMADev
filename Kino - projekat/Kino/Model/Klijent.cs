using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Model
{
    public class Klijent: IDataErrorInfo
    {
        public string ImePrezime { get; set; }
        public string BrojLicneKarte { get; set; }
        public int BrojKinoKartice { get; set; }
        public int BrojStudentKinoKartice { get; set; }
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
                if(getValidationError("BrojLicneKarte") != null) return false;

                return true;
            }
        }

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
                case "BrojLicneKarte":
                    error = validirajBrojLicneKarte();
                    break;
            }
            return error;
        }

        private string validirajBrojLicneKarte()
        {
            if (String.IsNullOrWhiteSpace(BrojLicneKarte))
            {
                return "Broj kreditne kartice mora biti unesen!";
            }
            //implementirati jos neki uslov
            return null;
        }
    }
}
