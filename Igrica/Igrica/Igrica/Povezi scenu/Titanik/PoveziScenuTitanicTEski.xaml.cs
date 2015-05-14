using Igrica.Klase;
using Igrica.Resources.Sherlock;
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
using System.Windows.Shapes;

namespace Igrica.Resources.Titanik
{
    /// <summary>
    /// Interaction logic for PoveziScenuTitanicTEski.xaml
    /// </summary>
    public partial class PoveziScenuTitanicTEski : Window
    {
        public PoveziScenuTitanicTEski()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PrvaTeski novaIgra = new PrvaTeski();
            novaIgra.igraj(UnosFilma.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SherlockTeski novaForma = new SherlockTeski();
            novaForma.Show();
            this.Close();
            PrvaTeski.brojacT++;
            PrvaTeski.tacanOdgovor = false;
        }
    }
}
