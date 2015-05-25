using Kino.Model;
using Kino.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using ViewModel;

namespace Kino.ViewModel
{
    public class KartaViewModel : INotifyPropertyChanged
    {
        public FilmViewModel DijeteFilmViewModel { get; set; }
        public ProdajaDodatakViewModel DijeteProdajaDodatakViewModel { get; set; }
        public FormaFilm FormaFilmView { get; set; }
        public FormaDodaci FormaDodaciView { get; set; }

        private Karta karta;
        public Karta Karta
        { 
            get { return karta; }
            set { karta = value; OnPropertyChanged("Karta"); } 
        }

        private Klijent klijent;
        public Klijent Klijent
        {
            get { return klijent; }
            set { klijent = value; OnPropertyChanged("Klijent"); }
        }

        public ICommand UnosFilmova { get; set; }
        public ICommand KupiDodatke { get; set; }
        public ICommand RezervisiKartu { get; set; }
        public ICommand KupiKartu { get; set; }
        public ICommand RegistrujKlijenta { get; set; }

        public KartaViewModel()
        {
            karta = new Karta();
            klijent = new Klijent();
            DijeteFilmViewModel = new FilmViewModel();
            DijeteProdajaDodatakViewModel = new ProdajaDodatakViewModel();

            DijeteFilmViewModel.Parent = this;
            DijeteProdajaDodatakViewModel.Parent = this;

            UnosFilmova = new RelayCommand(unosFilmova);
            KupiDodatke = new RelayCommand(kupiDodatke);
            RezervisiKartu = new RelayCommand(rezervisiKartu);
            KupiKartu = new RelayCommand(kupiKartu);
            RegistrujKlijenta = new RelayCommand(registrujKlijenta);
        }

        //ovjde se raealizuju funkcionalnosti
        public void unosFilmova(object parametar)
        {
            FormaFilmView = new FormaFilm();
            FormaFilmView.DataContext = DijeteFilmViewModel;
            if(DijeteFilmViewModel.CloseAction == null)
            {
                DijeteFilmViewModel.CloseAction = new Action(() => FormaFilmView.Close());
            }
            FormaFilmView.Show();
        }

        public void kupiDodatke(object parametar)
        {
            FormaDodaciView = new FormaDodaci();
            FormaDodaciView.DataContext = DijeteProdajaDodatakViewModel;
            if (DijeteProdajaDodatakViewModel.CloseAction == null)
            {
                DijeteProdajaDodatakViewModel.CloseAction = new Action(() => FormaDodaciView.Close());
            }
            FormaDodaciView.Show();
        }

        public void rezervisiKartu(object parametar)
        { }
        public void kupiKartu(object parametar)
        { }
        public void registrujKlijenta(object parametar)
        { }

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
