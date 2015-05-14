using Igrica.Klase.Interfejsi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igrica.Klase
{
    public class TrecaIgra : Igra
    {

        public void izaberiNivo(bool nivoLahki)
        {
            if (nivoLahki)
            {
                KoZnaZna igra3 = new KoZnaZna(); //ovo je koZnaZnaLahki 
                igra3.Show();
            }
            else
            {
                KoZnaZnaTeski igra3 = new KoZnaZnaTeski();
                igra3.Show();
                }
        }
    }
}
