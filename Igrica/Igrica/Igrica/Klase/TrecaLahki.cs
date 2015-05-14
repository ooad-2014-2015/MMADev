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

namespace Igrica.Klase.Interfejsi
{
    public class TrecaLahki: IStrategy3
    {
        public static int brojacPoenaL = 0;
        public static bool tacanOdgovor = false;

        public bool igraj(string odgovor, string tacan)
        {
            if (odgovor == tacan)
            {
                brojacPoenaL++;
                tacanOdgovor = true;
                MessageBox.Show("Tačno! \nOsvojili ste 1 poen.", "Tačan odgovor :)");
            }
            else 
            {
                brojacPoenaL--;
                MessageBox.Show("Netačno. \nIzgubili ste jedan poen.", "Netačan odgovor :(", MessageBoxButton.OK);
               
            }

            return odgovor == tacan;
        }
    }
}
