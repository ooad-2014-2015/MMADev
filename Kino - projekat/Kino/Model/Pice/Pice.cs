using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Model.Pice
{
    public class Pice : INotifyPropertyChanged
    {
        public double CasaCijena { get; set; }
        public double FlasaCijena { get; set; }
        public double Kolicina { get; set; }

        public Pice(double CasaCijena, double FlasaCijena, int Kolicina)
        {
            this.CasaCijena = CasaCijena;
            this.FlasaCijena = FlasaCijena;
            this.Kolicina = Kolicina; 
        }

        public Pice() { }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
