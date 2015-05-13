using Igrica.Klase.Interfejsi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Igrica.Klase
{
    public class PrvaTeski : IStrategy1
    {
        private List<string> lista = new List<string>{"Avatar", "Titanic", "Sherlock Holmes"};
        public static int brojacT = 0;
        public static int brojacPoenaT = 0;
        public void igraj(string film)
        {
            if (film == lista[brojacT])
            {
                MessageBox.Show("Tačno!", ":)");
                brojacPoenaT++;
            }

            else MessageBox.Show("Netačno", ":(");

        }
    }
}
