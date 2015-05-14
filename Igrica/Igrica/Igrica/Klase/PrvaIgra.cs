using Igrica.Klase.Interfejsi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igrica.Klase
{
    public class PrvaIgra : Igra
    {
        public void izaberiNivo(bool nivoLahki)
        {
            if (nivoLahki)
            {
                PoveziScenuAvatarLahki igra1 = new PoveziScenuAvatarLahki();
                igra1.Show();
            }

            else 
            {    
                PoveziScenu igra1 = new PoveziScenu();
                igra1.Show();
            }
        }


    }
}
