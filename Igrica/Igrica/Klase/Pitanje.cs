using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igrica.Klase
{
    public class Pitanje
    {
        private string pitanje;
        private string odgovor1;
        private string odgovor2;
        private string odgovor3;
        private string odgovor4;
        private string tacanOdgovor;
        public Pitanje(string pitanje, string odgovor1, string odgovor2, string odgovor3,
            string odgovor4, string tacanOdgovor)
        {
            this.pitanje = pitanje;
            this.odgovor1 = odgovor1;
            this.odgovor1 = odgovor2;
            this.odgovor1 = odgovor3;
            this.odgovor1 = odgovor4;
            this.odgovor1 = tacanOdgovor;
        }
        public string Pitanjee
        {
            get { return pitanje; }
            set { pitanje = value; }
        }

        public string Odgovor1
        {
            get { return odgovor1; }
            set { odgovor1 = value; }
        }

        public string Odgovor2
        {
            get { return odgovor2; }
            set { odgovor2 = value; }
        }
        public string Odgovor3
        {
            get { return odgovor3; }
            set { odgovor3 = value; }
        }

        public string Odgovor4
        {
            get { return odgovor4; }
            set { odgovor4 = value; }
        }

        public string TacanOdgovor
        {
            get { return tacanOdgovor; }
            set { tacanOdgovor = value; }
        }
    }
}
