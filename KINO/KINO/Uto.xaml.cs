using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace KINO
{
    public partial class Uto : PhoneApplicationPage
    {
        public Uto()
        {
            InitializeComponent();
            using (MMA_kinoContext db = new MMA_kinoContext(MMA_kinoContext.ConnectionString))
            {
                db.CreateIfNotExists();
                try
                {

                    Table<Uto_Sala1> film = db.GetTable<Uto_Sala1>();
                    var filmQuery = from f in film.ToList() select f;
                    foreach (var film1 in filmQuery)
                    {
                        PivotItem p = new PivotItem();
                        FilmKontorla filmKontrola = new FilmKontorla();
                        filmKontrola.Cijena.Text = film1.Cijena + " KM";
                        filmKontrola.Termin.Text = film1.Termin;
                        if (film1.Slika.ToArray() != null && film1.Slika.ToArray() is Byte[])
                        {
                            MemoryStream stream = new MemoryStream(film1.Slika.ToArray());
                            BitmapImage image = new BitmapImage();
                            image.SetSource(stream);
                            filmKontrola.Slika.Source = image;
                        }
                        p.Header = film1.Naziv;
                        p.Content = filmKontrola;
                        pivot.Items.Add(p);
                    }

                }
                catch (Exception et)
                {

                }
            }
        }
    }
}