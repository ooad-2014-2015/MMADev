using Igrica.Klase;
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

using System.Windows.Navigation;
using Igrica.Resources;


namespace Igrica.Resources.Sherlock
{
    /// <summary>
    /// Interaction logic for SherlockTeski.xaml
    /// </summary>
    public partial class SherlockTeski : Window
    {
        public SherlockTeski()
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
            this.Close();
            if (PrvaTeski.brojacPoenaT > 3) PrvaTeski.brojacPoenaT = 3;
            MessageBox.Show("Kraj igre!! \nOsvojili ste " + Convert.ToString(PrvaTeski.brojacPoenaT) + "/3 poena");
            
        }
    }
}
