using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Kino.Model.Kokice
{
    public class Kokice : INotifyPropertyChanged
    {
        public int MaleCijena {get; set;}
        public int SrednjeCijena {get; set;}
        public int VelikeCijena { get; set; }
        public int Kolicina { get; set; }

        public Kokice(int MaleCijena, int SrednjeCijena, int VelikeCijena, int Kolicina)
        {
            this.MaleCijena = MaleCijena;
            this.SrednjeCijena = SrednjeCijena;
            this.VelikeCijena = VelikeCijena;
            this.Kolicina = Kolicina;
        }

        public Kokice() { }

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
