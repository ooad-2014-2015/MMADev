using Igrica.Klase;
using Igrica.Resources.Titanik;
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

namespace Igrica
{
    /// <summary>
    /// Interaction logic for PoveziScenu.xaml
    /// </summary>
    public partial class PoveziScenu : Window
    {
        public PoveziScenu()
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
            PoveziScenuTitanicTEski novaForma = new PoveziScenuTitanicTEski();
            novaForma.Show();
            this.Close();
            PrvaTeski.brojacT++;
            PrvaTeski.tacanOdgovor = false;
        }
    }
}
