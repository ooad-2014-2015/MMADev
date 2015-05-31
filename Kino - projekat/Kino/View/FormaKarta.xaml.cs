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
using Kino.Model;
using Kino.ViewModel;

namespace Kino.View
{
    /// <summary>
    /// Interaction logic for FormaKarta.xaml
    /// </summary>
    public partial class FormaKarta : Window
    {
        public FormaKarta()
        {
            InitializeComponent();
            KartaViewModel kvm = new KartaViewModel();
            base.DataContext = kvm;
        }


    }
}
