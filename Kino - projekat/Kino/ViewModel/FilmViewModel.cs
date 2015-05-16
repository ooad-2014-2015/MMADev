using Kino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModel;

namespace Kino.ViewModel
{
    public class FilmViewModel
    {
        public KartaViewModel Parent { get; set; }
        public Action CloseAction { get; set; }

        public ICommand DodajFilm { get; set; }
        public ICommand NapraviRaspored { get; set; }

        public Film Film { get; set; }
        public FilmViewModel()
        {
            Film = new Film();

            DodajFilm = new RelayCommand(dodajFilm);
            NapraviRaspored = new RelayCommand(napraviRaspored);
        }

        //implementirati funcionalnosti
        public void dodajFilm(object parametar)
        { }

        public void napraviRaspored(object parametar)
        { }



        
    }
}
