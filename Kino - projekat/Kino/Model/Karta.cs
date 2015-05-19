using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Model
{
    public class Karta
    {
        public Film Film { get; set; }
        
        public int Sala { get; set; }
        public int BrojSjedista { get; set;}
        public DateTime Termin {get; set;}
        public double Cijena { get; set; }
        public string RezervacijskiBroj { get; set; }

        public Karta()
        { }
        public Karta(Film film, int sala, int brSjedista, DateTime termin, double cijena, string rezBr = "")
        {
            Film = film;
            Sala = sala;
            BrojSjedista = brSjedista;
            Termin = termin;
            Cijena = cijena;
            RezervacijskiBroj = rezBr;
        }
    }
}
