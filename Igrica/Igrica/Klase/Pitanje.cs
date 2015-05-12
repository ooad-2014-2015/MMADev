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
        private int tacanOdgovor;
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

        public int TacanOdgovor
        {
            get { return tacanOdgovor; }
            set { tacanOdgovor = value; }
        }
    }
}
