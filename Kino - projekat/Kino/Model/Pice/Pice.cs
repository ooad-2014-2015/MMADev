﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Model.Pice
{
    public class Pice
    {
        public double CasaCijena { get; set; }
        public double FlasaCijena { get; set; }
        public int Kolicina { get; set; }

        public Pice(double CasaCijena, double FlasaCijena, int Kolicina)
        {
            this.CasaCijena = CasaCijena;
            this.FlasaCijena = FlasaCijena;
            this.Kolicina = Kolicina; 
        }

        public Pice() { }
    }
}
