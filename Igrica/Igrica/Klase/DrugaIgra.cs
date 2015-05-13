using Igrica.Klase.Interfejsi;
using Igrica.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igrica.Klase
{
    public class DrugaIgra : Igra
    {
       public  void izaberiNivo(bool nivoLahki)
        {
            if(nivoLahki)
            {
                Spajalica igra2 = new Spajalica(); //ovo je spajalicaLahki 
                igra2.Show();
            }
            else
            {
                SpajalicaTeski igra2 = new SpajalicaTeski();
                igra2.Show();
            }
        }
    }
}
