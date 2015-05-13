using Igrica.Klase.Interfejsi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igrica.Klase
{
    public class DrugaTeski: IStrategy2
    {
        public bool igraj(string glumac, string film)
        { 
            return film.Substring(0, 2) == glumac.Substring(0, 2); 
        }
    }
}
