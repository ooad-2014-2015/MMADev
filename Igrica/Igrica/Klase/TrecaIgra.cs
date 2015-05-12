using Igrica.Klase.Interfejsi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igrica.Klase
{
    public class TrecaIgra : Igra, IStrategy3
    {
        public List<Pitanje> Pitanja {get; set;}

        public void igraj()
        { }

        void izaberiNivo(bool nivoLahki)
        {
 
        }
    }
}
