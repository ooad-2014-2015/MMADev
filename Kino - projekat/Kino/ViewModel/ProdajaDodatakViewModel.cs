using Kino.Model.Kokice;
using Kino.Model.Pice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModel;

namespace Kino.ViewModel
{
    public class ProdajaDodatakViewModel
    {
        public KartaViewModel Parent { get; set; }
        public Action CloseAction { get; set; }

        public Pice Pice { get; set; }
        public Kokice Kokice { get; set; }

        public ICommand KupiKokice { get; set; }
        public ICommand NabaviKokice { get; set; }
        public ICommand KupiPice { get; set; }
        public ICommand NabaviPice { get; set; }

        public ProdajaDodatakViewModel()
        {
            Pice = new Pice();
            Kokice = new Kokice();

            KupiKokice = new RelayCommand(kupiKokice);
            NabaviKokice = new RelayCommand(nabaviKokice);
            KupiPice = new RelayCommand(kupiPice);
            KupiKokice = new RelayCommand(nabaviPice);
        }

        //ovdje implementirati funkcionalnosti
        public void kupiKokice(object parametar)
        { }
        public void nabaviKokice(object parametar)
        { }
        public void kupiPice(object parametar)
        { }
        public void nabaviPice(object parametar)
        { }
    }
}
