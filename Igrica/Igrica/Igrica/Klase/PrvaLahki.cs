using Igrica.Klase.Interfejsi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;



namespace Igrica.Klase
{
    public class PrvaLahki : IStrategy1
    {
        private List<string> lista = new List<string> { "Avatar", "Titanic", "Sherlock Holmes"};
        public static int brojacL = 0;
        public static int brojacPoenaL = 0;
        //varijabla koja ce nam pomoc da kontrolisemo bodove ukoliko se ne predje na sljedecu sliku
        public static bool tacanOdgovor = false;
        public void igraj(string film)
        {
            if (film == lista[brojacL])
            {
                if (!tacanOdgovor)
                {
                    MessageBox.Show("Tačno! \nOsvojili ste 1 poen.", "Tačan odgovor :)");
                    brojacPoenaL++;
                    tacanOdgovor = true;
                }
            }

            else
            {
                if (!tacanOdgovor)
                {
                    MessageBox.Show("Netačno. \nIzgubili ste jedan poen.", "Netačan odgovor :(", MessageBoxButton.OK);
                    brojacPoenaL--;
                }
            }
            
        }
    }
}
