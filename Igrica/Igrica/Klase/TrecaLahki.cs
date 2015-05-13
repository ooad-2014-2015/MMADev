using Igrica.Klase.Interfejsi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igrica.Klase.Interfejsi
{
    public class TrecaLahki: IStrategy3
    {
        public bool igraj(string odgovor, string tacan)
        {
            return odgovor == tacan;
        }
    }
}
