using Kino.Model.Kokice;
using Kino.Model.Pice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModel;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows;
using System.Threading;
using System.Windows.Threading;

namespace Kino.ViewModel
{
    public class ProdajaDodatakViewModel : INotifyPropertyChanged
    {
        public GaziraniSok Cola { get; set; }
        public NegaziraniSok Sok { get; set; }
        public Voda Voda { get; set; }

        public SlaneKokice Kokice { get; set; }
        public SlatkeKokice KokiceS { get; set; }

        private int kolicinaMale;
        public int KolicinaMale
        {
            get { return kolicinaMale; }
            set { kolicinaMale = value; OnPropertyChanged("KolicinaMale"); }
        }

        private int kolicinaSrednje;
        public int KolicinaSrednje
        {
            get { return kolicinaSrednje; }
            set { kolicinaSrednje = value; OnPropertyChanged("KolicinaSrednje"); }
        }

        private int kolicinaVelike;
        public int KolicinaVelike
        {
            get { return kolicinaVelike; }
            set { kolicinaVelike = value; OnPropertyChanged("KolicinaVelike"); }
        }

        private int kolicinaMaleS;
        public int KolicinaMaleS
        {
            get { return kolicinaMaleS; }
            set { kolicinaMaleS = value; OnPropertyChanged("KolicinaMaleS"); }
        }

        private int kolicinaSrednjeS;
        public int KolicinaSrednjeS
        {
            get { return kolicinaSrednjeS; }
            set { kolicinaSrednjeS = value; OnPropertyChanged("KolicinaSrednjeS"); }
        }

        private int kolicinaVelikeS;
        public int KolicinaVelikeS
        {
            get { return kolicinaVelikeS; }
            set { kolicinaVelikeS = value; OnPropertyChanged("KolicinaVelikeS"); }
        }

        private int vodaCasa;
        public int VodaCasa
        {
            get { return vodaCasa; }
            set { vodaCasa = value; OnPropertyChanged("VodaCasa"); }
        }

        private int vodaFlasa;
        public int VodaFlasa
        {
            get { return vodaFlasa; }
            set { vodaFlasa = value; OnPropertyChanged("VodaFlasa"); }
        }

        private int colaCasa;
        public int ColaCasa
        {
            get { return colaCasa; }
            set { colaCasa = value; OnPropertyChanged("ColaCasa"); }
        }

        private int colaFlasa;
        public int ColaFlasa
        {
            get { return colaFlasa; }
            set { colaFlasa = value; OnPropertyChanged("ColaFlasa"); }
        }

        private int sokCasa;
        public int SokCasa
        {
            get { return sokCasa; }
            set { sokCasa = value; OnPropertyChanged("SokCasa"); }
        }

        private int sokFlasa;
        public int SokFlasa
        {
            get { return sokFlasa; }
            set { sokFlasa = value; OnPropertyChanged("SokFlasa"); }
        }

        private double ukupno;
        public double Ukupno
        {
            get { return ukupno; }
            set { ukupno = value; OnPropertyChanged("Ukupno"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ICommand Kupi { get; set; }
        public ICommand Nabavi { get; set; }
        public ICommand Cijena { get; set; }

        public ProdajaDodatakViewModel()
        {
            Cola = new GaziraniSok();
            Sok = new NegaziraniSok();
            Voda = new Voda();
            Kokice = new SlaneKokice();
            KokiceS = new SlatkeKokice();

            Kupi = new RelayCommand(kupi);
            Nabavi = new RelayCommand(nabavi);
            Cijena = new RelayCommand(cijena);

            Ukupno = 0.0;
            KolicinaMale = KolicinaMaleS = KolicinaSrednje = KolicinaSrednjeS = 0;
            KolicinaVelike = KolicinaVelikeS = 0;

            ColaCasa = ColaFlasa = SokCasa = SokFlasa = VodaCasa = VodaFlasa = 0;

        }

        public void kupi(object parametar)
        {
            ThreadPool.QueueUserWorkItem(o =>
            {
                Kokice.Kolicina -= (kolicinaVelike * Kokice.VelikeCijena + kolicinaSrednje * Kokice.SrednjeCijena
                                      + kolicinaMale * Kokice.MaleCijena);
                KokiceS.Kolicina -= (kolicinaVelikeS * KokiceS.VelikeCijena + kolicinaSrednjeS * KokiceS.SrednjeCijena
                                       + kolicinaMaleS * KokiceS.MaleCijena);
                Cola.Kolicina -= (colaCasa * Cola.CasaCijena + colaFlasa * Cola.FlasaCijena);
                Sok.Kolicina -= (sokCasa * Sok.CasaCijena + sokFlasa * Sok.FlasaCijena);
                Voda.Kolicina -= (vodaCasa * Voda.CasaCijena + vodaFlasa * Voda.FlasaCijena);

                MessageBox.Show("Kupovina uspješno obavljena!");

                Ukupno = 0.0;
                KolicinaMale = KolicinaMaleS = KolicinaSrednje = KolicinaSrednjeS = 0;
                KolicinaVelike = KolicinaVelikeS = 0;

                ColaCasa = ColaFlasa = SokCasa = SokFlasa = VodaCasa = VodaFlasa = 0;
            });
        }
        public void cijena(object parametar)
        {
            ThreadPool.QueueUserWorkItem(o =>
            {
               if (Kokice.Kolicina >= (kolicinaVelike * Kokice.VelikeCijena + kolicinaSrednje * Kokice.SrednjeCijena + kolicinaMale * Kokice.MaleCijena) &&
                   KokiceS.Kolicina >= (kolicinaVelikeS * KokiceS.VelikeCijena + kolicinaSrednjeS * KokiceS.SrednjeCijena + kolicinaMaleS * KokiceS.MaleCijena) &&
                   Cola.Kolicina >= (colaCasa * Cola.CasaCijena + colaFlasa * Cola.FlasaCijena) &&
                   Sok.Kolicina >= (sokCasa * Sok.CasaCijena + sokFlasa * Sok.FlasaCijena) &&
                   Voda.Kolicina >= (vodaCasa * Voda.CasaCijena + vodaFlasa * Voda.FlasaCijena))
               {
                   Ukupno = kolicinaVelike * Kokice.VelikeCijena + kolicinaSrednje * Kokice.SrednjeCijena +
                            kolicinaMale * Kokice.MaleCijena + kolicinaVelikeS * KokiceS.VelikeCijena +
                            kolicinaSrednjeS * KokiceS.SrednjeCijena + kolicinaMaleS * KokiceS.MaleCijena +
                            vodaCasa * Voda.CasaCijena + vodaFlasa * Voda.FlasaCijena + colaCasa * Cola.CasaCijena +
                            colaFlasa * Cola.FlasaCijena + sokCasa * Sok.CasaCijena + sokFlasa * Sok.FlasaCijena;
               }
               else MessageBox.Show("Nema dovoljno zaliha!");
            });
        }
        public void nabavi(object parametar)
        {
            ThreadPool.QueueUserWorkItem(o =>
            {
                Kokice.Kolicina += kolicinaVelike;
                KokiceS.Kolicina += kolicinaVelikeS;
                Cola.Kolicina += colaCasa;
                Sok.Kolicina += sokCasa;
                Voda.Kolicina += vodaCasa;

                KolicinaVelikeS = KolicinaVelike = ColaCasa = SokCasa = VodaCasa = 0;
                MessageBox.Show("Uspješno ste ažurirali zalihe!");
            });
        }


    }
}
