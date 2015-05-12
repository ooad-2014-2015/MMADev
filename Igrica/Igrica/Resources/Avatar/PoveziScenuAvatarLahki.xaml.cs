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
    /// Interaction logic for PoveziScenuAvatarLahki.xaml
    /// </summary>
    public partial class PoveziScenuAvatarLahki : Window
    {
        public PoveziScenuAvatarLahki()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PrvaLahki novaIgra = new PrvaLahki();
            novaIgra.igraj((string)DugmeAvatar.Content);
        }

        private void DugmeAlisauzemljiCuda_Click(object sender, RoutedEventArgs e)
        {
            PrvaLahki novaIgra = new PrvaLahki();
            novaIgra.igraj((string)DugmeAlisauzemljiCuda.Content);
        }

        public void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PoveziScenuTitanicLahki novaforma = new PoveziScenuTitanicLahki();
            novaforma.Show();
            this.Close();
            PrvaLahki.brojacL++;
        }
    }
}
