using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Model.Pice
{
    public class Voda : Pice
    {
        public Voda() : base()
        {
            CasaCijena = 0.5;
            FlasaCijena = 1;
            Kolicina = 1000;
        }
    }
}
