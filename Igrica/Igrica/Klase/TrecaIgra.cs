using Igrica.Klase.Interfejsi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igrica.Klase
{
    public class TrecaIgra : Igra
    {
        public static List<Pitanje> Pitanja { get; set; }
        public void izaberiNivo(bool nivoLahki)
        {
            if (nivoLahki)
            {
                KoZnaZna igra3 = new KoZnaZna(); //ovo je koZnaZnaLahki 
                igra3.Show();
                Pitanja.Clear();
                Pitanja.Add(new Pitanje("Koliko dijelova Star Wars je snimljeno?", "4", "5", "6", "7", "6"));
                Pitanja.Add(new Pitanje("Ko je glavni glumac filma Indiana Jones?", "Leonardo Di Caprio", "Harrison Ford", "Steven Seagal", "Matt Damon", "Harrison Ford"));
                Pitanja.Add(new Pitanje("Koliko je oskara dobio glumac Leonardo Di Caprio?", "3", "1", "0", "2", "0"));
                Pitanja.Add(new Pitanje("Koliko dijelova filma Terminator je snimljeno dosad?", "3", "4", "5", "6", "4"));
                Pitanja.Add(new Pitanje("Kako se zove partner Sherlocka Holmesa?", "John H. Watson", "Alfred Pennyworth", "Hercule Poirot", "Agatha Christie", "John H. Watson"));
                Pitanja.Add(new Pitanje("Ko je glavni glumac u filmi Zmije u avionu(Snakes on a Plane?", "Morgan Freeman", "Cuba Gooding jr.", "Will Smith", "Samuel L. Jakcson", "Samuel L. Jakcson"));
            }
            else
            {
                KoZnaZnaTeski igra3 = new KoZnaZnaTeski();
                igra3.Show();
                Pitanja.Clear();
                Pitanja.Add(new Pitanje("Koje godine je objavljen prvi dio filma Matrix?", "1997", "1999", "2001", "2003", "1999"));
                Pitanja.Add(new Pitanje("Koji dio filma Gospodar Prstenova ima podnaslov 'The Two Towers'?", "nijedan", "prvi", "drugi", "treci", "drugi"));
                Pitanja.Add(new Pitanje("Zivot koje porodice je prikazan u filmu Kum?", "Bonanno", "Colombo", "Gambino", "Corleone", "Corleone"));
                Pitanja.Add(new Pitanje("Koji glumac se ne pojavljuje u prvom dijelu filma The Expendables?", "Terry Crews", "Jet Li", "Chuck Norris", "Dolph Lundgren", "Chuck Norris"));
                Pitanja.Add(new Pitanje("Sta nije bio Forrest Gump?", "vojnik", "stonoteniser", "kosarkas", "ragbi igrac", "ksoarkas"));
                Pitanja.Add(new Pitanje("Kako se zove lik Decimus Meridius, kojeg glumi Russel Crowe u filmu Gladiator?", "Minimus", "Midimus", "Maximus", "Optimus", "Maximus"));
            }
        }
    }
}
